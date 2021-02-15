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
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Drawing.Imaging;

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
                    dtglist.DataSource = context.StockOrders.OrderByDescending(c => c.Id).Select(x => new
                    {
                        OrderNum = x.Id,
                        CustomerName = x.FirstName + " " + x.LastName,
                        ContactNumber = x.contactnumber,
                        Discounted = x.discount,
                        TotalCharges = x.price,
                        TotalPaid = x.payable,
                        Date = x.TransactionDate,
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
                        dtglist.DataSource = context.StockOrders.Where(u => u.FirstName.Contains(txtsearch.Text)|| u.LastName.Contains(txtsearch.Text)
                        || u.contactnumber.Contains(txtsearch.Text)).OrderByDescending(c => c.Id).Select(x => new
                        {
                            OrderNum = x.Id,
                            CustomerName = x.FirstName + " " + x.LastName,
                            ContactNumber = x.contactnumber,
                            Discounted = x.discount,
                            TotalCharges = x.price,
                            TotalPaid = x.payable,
                            Date = x.TransactionDate
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
                var uuid = context.StockOut.FirstOrDefault(u => u.StockOrderId == id);
                LocalReport report = new LocalReport();
                string exeFolder = Application.StartupPath;
                string reportPath = Path.Combine(exeFolder, @"DevForms\Reports\Invoice.rdlc");
                report.ReportPath = reportPath;
                report.ReportPath = reportPath;
                ReportDataSource i = new ReportDataSource("StockOut", context.StockOut.Include(u => u.StockItems).Include(o => o.StockOrder).Where(c => c.TransactionID == uuid.TransactionID).Select(x => new Model.ViewModel.InvoiceVM()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppContext context = new AppContext())
                {
                    dtglist.DataSource = context.StockOrders.OrderByDescending(t => t.TransactionDate).Where(t => DbFunctions.TruncateTime(t.TransactionDate) >= DbFunctions.TruncateTime(dptfrom.Value.Date) && DbFunctions.TruncateTime(t.TransactionDate) <= DbFunctions.TruncateTime(dtpto.Value.Date)).Select(x => new
                    {
                        OrderNum = x.Id,
                        CustomerName = x.FirstName + " " + x.LastName,
                        ContactNumber = x.contactnumber,
                        Discounted = x.discount,
                        TotalCharges = x.price,
                        TotalPaid = x.payable,
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtglist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtglist.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtglist.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtglist.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                DevForms.StockOutListItem solt = new StockOutListItem(id);
                solt.ShowDialog();
            }
        }
    }
}