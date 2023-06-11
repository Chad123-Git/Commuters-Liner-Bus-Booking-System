using commuterLiners.AppCode;
using commuterLiners.Forms;
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


namespace commuterLiners
{
    public partial class frmLogin : Form
    {
        public static string Username { get; private set; }
        public static string Password { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Please input username.", Common.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Please input password.", Common.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Select();
                return;
            }
            DataTable dtUser = DBHelper.ValidateUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (dtUser.Rows.Count > 0)
            {
                if (txtPassword.Text.Trim() == Convert.ToString(dtUser.Rows[0]["Password"]))
                {
                    Username = txtUsername.Text.Trim();
                    Password = txtPassword.Text.Trim();

                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password.", Common.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Select();
                }
            }
            else
            {
                MessageBox.Show("There is no username.", Common.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Select();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

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
