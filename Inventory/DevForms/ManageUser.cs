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
    public partial class ManageUser : DevExpress.XtraEditors.XtraForm
    {
        int userid = 0;
        public ManageUser()
        {
            InitializeComponent();
        }
        void LoadUserDataGrid()
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    dtg_listUser.DataSource = context.Users.ToList();
                    dtg_listUser.Columns[0].Visible = false;
                    dtg_listUser.Columns[3].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    foreach (Control obj in panel1.Controls)
                    {
                        if (obj is TextBox)
                        {
                            if (obj.Text == "")
                            {
                                return;
                            }
                        }
                    }
                    var user = new Model.ApplicationUser()
                    {
                        Name = txt_name.Text,
                        Username = txt_username.Text,
                        Password = txt_pass.Text,
                        Type = cbo_type.Text
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("User Successfully Added");
                    LoadUserDataGrid();
                    foreach (Control obj in panel1.Controls)
                    {
                        if (obj is TextBox)
                        {
                            obj.Text = "";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            LoadUserDataGrid();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (userid != 0)
                {
                    using (AppContext context = new AppContext())
                    {
                        var user = context.Users.FirstOrDefault(u => u.Id == userid);
                        if (user != null)
                        {
                            user.Name = txt_name.Text;
                            user.Username = txt_username.Text;
                            user.Password = txt_pass.Text;
                            user.Type = cbo_type.Text;
                            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                            MessageBox.Show("Update Successful");
                            LoadUserDataGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    if (userid != 0)
                    {
                        var user = context.Users.FirstOrDefault(u => u.Id == userid && u.Type != "Administrator");
                        if (user != null)
                        {
                            context.Users.Remove(user);
                            context.SaveChanges();
                            MessageBox.Show("Successfully Deleted A User");
                            LoadUserDataGrid();
                            foreach (Control obj in panel1.Controls)
                            {
                                if (obj is TextBox)
                                {
                                    obj.Text = "";

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot Delet A Admin");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            foreach (Control obj in panel1.Controls)
            {
                if (obj is TextBox)
                {
                    obj.Text = "";
                }
            }
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            userid = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_listUser.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtg_listUser.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtg_listUser.Rows[selectedrowindex];
                userid = Convert.ToInt32(selectedRow.Cells[0].Value);
                txt_name.Text = selectedRow.Cells[1].Value.ToString();
                txt_username.Text = selectedRow.Cells[2].Value.ToString();
                txt_pass.Text = selectedRow.Cells[3].Value.ToString();
                cbo_type.Text = selectedRow.Cells[4].Value.ToString();
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
        }
    }
}