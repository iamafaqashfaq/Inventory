using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ReportsForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnitemlisat_Click(object sender, EventArgs e)
        {
            using(AppContext context = new AppContext())
            {
                DevForms.Reports.ListOfItems loi = new DevForms.Reports.ListOfItems();
                loi.DataSource = context.StockItems.Include(c=> c.Category).Include(u => u.Unit).ToList();
                loi.CreateDocument();
                documentViewer1.DocumentSource = loi;
                documentViewer1.Show();
            }
            
        }

        private void btnListStockin_Click(object sender, EventArgs e)
        {
            if(cbooption.Text == "Daily Report")
            {
                using (AppContext context = new AppContext())
                {
                    DevForms.Reports.ListOfStockItemByDate loi = new DevForms.Reports.ListOfStockItemByDate();
                    loi.DataSource = context.StockItems.Include(c => c.Category).Include(u => u.Unit).Where(t => DbFunctions.TruncateTime(t.TransactionDate) == DbFunctions.TruncateTime(DateTime.Now)).ToList();
                    loi.CreateDocument();
                    documentViewer1.DocumentSource = loi;
                    documentViewer1.Show();
                }
            }
            if(cbooption.Text == "Weekly Report")
            {
                using (AppContext context = new AppContext())
                {
                    var date = DateTime.Now.AddDays(-7);
                    DevForms.Reports.ListOfStockItemByDate loi = new DevForms.Reports.ListOfStockItemByDate();
                    loi.DataSource = context.StockItems.Include(c => c.Category).Include(u => u.Unit).Where(t => DbFunctions.TruncateTime(t.TransactionDate) >= DbFunctions.TruncateTime(date)).ToList();
                    loi.CreateDocument();
                    documentViewer1.DocumentSource = loi;
                    documentViewer1.Show();
                }
            }
            if (cbooption.Text == "Monthly Report")
            {
                using (AppContext context = new AppContext())
                {
                    DevForms.Reports.ListOfStockItemByDate loi = new DevForms.Reports.ListOfStockItemByDate();
                    loi.DataSource = context.StockItems.Include(c => c.Category).Include(u => u.Unit).Where(t => t.TransactionDate.Month == DateTime.Now.Month).ToList();
                    loi.CreateDocument();
                    documentViewer1.DocumentSource = loi;
                    documentViewer1.Show();
                }
            }
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            if (cbooption.Text == "Daily Report")
            {
                using (AppContext context = new AppContext())
                {
                    DevForms.Reports.ListOfSoldItems loi = new DevForms.Reports.ListOfSoldItems();
                    loi.DataSource = context.StockOut.Include(c => c.StockItems).Include(c => c.StockItems.Category).Where(t => DbFunctions.TruncateTime(t.TransactionDate) == DbFunctions.TruncateTime(DateTime.Now)).ToList();
                    loi.CreateDocument();
                    documentViewer1.DocumentSource = loi;
                    documentViewer1.Show();
                }
            }
            if (cbooption.Text == "Weekly Report")
            {
                using (AppContext context = new AppContext())
                {
                    var date = DateTime.Now.AddDays(-7);
                    DevForms.Reports.ListOfSoldItems loi = new DevForms.Reports.ListOfSoldItems();
                    loi.DataSource = context.StockOut.Include(c => c.StockItems).Include(c => c.StockItems.Category).Where(t => DbFunctions.TruncateTime(t.TransactionDate) >= DbFunctions.TruncateTime(date)).ToList();
                    loi.CreateDocument();
                    documentViewer1.DocumentSource = loi;
                    documentViewer1.Show();
                }
            }
            if (cbooption.Text == "Monthly Report")
            {
                using (AppContext context = new AppContext())
                {
                    DevForms.Reports.ListOfSoldItems loi = new DevForms.Reports.ListOfSoldItems();
                    loi.DataSource = context.StockOut.Include(c => c.StockItems).Include(c => c.StockItems.Category).Where(t => t.TransactionDate.Month == DateTime.Now.Month).ToList();
                    loi.CreateDocument();
                    documentViewer1.DocumentSource = loi;
                    documentViewer1.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AppContext context = new AppContext())
            {
                DevForms.Reports.ListOfSoldItems loi = new DevForms.Reports.ListOfSoldItems();
                loi.DataSource = context.StockOut.Include(c => c.StockItems).Include(c => c.StockItems.Category).Where(t => DbFunctions.TruncateTime(t.TransactionDate) >= DbFunctions.TruncateTime(dptfrom.Value.Date) && DbFunctions.TruncateTime(t.TransactionDate) <= DbFunctions.TruncateTime(dtpto.Value.Date)).ToList();
                loi.CreateDocument();
                documentViewer1.DocumentSource = loi;
                documentViewer1.Show();
            }
        }
    }
}