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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesGrpBox_Enter(object sender, EventArgs e)
        {

        }

        void CatDataGridLoader()
        {
            using(AppContext context = new AppContext())
            {
                dataGridView1.DataSource = context.CUSettings.Where(u => u.Type == "Category").ToList();
                dataGridView1.Columns[0].Visible = false;
            }
        }
        void UnitDataGridLoader()
        {
            using (AppContext context = new AppContext())
            {
                dataGridView2.DataSource = context.CUSettings.Where(u => u.Type == "Unit").ToList();
                dataGridView2.Columns[0].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(AppContext context = new AppContext())
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    var newCatregory = new Model.CUSettings()
                    {
                        Name = textBox1.Text,
                        Type = "Category"
                    };
                    context.CUSettings.Add(newCatregory);
                    context.SaveChanges();
                    CatDataGridLoader();
                }
                else
                {
                    MessageBox.Show("Cannot Save Empty Field", "Please type Something to Save");
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            CatDataGridLoader();
            UnitDataGridLoader();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (AppContext context = new AppContext())
            {
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    var newUnit = new Model.CUSettings()
                    {
                        Name = textBox2.Text,
                        Type = "Unit"
                    };
                    context.CUSettings.Add(newUnit);
                    context.SaveChanges();
                    UnitDataGridLoader();
                }
                else
                {
                    MessageBox.Show("Cannot Save Empty Field", "Please type Something to Save");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataRow = dataGridView1.Rows[e.RowIndex].Cells[1];
            MessageBox.Show(dataRow.ToString());
        }
    }
}
