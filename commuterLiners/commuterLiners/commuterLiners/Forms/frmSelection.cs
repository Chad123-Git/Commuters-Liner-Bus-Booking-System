using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using commuterLiners.AppCode;
using commutersLinersDAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace commuterLiners.Forms
{

    public partial class frmSelection : Form
    {
        public static string busNumber { get; private set; }
        public static string travelDate { get; private set; }
        public static string destination { get; private set; }
        public static int availableSeats { get; private set; }
        public static string ticketNumber { get; private set; }
        public frmSelection()
        {
            InitializeComponent();
        }
        private string _travelDate;
        private string _arrivalPlace;

        public string TravelDate
        {
            get { return _travelDate; }
            set { _travelDate = value; }
        }

        public string ArrivalPlace
        {
            get { return _arrivalPlace; }
            set { _arrivalPlace = value; }
        }

        
        private void frmSelection_Load(object sender, EventArgs e)
        {
            string busNumber = DBHelper.GetLastCellValue();
            DataTable selectedStatus = DBHelper.GetSelectedStatus(busNumber);

            int countZeros = 0;

            foreach (DataRow row in selectedStatus.Rows)
            {
                for (int i = 1; i <= 55; i++)
                {
                    if (row["s" + i.ToString()].ToString() == "0")
                    {
                        countZeros++;
                    }
                }
            }
            DBHelper.UpdateAvailableSeats(busNumber, countZeros);

            DataTable dtBusDetails = DBHelper.InsertBusDetails(TravelDate,ArrivalPlace);
            if (dtBusDetails != null && dtBusDetails.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtBusDetails;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ScrollBars = ScrollBars.None;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 234, 243);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.Refresh();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 68;
                }

                //Header
                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView1.ColumnHeadersHeight = 35;
                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 67, 79);
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(249, 249, 249);
            }
        }
        private bool isMouseOverDataGridView = false;

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!isMouseOverDataGridView)
            {
                if (e.RowIndex % 2 == 0)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(234, 234, 234);
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(251, 254, 250);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue >= 0 && e.NewValue <= dataGridView1.RowCount - dataGridView1.DisplayedRowCount(false))
            {
                this.vScrollBar1.LargeChange = this.vScrollBar1.Maximum / 2;
                dataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            isMouseOverDataGridView = true;

            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(217, 234, 243);

            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            isMouseOverDataGridView = false;

            if (e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(234, 234, 234);


                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(251, 254, 250);

                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.SelectionBackColor = Color.FromArgb(53, 67, 79);
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];
                string cellValue = clickedRow.Cells[0].Value.ToString();


                if (clickedRow.Cells.Count > 0 && clickedRow.Cells[0].Value != null)
                {

                    DataTable busDetails2 = DBHelper.GetBusDetails2(cellValue);
                    DataTable tcktNumber = DBHelper.GetTicketNumber(cellValue);
                    DataTable getBusNumber = DBHelper.InsertCellValue(cellValue);

                    if (busDetails2.Rows.Count > 0)
                    {
                        string busNumberValue = busDetails2.Rows[0]["Bus_Number"].ToString();
                        string travelDateValue = busDetails2.Rows[0]["Travel_Date"].ToString();
                        string arrivalPlaceValue = busDetails2.Rows[0]["To"].ToString();
                        string availableSeatsValue = busDetails2.Rows[0]["Available_Seats"].ToString();
                        ticketNumber = tcktNumber.Rows[0]["Ticket_Number"].ToString();

                        frmBooking frmBooking = new frmBooking();
                        frmBooking.busNumber.Text = busNumberValue;
                        frmBooking.travelDate.Text = travelDateValue;
                        frmBooking.lblTo.Text = arrivalPlaceValue;
                        frmBooking.availableSeats.Text = availableSeatsValue;
                        frmBooking.ticketNumber.Text = ticketNumber;

                        busNumber = busDetails2.Rows[0]["Bus_Number"].ToString();
                        travelDate = busDetails2.Rows[0]["Travel_Date"].ToString();
                        destination = busDetails2.Rows[0]["To"].ToString();
                        availableSeats = int.Parse(availableSeatsValue);


                        frmBooking.Show();
                        this.Hide();
                    }
                }
            }
        }

    }
}
