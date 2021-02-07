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
    public partial class StockMaster : Form
    {
        int itemUpdateId = 0;
        public StockMaster()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadComboBoxes()
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    cbotype.DataSource = context.Category.ToList();
                    cbotype.DisplayMember = "Name";
                    cbotype.ValueMember = "Id";

                    cbounit.DataSource = context.Units.ToList();
                    cbounit.DisplayMember = "Name";
                    cbounit.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadDataGridView()
        {
            using (AppContext context = new AppContext())
            {
                dtglist.DataSource = context.StockItems.Select(x => new
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
                dtglist.Columns[0].Visible = false;
                dtglist.Columns[7].Visible = false;
                dtglist.Columns[8].Visible = false;
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            foreach (Control obj in pnl_stockmaster.Controls)
            {
                if (obj is TextBox)
                {
                    obj.Text = "";
                }
                if(obj is RichTextBox)
                {
                    obj.Text = "";
                }
            }
            itemUpdateId = 0;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void StockMaster_Load(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            LoadComboBoxes();
            LoadDataGridView();
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtglist.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtglist.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtglist.Rows[selectedrowindex];
                txtname.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txtdescription.Text = Convert.ToString(selectedRow.Cells[2].Value);
                txtqty.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txtprice.Text = Convert.ToString(selectedRow.Cells[4].Value);
                cbotype.SelectedValue = Convert.ToInt32(selectedRow.Cells[7].Value);
                cbounit.SelectedValue = Convert.ToInt32(selectedRow.Cells[8].Value);
                itemUpdateId = Convert.ToInt32(selectedRow.Cells[0].Value);
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    if(itemUpdateId != 0)
                    {
                        var item = context.StockItems.Find(itemUpdateId);
                        if(item != null)
                        {
                            context.StockItems.Remove(item);
                            context.SaveChanges();
                            MessageBox.Show("Deleted Successfully");
                            LoadDataGridView();
                            btnnew_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    foreach (Control obj in pnl_stockmaster.Controls)
                    {
                        if (obj is TextBox)
                        {
                            if (obj.Text == "" && obj != txtsearch)
                            {
                                MessageBox.Show("Cannot Save Empty Fields");
                                return;
                            }
                        }
                    }
                    var stockItem = new Model.StockItems()
                    {
                        Name = txtname.Text,
                        Description = txtdescription.Text,
                        Price = Convert.ToDouble(txtprice.Text),
                        Qty = Convert.ToInt32(txtqty.Text),
                        CategoryId = Convert.ToInt32(cbotype.SelectedValue),
                        UnitId = Convert.ToInt32(cbounit.SelectedValue),
                        TransactionDate = DateTime.Now
                    };
                    context.StockItems.Add(stockItem);
                    context.SaveChanges();
                    MessageBox.Show("Successfully Saved");
                    LoadDataGridView();
                    btnnew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    var item = context.StockItems.Find(itemUpdateId);
                    if(item != null)
                    {
                        item.Name = txtname.Text;
                        item.Description = txtdescription.Text;
                        item.Price = Convert.ToDouble(txtprice.Text);
                        item.Qty = Convert.ToInt32(txtqty.Text);
                        item.CategoryId = Convert.ToInt32(cbotype.SelectedValue);
                        item.UnitId = Convert.ToInt32(cbounit.SelectedValue);
                        item.TransactionDate = DateTime.Now;
                        context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        LoadDataGridView();
                        btnnew_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtsearch.Text == "")
                {
                    LoadDataGridView();
                } else
                {
                    using (AppContext context = new AppContext())
                    {
                        dtglist.DataSource = context.StockItems.Where(u => u.Name.Contains(txtsearch.Text) || u.Description.Contains(txtsearch.Text) || u.Category.Name.Contains(txtsearch.Text)).Select(x => new
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
                        dtglist.Columns[0].Visible = false;
                        dtglist.Columns[7].Visible = false;
                        dtglist.Columns[8].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
