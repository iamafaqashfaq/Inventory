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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            foreach(Control obj in panel1.Controls)
            {
                if(obj is TextBox)
                {
                    obj.Text = "";
                }
            }
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {

        }
    }
}
