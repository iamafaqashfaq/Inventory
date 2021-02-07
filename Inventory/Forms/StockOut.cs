using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class StockOut : Form
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
                    if(i == Convert.ToInt32(selectedRow.Cells[0].Value))
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
    }
}
