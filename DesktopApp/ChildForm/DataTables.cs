using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Connect MongoDB */
using MongoDB.Bson;
using MongoDB.Driver;
/* Json */
using Newtonsoft.Json.Linq;

namespace DesktopApp.ChildForm
{
    public partial class DataTables : Form
    {
        private static string _projectId;
        MongoClientSettings mongoSettings = new MongoClientSettings();
        MongoClient client = new MongoClient();
        /* Pagination */
        int maxPage;
        int currentPage;
        string currentPhase;
        int itemperpage = 20;
        public DataTables()
        {
            InitializeComponent();
            /* Nav */
            pnlNavTable.Width = btnSum.Width;
            pnlNavTable.Top = btnSum.Bottom;
            pnlNavTable.Left = btnSum.Left;
            /* Inital Data Grid */
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            /**/
            mongoSettings.Server = new MongoServerAddress("localhost", 27017);
            /**/
        }

        public DataTables(string projectId)
        {
            InitializeComponent();
            /* Nav */
            pnlNavTable.Width = btnSum.Width;
            pnlNavTable.Top = btnSum.Bottom;
            pnlNavTable.Left = btnSum.Left;
            /* Inital Data Grid */
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            /**/
            _projectId = projectId;
            mongoSettings.Server = new MongoServerAddress("localhost", 27017);
            /* Disable pagination */
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            /* Clear DataGrid */
            dataGridView1.Rows.Clear();
            /* Enable pagination */
            btnNext.Enabled = true;

            /* Nav */
            pnlNavTable.Width = btnSum.Width;
            pnlNavTable.Top = btnSum.Bottom;
            pnlNavTable.Left = btnSum.Left;

            /* Show Data */
            currentPhase = "cabinphasesummaries";
            var data = getCabinetData(currentPhase);
            currentPage = 1;
            maxPage = getMaxPage(data.Count, itemperpage);
            List<CabinPhase> subData = new List<CabinPhase>();
            try
            {
                subData = data.GetRange(0, itemperpage);
            }
            catch
            {
                subData = data.GetRange(0, data.Count);
            }
            showDataOnGrid(ref subData, 0);

            /* Show Page */
            lblShowPage.Text = "Page " + currentPage.ToString();
        }

        private void btnPhase1_Click(object sender, EventArgs e)
        {
            /* Clear DataGrid */
            dataGridView1.Rows.Clear();
            /* Enable pagination */
            btnNext.Enabled = true;

            /* Nav */
            pnlNavTable.Width = btnPhase1.Width;
            pnlNavTable.Top = btnPhase1.Bottom;
            pnlNavTable.Left = btnPhase1.Left;

            /* Show Data */
            currentPhase = "cabinphaseones";
            var data = getCabinetData(currentPhase);
            currentPage = 1;
            maxPage = getMaxPage(data.Count, itemperpage);
            List<CabinPhase> subData = data.GetRange(0, itemperpage);
            showDataOnGrid(ref subData, 0);

            /* Show Page */
            lblShowPage.Text = "Page " + currentPage.ToString();
        }

        private void btnPhase2_Click(object sender, EventArgs e)
        {
            /* Clear DataGrid */
            dataGridView1.Rows.Clear();
            /* Enable pagination */
            btnNext.Enabled = true;

            /* Nav */
            pnlNavTable.Width = btnPhase2.Width;
            pnlNavTable.Top = btnPhase2.Bottom;
            pnlNavTable.Left = btnPhase2.Left;

            /* Show Data */
            currentPhase = "cabinphasetwos";
            var data = getCabinetData(currentPhase);
            currentPage = 1;
            maxPage = getMaxPage(data.Count, itemperpage);
            List<CabinPhase> subData = data.GetRange(0, itemperpage);
            showDataOnGrid(ref subData, 0);

            /* Show Page */
            lblShowPage.Text = "Page " + currentPage.ToString();
        }

