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
    public partial class MDIForm : Form
    {

        public MDIForm()
        {
            InitializeComponent();
        }

        public void disableButton()
        {
            foreach(Control obj in panel1.Controls)
            {
                if(obj is Button)
                {
                    obj.Enabled = false;
                }
            }
        }
        public void enableButton()
        {
            foreach (Control obj in panel1.Controls)
            {
                if (obj is Button)
                {
                    obj.Enabled = true;
                }
            }
        }
        void showForm(Form frm) {
            frm.MdiParent = this;
            frm.Show();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            disableButton();
            this.IsMdiContainer = true;
            showForm(new LoginForm(this));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showForm(new Forms.Settings());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showForm(new Forms.ManageUser());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showForm(new Forms.StockMaster());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showForm(new Forms.StockOut());
        }
    }
}
