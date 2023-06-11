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

namespace commuterLiners.Forms
{
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            string lastTransactionID = DBHelper.GetTransactionID();
            string busNumber = frmSelection.busNumber;
            string travelDate = frmSelection.travelDate;
            string destination = frmSelection.destination;
            string ticketNumber = frmSelection.ticketNumber;
            string personCountRegular = frmBooking.personCountRegular;
            string personCountDiscount = frmBooking.personCountDiscount;
            string departure = "Olongapo";
            double labelRegular = frmBooking.labelRegular;
            double labelDiscount = frmBooking.labelDiscount;
            double price = labelRegular + labelDiscount;
            double total = frmBooking.total;

            label4.Text = lastTransactionID;
            lblTicketNumber.Text = ticketNumber;
            lblBusNumber.Text = busNumber;
            lblTravelDate.Text = travelDate;
            lblDeparture.Text = departure;
            lblDestination.Text = destination;
            lblSeatNumber.Text = frmSeatsSelection.concatenatedValues;
            lblPersonCount.Text = !string.IsNullOrEmpty(personCountDiscount) ? personCountDiscount : personCountRegular;
            lblTotal.Text = total.ToString("F2") + " ₱";
            lblPrice2.Text = price.ToString("F2") + " ₱";

        }

        private void lblTicketNumber_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblBusNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblTravelDate_Click(object sender, EventArgs e)
        {

        }

        private void lblDeparture_Click(object sender, EventArgs e)
        {

        }

        private void lblDestination_Click(object sender, EventArgs e)
        {

        }

        private void lblSeatNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonCount_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 346, 323);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.WindowState = FormWindowState.Normal;
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
    }
}
