using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevForms.ManageUser mu = new DevForms.ManageUser();
            mu.MdiParent = this;
            mu.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevForms.Settings ss = new DevForms.Settings();
            ss.MdiParent = this;
            ss.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevForms.StockMaster sm = new DevForms.StockMaster();
            sm.MdiParent = this;
            sm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevForms.StockOut so = new DevForms.StockOut();
            so.MdiParent = this;
            so.Show();
        }
        public void enableControls()
        {
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = true;
            barButtonItem3.Enabled = true;
            barButtonItem4.Enabled = true;
        }
        public void disableControls()
        {
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem4.Enabled = false;
        }
        private void RibbonForm_Load(object sender, EventArgs e)
        {
            disableControls();
            DevForms.Login login = new DevForms.Login(this);
            login.MdiParent = this;
            login.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}