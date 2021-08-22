using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**/
using Newtonsoft.Json.Linq;
/**/
using System.Net.Http;

namespace DesktopApp.ChildForm
{
    public partial class Setting : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Setting(JObject userJson)
        {
            InitializeComponent();
            lblUserId.Text = userJson["_id"].ToString();
            lblUsername.Text = userJson["username"].ToString();
            lblPhone.Text = userJson["phone"].ToString();
            lblEmail.Text = userJson["email"].ToString();
            lblRole.Text = userJson["role"].ToString();
        }
    }
}
