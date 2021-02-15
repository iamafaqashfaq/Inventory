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
    public partial class StockOutListItem : Form
    {
        public int id;
        public StockOutListItem(int id)
        {
            
            InitializeComponent();
            this.id = id;
            loadDataTable();
        }
        void loadDataTable()
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    dataGridView1.DataSource = context.StockOut.Include(i => i.StockOrder).OrderByDescending(t => t.TransactionDate).Where(s => s.StockOrderId == id).Select(x => new
                    {
                        Id = x.Id,
                        Product = x.StockItems.Name,
                        Description = x.StockItems.Description,
                        Qty = x.Qty,
                        Price = x.Price,
                        Total = x.TotalPrice,
                        TransactionDate = x.TransactionDate
                    }).ToList();
                    dataGridView1.Columns[0].Visible = false;
                    //dtglist.Columns[1].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StockOutListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
