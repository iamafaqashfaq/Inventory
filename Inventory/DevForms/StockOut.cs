using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Inventory.DevForms
{
    public partial class StockOut : DevExpress.XtraEditors.XtraForm
    {
        public StockOut()
        {
            InitializeComponent();
        }
        void LoadItemGrid()
        {
            using (AppContext context = new AppContext())
            {
                dataGridView1.DataSource = context.StockItems.Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Qty = x.Qty,
                    Price = x.Price,
                    Unit = x.Unit.Name,
                    Category = x.Category.Name,
                    categoryid = x.CategoryId,
                    unitid = x.UnitId,
                    EntryDate = x.TransactionDate
                }).ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
            }

        }
        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCus_clear_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (Control obj in Panel1.Controls)
            {
                if (obj is TextBox)
                {
                    if(textBox2 != obj)
                    {
                        obj.Text = "";
                    }
                }
            }
            txtsearch.Clear();
            textBox2.Text = "0.00";
            label12.Text = "0.00";
            label9.Text = "0.00";
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            LoadItemGrid();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    LoadItemGrid();
                }
                else
                {
                    using (AppContext context = new AppContext())
                    {
                        dataGridView1.DataSource = context.StockItems.Where(u => u.Name.Contains(txtsearch.Text) || u.Description.Contains(txtsearch.Text) || u.Category.Name.Contains(txtsearch.Text)).Select(x => new
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Description = x.Description,
                            Qty = x.Qty,
                            Price = x.Price,
                            Unit = x.Unit.Name,
                            Category = x.Category.Name,
                            categoryid = x.CategoryId,
                            unitid = x.UnitId,
                            EntryDate = x.TransactionDate
                        }).ToList();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                var total = Convert.ToDouble(selectedRow.Cells[4].Value) * 1;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var i = Convert.ToInt32(row.Cells[0].Value);
                    if (i == Convert.ToInt32(selectedRow.Cells[0].Value))
                    {
                        row.Cells[4].Value = Convert.ToInt32(row.Cells[4].Value) + 1;
                        row.Cells[5].Value = Convert.ToInt32(row.Cells[4].Value) * Convert.ToDouble(selectedRow.Cells[4].Value);
                        return;
                    }
                }
                dataGridView2.Rows.Add(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value, selectedRow.Cells[2].Value, selectedRow.Cells[4].Value, 1, total);
                double totalw = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {

                    totalw = double.Parse(row.Cells[5].Value.ToString()) + totalw;
                }
                label9.Text = totalw.ToString();
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double total;
                if (dataGridView2.CurrentCell.ColumnIndex == 4)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        total = double.Parse(row.Cells[4].Value.ToString()) * double.Parse(row.Cells[3].Value.ToString());
                        row.Cells[5].Value = total;
                    }
                    double totalw = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {

                        totalw = double.Parse(row.Cells[5].Value.ToString()) + totalw;
                    }
                    label9.Text = totalw.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCus_Remove_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            double totalw = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                totalw = double.Parse(row.Cells[5].Value.ToString()) + totalw;
            }
            label9.Text = totalw.ToString();
            label12.Text = Convert.ToString(double.Parse(label9.Text) - double.Parse(label10.Text));
        }

        private void btnCus_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count != 0)
                {
                    using (AppContext context = new AppContext())
                    {
                        bool add = true;
                        List<Model.StockOut> stockOutList = new List<Model.StockOut>();
                        string uuid = System.Guid.NewGuid().ToString();
                        Model.StockOrder stockOrder = new Model.StockOrder()
                        {
                            FirstName = txtCus_fname.Text == "" ? "Cash Sale" : txtCus_fname.Text,
                            LastName = txtCus_lname.Text == "" ? "" : txtCus_lname.Text,
                            contactnumber = textBox1.Text,
                            price = double.Parse(label9.Text),
                            discount = double.Parse(label10.Text),
                            payable = double.Parse(label12.Text),
                            TransactionDate = DateTime.Now,
                        };
                        context.StockOrders.Add(stockOrder);
                        context.SaveChanges();
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            int id = Convert.ToInt32(row.Cells[0].Value);
                            var stockItem = context.StockItems.FirstOrDefault(u => u.Id == id);
                            if (stockItem.Qty >= Convert.ToInt32(row.Cells[4].Value))
                            {
                                stockItem.Qty = stockItem.Qty - Convert.ToInt32(row.Cells[4].Value);
                                context.Entry(stockItem).State = System.Data.Entity.EntityState.Modified;
                                context.SaveChanges();
                                stockOutList.Add(new Model.StockOut()
                                {
                                    StockItemId = Convert.ToInt32(row.Cells[0].Value),
                                    FirstName = txtCus_fname.Text == "" ? "Cash Sale" : txtCus_fname.Text,
                                    LastName = txtCus_lname.Text == "" ? "" : txtCus_lname.Text,
                                    ContactNumber = textBox1.Text,
                                    Qty = Convert.ToInt32(row.Cells[4].Value),
                                    Price = Convert.ToDouble(row.Cells[3].Value),
                                    TotalPrice = Convert.ToDouble(row.Cells[5].Value),
                                    TransactionDate = DateTime.Now,
                                    TransactionID = uuid,
                                    StockOrderId = stockOrder.Id,
                                });
                            }
                            else
                            {
                                add = false;
                                MessageBox.Show("There are total " + stockItem.Qty.ToString() + " " + row.Cells[1].Value.ToString() + "\' in Stock");
                            }
                        }
                        if (add)
                        {
                            context.StockOut.AddRange(stockOutList);
                            context.SaveChanges();
                            MessageBox.Show("Added Successfully");
                            LoadItemGrid();
                            LocalReport report = new LocalReport();
                            string exeFolder = Application.StartupPath;
                            string reportPath = Path.Combine(exeFolder, @"DevForms\Reports\Invoice.rdlc");
                            report.ReportPath = reportPath;
                            ReportDataSource i = new ReportDataSource("StockOut", context.StockOut.Include(u => u.StockItems).Include(o => o.StockOrder).Where(c => c.TransactionID == uuid).Select(x => new Model.ViewModel.InvoiceVM()
                            {
                                name = x.FirstName + " " + x.LastName,
                                stockitem = x.StockItems.Name,
                                qty = x.Qty,
                                price = x.Price,
                                total = x.TotalPrice,
                                discount = x.StockOrder.discount
                            }).ToList());
                            report.DataSources.Add(i);
                            PrintToPrinter(report);
                            btnCus_clear_Click(sender, e);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnviewStockout_Click(object sender, EventArgs e)
        {
        }

        private void btnviewStockout_Click_1(object sender, EventArgs e)
        {
            StockOutList sol = new StockOutList();
            sol.Show();
        }

        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);

        }
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;
        public static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
             @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>3.5in</PageWidth>
                <PageHeight>8.3in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0.1in</MarginLeft>
                <MarginRight>0.1in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }


        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                total = double.Parse(row.Cells[5].Value.ToString()) + total;
            }
            label9.Text = total.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "0.00";
            }
            label10.Text = textBox2.Text;
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if(double.Parse(label9.Text) > double.Parse(label10.Text))
            {
                label12.Text = Convert.ToString(double.Parse(label9.Text) - double.Parse(label10.Text));
            }
        }

        private void label10_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(label9.Text) > double.Parse(label10.Text))
            {
                label12.Text = Convert.ToString(double.Parse(label9.Text) - double.Parse(label10.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Calc.exe";
            p.Start();
        }
    }
}