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
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        int catUpdateID = 0;
        int unitUpdateID = 0;
        public Settings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    var findCat = context.Category.Find(catUpdateID);
                    if (findCat != null)
                    {
                        context.Category.Remove(findCat);
                        context.SaveChanges();
                        MessageBox.Show("Category Deleted Successfully");
                        CatDataGridLoader();
                        catUpdateID = 0;
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Could Not Find the Product to delete");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoriesGrpBox_Enter(object sender, EventArgs e)
        {

        }

        void CatDataGridLoader()
        {
            using (AppContext context = new AppContext())
            {
                dataGridView1.DataSource = context.Category.ToList();
                dataGridView1.Columns[0].Visible = false;
            }
        }
        void UnitDataGridLoader()
        {
            using (AppContext context = new AppContext())
            {
                dataGridView2.DataSource = context.Units.ToList();
                dataGridView2.Columns[0].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AppContext context = new AppContext())
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    var newCatregory = new Model.Category()
                    {
                        Name = textBox1.Text
                    };
                    context.Category.Add(newCatregory);
                    context.SaveChanges();
                    CatDataGridLoader();
                    textBox1.Clear();
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
                    var newUnit = new Model.Unit()
                    {
                        Name = textBox2.Text
                    };
                    context.Units.Add(newUnit);
                    context.SaveChanges();
                    UnitDataGridLoader();
                    catUpdateID = 0;
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Cannot Save Empty Field", "Please type Something to Save");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[1].Value);
                catUpdateID = Convert.ToInt32(selectedRow.Cells[0].Value);
                textBox1.Text = cellValue;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            catUpdateID = 0;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (catUpdateID != 0)
                {
                    using (AppContext context = new AppContext())
                    {
                        var cat = context.Category.FirstOrDefault(u => u.Id == catUpdateID);
                        if (cat != null)
                        {
                            cat.Name = textBox1.Text;
                            context.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                            MessageBox.Show("Update Success");
                            CatDataGridLoader();
                            catUpdateID = 0;
                            textBox1.Clear();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please select an item from Grid to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            unitUpdateID = 0;
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    var unit = context.Units.Find(unitUpdateID);
                    if (unit != null)
                    {
                        context.Units.Remove(unit);
                        context.SaveChanges();
                        MessageBox.Show("Unit Deleted Successfully");

                        UnitDataGridLoader();
                        unitUpdateID = 0;
                        textBox2.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    var unit = context.Units.FirstOrDefault(u => u.Id == unitUpdateID);
                    if (unit != null)
                    {
                        unit.Name = textBox2.Text;
                        context.Entry(unit).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show("Update Success");
                        UnitDataGridLoader();
                        unitUpdateID = 0;
                        textBox2.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[1].Value);
                unitUpdateID = Convert.ToInt32(selectedRow.Cells[0].Value);
                textBox2.Text = cellValue;
            }
        }
    }
}