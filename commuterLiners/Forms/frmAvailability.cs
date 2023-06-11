using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using commutersLinersDAL;
using commuterLiners.AppCode;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace commuterLiners.Forms
{
    public partial class frmAvailability : Form
    {
        public frmAvailability()
        {
            InitializeComponent();
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void frmAvailability_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(100);
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtValidation = DBHelper.ValidateBus(dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBoxTo.Text.Trim());

            if (dtValidation.Rows.Count > 0)
            {
                DBHelper.InsertTicketNumber();
                frmSelection frmSelection = new frmSelection();
                frmSelection.TravelDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                frmSelection.ArrivalPlace = comboBoxTo.SelectedItem.ToString();
                frmSelection.Show();
                this.Hide();
            }

            else if (comboBoxTo.SelectedItem == null)
            {
                MessageBox.Show("Please select a place of arrival", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Date and arrival place  is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
