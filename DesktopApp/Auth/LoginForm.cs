using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*  */
using System.Net;
using System.Net.Http;
/* use to parse JSON */
using Newtonsoft.Json.Linq;

namespace DesktopApp.Auth
{
    public partial class btnLogin : Form
    {
        private static readonly HttpClient client = new HttpClient();
        static string tokenAuth;

        public btnLogin()
        {
            InitializeComponent();
            lblErr.Visible = false;
        }

        private async void brnLogin_Click(object sender, EventArgs e)
        {
            #region Check Input
            string errStr = "";
            /* Check input phone */
            if(txtPhone.Text == String.Empty)
            {
                errStr += "Enter a valid phone" + "\n";
            }
            /* Check input password */
            if (txtPassword.Text == String.Empty)
            {
                errStr += "Enter a valid password" + "\n";
            }
            /* Show Error */
            if (errStr != String.Empty)
            {
                lblErr.Text = errStr;
                lblErr.Visible = true;
            }
            else
            {
                lblErr.Visible = false;
            }
            #endregion
            #region Check Login
            if (!(txtPhone.Text == String.Empty) && !(txtPassword.Text == String.Empty))
            {
                var values = new Dictionary<string, string>
                {
                    {"phone", txtPhone.Text},
                    { "password", txtPassword.Text}
                };

                var content = new FormUrlEncodedContent(values);

                try
                {
                    var res = await client.PostAsync("http://localhost:8000/site/login-winform", content);
                    string resString = await res.Content.ReadAsStringAsync();
                    JObject resJson = JObject.Parse(resString);
                    if ((bool)resJson["success"])
                    {
                        tokenAuth = (string)resJson["token"];
                        if ((tokenAuth != null) || (tokenAuth != String.Empty))
                        {
                            /* Create a new form */
                            ProjectForm showProject = new ProjectForm(tokenAuth, resJson);
                            showProject.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        lblErr.Text = (string)resJson["message"];
                        lblErr.Visible = true;
                    }
                }
                catch
                {
                    lblErr.Text = "Can not connect to Server.";
                    lblErr.Visible = true;
                }
            }
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
