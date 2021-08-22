using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* use to parse JSON */
using Newtonsoft.Json.Linq;

namespace DesktopApp.Auth
{
    public partial class ProjectForm : Form
    {
        private int xCoordinate = 25;
        private int yCoordinate = 130;
        private static string projectID, username, role;
        private JObject userJson;
        public ProjectForm(string tokenAuth, JObject resJson)
        {
            InitializeComponent();
            /* convert JToken -> JArray */
            var projIDArr = JArray.FromObject(resJson["devices"]);
            username = (string)resJson["username"];
            role = (string)resJson["role"];
            userJson = resJson;
            int index = 1;
            foreach (JObject item in projIDArr)
            {
                createAProItem(index.ToString(), xCoordinate, yCoordinate);
                index++;
                xCoordinate += 60;
                createAProItem(item.GetValue("nameProject").ToString(), xCoordinate, yCoordinate);
                xCoordinate += 240;
                createAProItem(item.GetValue("addressProject").ToString(), xCoordinate, yCoordinate);
                projectID = item.GetValue("addressProject").ToString();
                xCoordinate += 240;
                createAProItem(checkState((bool)item.GetValue("activeProject")), xCoordinate, yCoordinate);
                createABtn((bool)item.GetValue("activeProject"), xCoordinate + 90, yCoordinate - 7);
                /* Reset Coordinate */
                xCoordinate = 30;
                yCoordinate += 40;
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }
        private void createAProItem(string text, int x, int y)
        {
            Label lblProject = new Label()
            {
                ForeColor = Color.White,
                BackColor = Color.FromArgb(46, 51, 73),
                Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold),
                Location = new Point(x, y),
                Text = text,
                AutoSize = true
            };
            this.Controls.Add(lblProject);
        }
        private void createABtn(bool state, int x, int y)
        {
            Button btnProject = new Button()
            {
                ForeColor = Color.FromArgb(46, 51, 73),
                BackColor = Color.FromArgb(0, 126, 249),
                Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(x, y),
                Text = state ? "Monitoring" : "Back",
                FlatStyle = FlatStyle.Flat,
                Name = "btnProject1",
                /* Set this property to check btn in event click */
                AccessibleName = "btnProject1"
            };
            btnProject.Click += new EventHandler(btnProject_Click);
            this.Controls.Add(btnProject);
        }
        private void btnProject_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string accessNameBtn = btn.AccessibleName;
            /* code for 1 project - not scale up for many projects */
            /* Check active or not --- not done */
            if(accessNameBtn == "btnProject1")
            {
                Form1 form1 = new Form1(projectID, username, role, userJson);
                form1.Show();
                this.Close();
            }
        }
        private string checkState(bool state)
        {
            return state ? "Active" : "Unactive";
        }
    }
}
