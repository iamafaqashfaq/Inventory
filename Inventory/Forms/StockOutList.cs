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
    public partial class StockOutList : Form
    {
        public StockOutList()
        {
            InitializeComponent();
        }
        void LoadDataGridView()
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    dtglist.DataSource = context.StockOut.OrderByDescending(t => t.TransactionDate).Select(x => new
                    {
                        CustomerName = x.FirstName + " " + x.LastName,
                        ContactNumber = x.ContactNumber,
                        ItemName = x.StockItems.Name,
                        Description = x.StockItems.Description,
                        Qty = x.Qty,
                        Price = x.Price,
                        TotalPrice = x.TotalPrice,
                        TransactionDate = x.TransactionDate
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StockOutList_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    LoadDataGridView();
                }
                else
                {
                    using (AppContext context = new AppContext())
                    {
                        dtglist.DataSource = context.StockOut.Where(u => u.StockItems.Name.Contains(txtsearch.Text) 
                        || u.StockItems.Description.Contains(txtsearch.Text) || u.StockItems.Category.Name.Contains(txtsearch.Text) 
                        || u.FirstName.Contains(txtsearch.Text) || u.LastName.Contains(txtsearch.Text) 
                        || u.ContactNumber.Contains(txtsearch.Text)).OrderByDescending(t => t.TransactionDate).Select(x => new
                        {
                            CustomerName = x.FirstName + " " + x.LastName,
                            ContactNumber = x.ContactNumber,
                            ItemName = x.StockItems.Name,
                            Description = x.StockItems.Description,
                            Qty = x.Qty,
                            Price = x.Price,
                            TotalPrice = x.TotalPrice,
                            TransactionDate = x.TransactionDate
                        }).ToList();
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
