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

namespace Inventory.DevForms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        RibbonForm mdiForm;
        public Login(RibbonForm mdiForm)
        {
            this.mdiForm = mdiForm;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control obj in this.Controls)
            {
                if (obj is TextBox)
                {
                    if (String.IsNullOrEmpty(obj.Text))
                    {
                        MessageBox.Show("All Fields are required", "Empty Fields");
                        return;
                    }
                }
            }
            using (AppContext context = new AppContext())
            {
                var check = context.Users.Any();
                if (!check)
                {
                    var addUser = new Model.ApplicationUser()
                    {
                        Username = "admin",
                        Password = "admin",
                        Name = "admin",
                        Type = "Administrator"
                    };
                    context.Users.Add(addUser);
                    context.SaveChanges();
                    this.mdiForm.enableControls();
                    this.Close();
                }
                var user = context.Users.FirstOrDefault(u => u.Username == textBox1.Text && u.Password == textBox2.Text);
                if (user != null)
                {
                    this.mdiForm.enableControls();
                    this.Close();
                }
            }
        }
    }
}