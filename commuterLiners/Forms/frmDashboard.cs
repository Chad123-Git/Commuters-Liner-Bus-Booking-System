using commuterLiners.AppCode;
using commutersLinersDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commuterLiners.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnBook_MouseClick(object sender, MouseEventArgs e)
        {
            frmAvailability frmAvailability = new frmAvailability();
            frmAvailability.Show();
            this.Hide();
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

        private void btnReport_MouseClick(object sender, MouseEventArgs e)
        {
            string username = frmLogin.Username;
            string password = frmLogin.Password;

            DataTable dtUser = DBHelper.ValidateUser(username, password);
            Common.AppAccess = Convert.ToBoolean(dtUser.Rows[0]["AppAccess"]);

            if (Common.AppAccess == false)
            {

                MessageBox.Show("You don't have access.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmReport frmReport = new frmReport();
                frmReport.Show();
                this.Hide();
            }
        }

        private void btnFares_Click(object sender, EventArgs e)
        {
            frmFare frmFare = new frmFare();
            frmFare.Show();
            this.Close();
        }
    }
}
