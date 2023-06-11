using commuterLiners.AppCode;
using commutersLinersDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace commuterLiners.Forms
{
    public partial class frmBooking : Form
    {
        public static string personCountRegular { get; private set; }
        public static string personCountDiscount { get; private set; }
        public static double labelRegular { get; private set; }
        public static double labelDiscount { get; private set; }
        public static double total { get; private set; }

        public frmBooking()
        {
            InitializeComponent();
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            switch (lblTo.Text)
            {
                case "Subic":
                    lblRegular.Text = "x 50.00 PHP";
                    break;
                case "Castillejos":
                    lblRegular.Text = "x 60.00 PHP";
                    break;
                case "San Antonio":
                    lblRegular.Text = "x 70.00 PHP";
                    break;
                case "San Marcelino":
                    lblRegular.Text = "x 80.00 PHP";
                    break;
                case "San Narciso":
                    lblRegular.Text = "x 90.00 PHP";
                    break;
                case "San Felipe":
                    lblRegular.Text = "x 100.00 PHP";
                    break;
                case "Cabangan":
                    lblRegular.Text = "x 110.00 PHP";
                    break;
                case "Botolan":
                    lblRegular.Text = "x 120.00 PHP";
                    break;
                case "Iba":
                    lblRegular.Text = "x 130.00 PHP";
                    break;
                case "Palauig":
                    lblRegular.Text = "x 140.00 PHP";
                    break;
                case "Masinloc":
                    lblRegular.Text = "x 150.00 PHP";
                    break;
                case "Candelaria":
                    lblRegular.Text = "x 160.00 PHP";
                    break;
                case "Santa Cruz":
                    lblRegular.Text = "x 170.00 PHP";
                    break;
            }

            switch (lblTo.Text)
            {
                case "Subic":
                    lblDiscount.Text = "x 40.00 PHP";
                    break;
                case "Castillejos":
                    lblDiscount.Text = "x 48.00 PHP";
                    break;
                case "San Antonio":
                    lblDiscount.Text = "x 56.00 PHP";
                    break;
                case "San Marcelino":
                    lblDiscount.Text = "x 64.00 PHP";
                    break;
                case "San Narciso":
                    lblDiscount.Text = "x 72.00 PHP";
                    break;
                case "San Felipe":
                    lblDiscount.Text = "x 80.00 PHP";
                    break;
                case "Cabangan":
                    lblDiscount.Text = "x 88.00 PHP";
                    break;
                case "Botolan":
                    lblDiscount.Text = "x 96.00 PHP";
                    break;
                case "Iba":
                    lblDiscount.Text = "x 104.00 PHP";
                    break;
                case "Palauig":
                    lblDiscount.Text = "x 112.00 PHP";
                    break;
                case "Masinloc":
                    lblDiscount.Text = "x 120.00 PHP";
                    break;
                case "Candelaria":
                    lblDiscount.Text = "x 128.00 PHP";
                    break;
                case "Santa Cruz":
                    lblDiscount.Text = "x 136.00 PHP";
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxRegular.Text) && string.IsNullOrWhiteSpace(txtBoxDiscount.Text))
            {
                MessageBox.Show("Please enter a value.");
            }
            else if (txtBoxRegular.Text.StartsWith("0") || txtBoxDiscount.Text.StartsWith("0"))
            {
                MessageBox.Show("Value cannot be 0.");
                txtBoxRegular.Clear();
                txtBoxDiscount.Clear();
            }
            else if (!int.TryParse(txtBoxRegular.Text, out int regular) && !string.IsNullOrEmpty(txtBoxRegular.Text) || !double.TryParse(txtBoxDiscount.Text, out double discount) && !string.IsNullOrEmpty(txtBoxDiscount.Text))
            {
                MessageBox.Show("Please enter a valid numeric value.");
                txtBoxRegular.Clear();
                txtBoxDiscount.Clear();
            }
            else if (txtBoxDiscount.Text != "1" && txtBoxRegular.Text != "1")
            {
                MessageBox.Show("Only the number 1 is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxRegular.Clear();
                txtBoxDiscount.Clear();
            }
            else
            {
                frmSeatsSelection frmSeatsSelection = new frmSeatsSelection();
                frmSeatsSelection.Show();
                this.Hide();

                double multiplierRegular = 0;

                switch (lblTo.Text)
                {
                    case "Subic":
                        multiplierRegular = 50.00;
                        break;
                    case "Castillejos":
                        multiplierRegular = 60.00;
                        break;
                    case "San Antonio":
                        multiplierRegular = 70.00;
                        break;
                    case "San Marcelino":
                        multiplierRegular = 80.00;
                        break;
                    case "San Narciso":
                        multiplierRegular = 90.00;
                        break;
                    case "San Felipe":
                        multiplierRegular = 100.00;
                        break;
                    case "Cabangan":
                        multiplierRegular = 110.00;
                        break;
                    case "Botolan":
                        multiplierRegular = 120.00;
                        break;
                    case "Iba":
                        multiplierRegular = 130.00;
                        break;
                    case "Palauig":
                        multiplierRegular = 140.00;
                        break;
                    case "Masinloc":
                        multiplierRegular = 150.00;
                        break;
                    case "Candelaria":
                        multiplierRegular = 160.00;
                        break;
                    case "Santa Cruz":
                        multiplierRegular = 170.00;
                        break;
                }

                int regularValue;

                if (int.TryParse(txtBoxRegular.Text, out regularValue))
                {
                    labelRegular = multiplierRegular;
                    double userInputRegular = double.Parse(txtBoxRegular.Text);
                    double regularResult = double.Parse(txtBoxRegular.Text) * multiplierRegular;
                    total = regularResult;

                    DataTable dtBusDetails = DBHelper.InsertBusReceiptRegular(regularResult, userInputRegular);
                }

                double multiplierDiscount = 0;

                switch (lblTo.Text)
                {
                    case "Subic":
                        multiplierDiscount = 40.00;
                        break;
                    case "Castillejos":
                        multiplierDiscount = 48.00;
                        break;
                    case "San Antonio":
                        multiplierDiscount = 56.00;
                        break;
                    case "San Marcelino":
                        multiplierDiscount = 64.00;
                        break;
                    case "San Narciso":
                        multiplierDiscount = 72.00;
                        break;
                    case "San Felipe":
                        multiplierDiscount = 80.00;
                        break;
                    case "Cabangan":
                        multiplierDiscount = 88.00;
                        break;
                    case "Botolan":
                        multiplierDiscount = 96.00;
                        break;
                    case "Iba":
                        multiplierDiscount = 104.00;
                        break;
                    case "Palauig":
                        multiplierDiscount = 112.00;
                        break;
                    case "Masinloc":
                        multiplierDiscount = 120.00;
                        break;
                    case "Candelaria":
                        multiplierDiscount = 128.00;
                        break;
                    case "Santa Cruz":
                        multiplierDiscount = 136.00;
                        break;
                }

                int discountValue;


                if (int.TryParse(txtBoxDiscount.Text, out discountValue))
                {
                    labelDiscount = multiplierDiscount;
                    double userInputDiscount = double.Parse(txtBoxDiscount.Text);
                    double discountResult = double.Parse(txtBoxDiscount.Text) * multiplierDiscount;
                    total = discountResult;

                    DataTable dtBusDetails = DBHelper.InsertBusReceiptDiscount(discountResult, userInputDiscount);
                }
            }

            personCountRegular = txtBoxRegular.Text;
            personCountDiscount = txtBoxDiscount.Text;

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
