using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Nav */
using System.Runtime.InteropServices;
/* use to parse JSON */
using Newtonsoft.Json.Linq;
/* Add child form */
using DesktopApp.ChildForm;
using DesktopApp.Auth;
/*  */
using System.Net;
using System.Net.Http;


namespace DesktopApp
{
    public partial class Form1 : Form
    {
        /**/
        private static string _projectId, _user, _role;
        private JObject userJson;
        private static readonly HttpClient client = new HttpClient();

        /**/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form1(string projectID, string username, string role, JObject userJson)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            /**/
            _projectId = projectID;
            _user = username;
            _role = role;
            lblUserName.Text = username;
            lblRole.Text = "_"+role;
            this.userJson = userJson;
            /* Align Username and Role Label*/
            var centerPointX = pictureBox1.Width / 2 + pictureBox1.Left;
            Point pointUser = new Point(centerPointX - lblUserName.Width / 2, lblUserName.Location.Y);
            lblUserName.Location = pointUser;
            Point pointRole = new Point(centerPointX - lblRole.Width / 2, lblRole.Location.Y);
            lblRole.Location = pointRole;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            /* Nav */
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            /* Open Child Form */
            lblTabName.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard FrmDashboard_Vrb = new Dashboard(_projectId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnDataTable_Click(object sender, EventArgs e)
        {
            /* Nav */
            pnlNav.Height = btnDataTable.Height;
            pnlNav.Top = btnDataTable.Top;
            pnlNav.Left = btnDataTable.Left;
            btnDataTable.BackColor = Color.FromArgb(46, 51, 73);

            /* Open Child Form */
            lblTabName.Text = "Data Table";
            this.pnlFormLoader.Controls.Clear();
            DataTables FrmDataTables_Vrb = new DataTables(_projectId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDataTables_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDataTables_Vrb);
            FrmDataTables_Vrb.Show();
        }

        private async void btnSetting_Click(object sender, EventArgs e)
        {
            /* Nav */
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            pnlNav.Left = btnSetting.Left;
            btnSetting.BackColor = Color.FromArgb(46, 51, 73);

            /* Open Child Form */
            lblTabName.Text = "Setting";
            this.pnlFormLoader.Controls.Clear();
            try
            {
                var values = new Dictionary<string, string>
                {
                    {"phone", userJson["phone"].ToString()}
                };
                var content = new FormUrlEncodedContent(values);
                var res = await client.PostAsync("http://localhost:8000/user/show-user-info", content);
                string resString = await res.Content.ReadAsStringAsync();
                userJson = JObject.Parse(resString);
                Setting FrmSetting_Vrb = new Setting(userJson) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FrmSetting_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(FrmSetting_Vrb);
                FrmSetting_Vrb.Show();
            }
            catch
            {
                MessageBox.Show("Cannot load data from Server", "Loading Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlarms_Click(object sender, EventArgs e)
        {
            /* Nav */
            pnlNav.Height = btnAlarm.Height;
            pnlNav.Top = btnAlarm.Top;
            pnlNav.Left = btnAlarm.Left;
            btnAlarm.BackColor = Color.FromArgb(46, 51, 73);

            /**/
            lblTabName.Text = "Alarms";
            this.pnlFormLoader.Controls.Clear();
            Alarms FrmAlarms_Vrb = new Alarms(_projectId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAlarms_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmAlarms_Vrb);
            FrmAlarms_Vrb.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            /* Nav */
            pnlNav.Height = btnReport.Height;
            pnlNav.Top = btnReport.Top;
            pnlNav.Left = btnReport.Left;
            btnReport.BackColor = Color.FromArgb(46, 51, 73);

            /**/
            lblTabName.Text = "Report";
            this.pnlFormLoader.Controls.Clear();
            Report FrmReport_Vrb = new Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmReport_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmReport_Vrb);
            FrmReport_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAlarms_Leave(object sender, EventArgs e)
        {
            btnAlarm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                btnLogin loginForm = new btnLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnDataTable_Leave(object sender, EventArgs e)
        {
            btnDataTable.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