        private void btnPhase3_Click(object sender, EventArgs e)
        {
            /* Clear DataGrid */
            dataGridView1.Rows.Clear();
            /* Enable pagination */
            btnNext.Enabled = true;

            /* Nav */
            pnlNavTable.Width = btnPhase3.Width;
            pnlNavTable.Top = btnPhase3.Bottom;
            pnlNavTable.Left = btnPhase3.Left;

            /* Show Data */
            currentPhase = "cabinphasethrees";
            var data = getCabinetData(currentPhase);
            currentPage = 1;
            maxPage = getMaxPage(data.Count, itemperpage);
            List<CabinPhase> subData = data.GetRange(0, itemperpage);
            showDataOnGrid(ref subData, 0);

            /* Show Page */
            lblShowPage.Text = "Page " + currentPage.ToString();
        }

        /* chua check 2 project khac nhau */
        private List<CabinPhase> getCabinetData(string collectionName)
        {
            var collection = client.GetDatabase("project").GetCollection<CabinPhase>(collectionName);
            return collection.AsQueryable<CabinPhase>().ToList();
        }
        private void showDataOnGrid(ref List<CabinPhase> dataIn, int ord)
        {
            foreach (var item in dataIn)
            {
                int i = 0;
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[i++].Value = ++ord;
                dataGridView1.Rows[row].Cells[i++].Value = Convert.ToDouble(item.samples["VLN"]);
                dataGridView1.Rows[row].Cells[i++].Value = Convert.ToDouble(item.samples["VLL"]);
                dataGridView1.Rows[row].Cells[i++].Value = item.samples["I"];
                dataGridView1.Rows[row].Cells[i++].Value = item.samples["KW"];
                dataGridView1.Rows[row].Cells[i++].Value = item.samples["KVAR"];
                dataGridView1.Rows[row].Cells[i++].Value = item.samples["KVA"];
                dataGridView1.Rows[row].Cells[i++].Value = Convert.ToDouble(item.samples["PF"]);
                dataGridView1.Rows[row].Cells[i++].Value = item.samples["timeStamp"].ToLocalTime();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentPage--;
            /* Check Limit */
            if (currentPage == 1) btnPrevious.Enabled = false;
            else btnNext.Enabled = true;
            /* Show Page */
            lblShowPage.Text = "Page " + currentPage.ToString();
            /* Clear DataGrid */
            dataGridView1.Rows.Clear();

            /* Show Data */
            var data = getCabinetData(currentPhase);
            List<CabinPhase> subData = data.GetRange((currentPage - 1) * itemperpage, itemperpage);
            showDataOnGrid(ref subData, (currentPage - 1) * itemperpage);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            /* Check Limit */
            if (currentPage == maxPage) btnNext.Enabled = false;
            else btnPrevious.Enabled = true;
            /* Show Page */
            lblShowPage.Text = "Page " + currentPage.ToString();
            /* Clear DataGrid */
            dataGridView1.Rows.Clear();

            /* Show Data */
            var data = getCabinetData(currentPhase);
            try
            {
                List<CabinPhase> subData = data.GetRange((currentPage - 1) * itemperpage, itemperpage);
                showDataOnGrid(ref subData, (currentPage - 1) * itemperpage);
            }
            catch
            {
                int count = data.Count - (currentPage - 1) * itemperpage;
                List<CabinPhase> subData = data.GetRange((currentPage - 1) * itemperpage, count);
                showDataOnGrid(ref subData, (currentPage - 1) * itemperpage);
            }
        }

        private int getMaxPage(int item, int itemForPage)
        {
            int max = item / itemForPage;
            if ((item % itemForPage) != 0) max++;
            return max;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("C:\\Users\\Admin\\Desktop", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();

        }
    }

    public class Users
    {
        public ObjectId id { get; set; }
        public string role { get; set; }
        public bool isVerified { get; set; }
        public BsonDouble project_id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public BsonDateTime createdAt { get; set; }
        public BsonDateTime updatedAt { get; set; }
        public int __v { get; set; }
    }

    public class CabinPhase
    {
        public ObjectId id { get; set; }
        public string device_id { get; set; }
        public int nsample { get; set; }
        public BsonDocument samples { get; set; }
        public BsonDateTime createdAt { get; set; }
        public BsonDateTime updatedAt { get; set; }
        public int __v { get; set; }
    }
}
