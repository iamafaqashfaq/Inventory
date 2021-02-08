using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Inventory.DevForms
{
    public partial class StockOut : DevExpress.XtraEditors.XtraForm
    {
        public StockOut()
        {
            InitializeComponent();
        }
        void LoadItemGrid()
        {
            using (AppContext context = new AppContext())
            {
                dataGridView1.DataSource = context.StockItems.Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Qty = x.Qty,
                    Price = x.Price,
                    Unit = x.Unit.Name,
                    Category = x.Category.Name,
                    categoryid = x.CategoryId,
                    unitid = x.UnitId,
                    EntryDate = x.TransactionDate
                }).ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
            }

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCus_clear_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (Control obj in Panel1.Controls)
            {
                if (obj is TextBox)
                {
                    obj.Text = "";
                }
            }
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            LoadItemGrid();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    LoadItemGrid();
                }
                else
                {
                    using (AppContext context = new AppContext())
                    {
                        dataGridView1.DataSource = context.StockItems.Where(u => u.Name.Contains(txtsearch.Text) || u.Description.Contains(txtsearch.Text) || u.Category.Name.Contains(txtsearch.Text)).Select(x => new
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Description = x.Description,
                            Qty = x.Qty,
                            Price = x.Price,
                            Unit = x.Unit.Name,
                            Category = x.Category.Name,
                            categoryid = x.CategoryId,
                            unitid = x.UnitId,
                            EntryDate = x.TransactionDate
                        }).ToList();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                var total = Convert.ToDouble(selectedRow.Cells[4].Value) * 1;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var i = Convert.ToInt32(row.Cells[0].Value);
                    if (i == Convert.ToInt32(selectedRow.Cells[0].Value))
                    {
                        row.Cells[4].Value = Convert.ToInt32(row.Cells[4].Value) + 1;
                        row.Cells[5].Value = Convert.ToInt32(row.Cells[4].Value) * Convert.ToDouble(selectedRow.Cells[4].Value);
                        return;
                    }
                }
                dataGridView2.Rows.Add(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value, selectedRow.Cells[2].Value, selectedRow.Cells[4].Value, 1, total);
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double total;
                if (dataGridView2.CurrentCell.ColumnIndex == 4)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        total = double.Parse(row.Cells[4].Value.ToString()) * double.Parse(row.Cells[3].Value.ToString());
                        row.Cells[5].Value = total;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCus_Remove_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btnCus_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count != 0)
                {
                    using (AppContext context = new AppContext())
                    {
                        bool add = true;
                        List<Model.StockOut> stockOutList = new List<Model.StockOut>();
                        string uuid = System.Guid.NewGuid().ToString();
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            int id = Convert.ToInt32(row.Cells[0].Value);
                            var stockItem = context.StockItems.FirstOrDefault(u => u.Id == id);
                            if (stockItem.Qty >= Convert.ToInt32(row.Cells[4].Value))
                            {
                                stockItem.Qty = stockItem.Qty - Convert.ToInt32(row.Cells[4].Value);
                                context.Entry(stockItem).State = System.Data.Entity.EntityState.Modified;
                                context.SaveChanges();
                                stockOutList.Add(new Model.StockOut()
                                {
                                    StockItemId = Convert.ToInt32(row.Cells[0].Value),
                                    FirstName = txtCus_fname.Text == "" ? "Cash Sale" : txtCus_fname.Text,
                                    LastName = txtCus_lname.Text == "" ? "" : txtCus_lname.Text,
                                    ContactNumber = textBox1.Text,
                                    Qty = Convert.ToInt32(row.Cells[4].Value),
                                    Price = Convert.ToDouble(row.Cells[3].Value),
                                    TotalPrice = Convert.ToDouble(row.Cells[5].Value),
                                    TransactionDate = DateTime.Now,
                                    TransactionID = uuid
                                });
                            }
                            else
                            {
                                add = false;
                                MessageBox.Show("There are total " + stockItem.Qty.ToString() + " " + row.Cells[1].Value.ToString() + "\' in Stock");
                            }
                        }
                        if (add)
                        {
                            context.StockOut.AddRange(stockOutList);
                            context.SaveChanges();
                            MessageBox.Show("Added Successfully");
                            LoadItemGrid();
                            var date = stockOutList[0].TransactionDate;
                            DevForms.Reports.Invoice.SaleInvoice saleinvoice = new Reports.Invoice.SaleInvoice();
                            saleinvoice.DataSource = context.StockOut.Include(u => u.StockItems).Where(c => c.TransactionID == uuid).ToList();
                            saleinvoice.CreateDocument();
                            ReportPrintTool reportPrintingTool = new ReportPrintTool(saleinvoice);
                            reportPrintingTool.PrintDialog();
                            btnCus_clear_Click(sender, e);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnviewStockout_Click(object sender, EventArgs e)
        {
        }

        private void btnviewStockout_Click_1(object sender, EventArgs e)
        {
            StockOutList sol = new StockOutList();
            sol.Show();
        }
    }
}