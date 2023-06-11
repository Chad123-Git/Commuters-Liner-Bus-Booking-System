using commuterLiners.AppCode;
using commutersLinersDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace commuterLiners.Forms
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dataGridView = dgvReport; 

            Bitmap bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));

            e.Graphics.DrawImage(bitmap, new Point(100, 100)); 
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            DataTable dtReport = DBHelper.SelectByDate(dtpSearch.Value.ToString("yyyy-MM-dd"));
            if (dtReport != null && dtReport.Rows.Count > 0)
            {
                dgvReport.RowHeadersVisible = false;
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReport.DataSource = dtReport;
            }
            else 
            {
                MessageBox.Show("Date is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 1000, 1000);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.Size = new Size(200, 400);
            printPreviewDialog.StartPosition = FormStartPosition.CenterScreen;

            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap.Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Close();
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.isDragging = true;
                Common.lastCursorPos = e.Location;
            }
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Common.isDragging)
            {
                int deltaX = e.Location.X - Common.lastCursorPos.X;
                int deltaY = e.Location.Y - Common.lastCursorPos.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.isDragging = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
