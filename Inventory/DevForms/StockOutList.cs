using DevExpress.XtraEditors;
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
using DevExpress.XtraReports.UI;

namespace Inventory.DevForms
{
    public partial class StockOutList : DevExpress.XtraEditors.XtraForm
    {
        int id = 0;
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
                        Id = x.Id,
                        CustomerName = x.FirstName + " " + x.LastName,
                        ContactNumber = x.ContactNumber,
                        ItemName = x.StockItems.Name,
                        Description = x.StockItems.Description,
                        Qty = x.Qty,
                        Price = x.Price,
                        TotalPrice = x.TotalPrice,
                        TransactionDate = x.TransactionDate
                    }).ToList();
                    dtglist.Columns[0].Visible = false;
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using(AppContext context = new AppContext())
            {
                if(id == 0)
                {
                    MessageBox.Show("No Order Selected");
                    return;
                }
                var uuid = context.StockOut.Find(id);
                DevForms.Reports.Invoice.SaleInvoice saleinvoice = new Reports.Invoice.SaleInvoice();
                saleinvoice.DataSource = context.StockOut.Include(u => u.StockItems).Where(c =>c.TransactionID == uuid.TransactionID).ToList();
                saleinvoice.CreateDocument();
                ReportPrintTool reportPrintingTool = new ReportPrintTool(saleinvoice);
                reportPrintingTool.PrintDialog();
            }
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtglist.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtglist.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtglist.Rows[selectedrowindex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }
    }
}