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

namespace DesktopApp.ChildForm
{
    public partial class Alarms : Form
    {
        MongoClientSettings mongoSettings = new MongoClientSettings();
        MongoClient client = new MongoClient();

        private string _projectId;
        /* Pagination */
        int maxPageDA;
        int maxPageAA;
        int currentPageDA;
        int currentPageAA;
        int itemperpage = 8;
        /**/
        List<DigitalAlert> digitalAlertData;
        List<AnalogAlert> analogAlertData;
        public Alarms(string projectId)
        {
            InitializeComponent();

            /**/
            _projectId = projectId;

            #region Inital Data Grid
            /* Inital Data Grid */
            dGVDigitalAlarms.BorderStyle = BorderStyle.None;
            dGVDigitalAlarms.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dGVDigitalAlarms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGVDigitalAlarms.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dGVDigitalAlarms.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dGVDigitalAlarms.BackgroundColor = Color.White;

            dGVDigitalAlarms.EnableHeadersVisualStyles = false;
            dGVDigitalAlarms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGVDigitalAlarms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dGVDigitalAlarms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dGVAnalogAlarms.BorderStyle = BorderStyle.None;
            dGVAnalogAlarms.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dGVAnalogAlarms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGVAnalogAlarms.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dGVAnalogAlarms.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dGVAnalogAlarms.BackgroundColor = Color.White;

            dGVAnalogAlarms.EnableHeadersVisualStyles = false;
            dGVAnalogAlarms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGVAnalogAlarms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dGVAnalogAlarms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion


            /**/
            mongoSettings.Server = new MongoServerAddress("localhost", 27017);
            /* Show Data */
            digitalAlertData = getDigitalAlert("dalerts");
            analogAlertData = getAnalogAlert("aalerts");
            List<DigitalAlert> subDigitalAlertData = new List<DigitalAlert>();
            List<AnalogAlert> subAnalogAlertData = new List<AnalogAlert>();
            try
            {
                subDigitalAlertData = digitalAlertData.GetRange(0, itemperpage);
                subAnalogAlertData = analogAlertData.GetRange(0, itemperpage);
                /* Disable pagination */
                btnPreviousDA.Enabled = false;
                btnPreviousAA.Enabled = false;
            }
            catch
            {
                subDigitalAlertData = digitalAlertData.GetRange(0, digitalAlertData.Count);
                subAnalogAlertData = analogAlertData.GetRange(0, analogAlertData.Count);
                /* Disable pagination */
                btnPreviousDA.Enabled = true;
                btnPreviousAA.Enabled = true;
            }
            currentPageAA = 1;
            currentPageDA = 1;
            showDigitalAlarmData(ref subDigitalAlertData, 0);
            showAnalogAlarmData(ref subAnalogAlertData, 0);
            /* max page */
            maxPageDA = getMaxPage(digitalAlertData.Count, itemperpage);
            maxPageAA = getMaxPage(analogAlertData.Count, itemperpage);
        }

        private void showDigitalAlarmData(ref List<DigitalAlert> dataIn, int ord)
        {
            foreach (var item in dataIn)
            {
                int i = 0;
                int row = dGVDigitalAlarms.Rows.Add();
                dGVDigitalAlarms.Rows[row].Cells[i++].Value = ++ord;
                dGVDigitalAlarms.Rows[row].Cells[i++].Value = item.tagname;
                dGVDigitalAlarms.Rows[row].Cells[i++].Value = convertDigitalState(item.value);
                dGVDigitalAlarms.Rows[row].Cells[i++].Value = item.timestamps.ToLocalTime();
            }
        }

        private void showAnalogAlarmData(ref List<AnalogAlert> dataIn, int ord)
        {
            foreach (var item in dataIn)
            {
                int i = 0;
                int row = dGVAnalogAlarms.Rows.Add();
                dGVAnalogAlarms.Rows[row].Cells[i++].Value = ++ord;
                dGVAnalogAlarms.Rows[row].Cells[i++].Value = item.tagname;
                dGVAnalogAlarms.Rows[row].Cells[i++].Value = item.value.ToString();
                dGVAnalogAlarms.Rows[row].Cells[i++].Value = item.state;
                dGVAnalogAlarms.Rows[row].Cells[i++].Value = item.timestamps.ToLocalTime();
            }
        }
        private List<DigitalAlert> getDigitalAlert(string collectionName)
        {
            var collection = client.GetDatabase("project").GetCollection<DigitalAlert>(collectionName);
            return collection.AsQueryable<DigitalAlert>().ToList();
        }
        private List<AnalogAlert> getAnalogAlert(string collectionName)
        {
            var collection = client.GetDatabase("project").GetCollection<AnalogAlert>(collectionName);
            return collection.AsQueryable<AnalogAlert>().ToList();
        }
        private string convertDigitalState(string stateIn)
        {
            return stateIn == "1" ? "ON" : "OFF";
        }

        private void btnPreviousDA_Click(object sender, EventArgs e)
        {
            currentPageDA--;
            /* Check Limit */
            if (currentPageDA == 1) btnPreviousDA.Enabled = false;
            btnNextDA.Enabled = true;

            /* Clear DataGrid */
            dGVDigitalAlarms.Rows.Clear();

            /* Show Data */
            try
            {
                List<DigitalAlert> subData = digitalAlertData.GetRange((currentPageDA - 1) * itemperpage, itemperpage);
                showDigitalAlarmData(ref subData, (currentPageDA - 1) * itemperpage);
            }
            catch
            {
                int count = digitalAlertData.Count - (currentPageDA - 1) * itemperpage;
                List<DigitalAlert> subData = digitalAlertData.GetRange((currentPageDA - 1) * itemperpage, count);
                showDigitalAlarmData(ref subData, (currentPageDA - 1) * itemperpage);
            }
        }

        private void btnNextDA_Click(object sender, EventArgs e)
        {
            currentPageDA++;
            /* Check Limit */
            if (currentPageDA == maxPageDA) btnNextDA.Enabled = false;
            btnPreviousDA.Enabled = true;

            /* Clear DataGrid */
            dGVDigitalAlarms.Rows.Clear();

            /* Show Data */
            try
            {
                List<DigitalAlert> subData = digitalAlertData.GetRange((currentPageDA - 1) * itemperpage, itemperpage);
                showDigitalAlarmData(ref subData, (currentPageDA - 1) * itemperpage);
            }
            catch
            {
                int count = digitalAlertData.Count - (currentPageDA - 1) * itemperpage;
                List<DigitalAlert> subData = digitalAlertData.GetRange((currentPageDA - 1) * itemperpage, count);
                showDigitalAlarmData(ref subData, (currentPageDA - 1) * itemperpage);
            }
        }

        private void btnPreviousAA_Click(object sender, EventArgs e)
        {
            currentPageAA--;
            /* Check Limit */
            if (currentPageAA == 1) btnPreviousAA.Enabled = false;
            else btnNextAA.Enabled = true;

            /* Clear DataGrid */
            dGVAnalogAlarms.Rows.Clear();

            /* Show Data */
            try
            {
                List<AnalogAlert> subData = analogAlertData.GetRange((currentPageAA - 1) * itemperpage, itemperpage);
                showAnalogAlarmData(ref subData, (currentPageAA - 1) * itemperpage);
            }
            catch
            {
                int count = analogAlertData.Count - (currentPageAA - 1) * itemperpage;
                List<AnalogAlert> subData = analogAlertData.GetRange((currentPageAA - 1) * itemperpage, count);
                showAnalogAlarmData(ref subData, (currentPageAA - 1) * itemperpage);
            }
        }

        private void btnNextAA_Click(object sender, EventArgs e)
        {
            currentPageAA++;
            /* Check Limit */
            if (currentPageAA == maxPageAA) btnNextAA.Enabled = false;
            else btnPreviousAA.Enabled = true;

            /* Clear DataGrid */
            dGVAnalogAlarms.Rows.Clear();

            /* Show Data */
            try
            {
                List<AnalogAlert> subData = analogAlertData.GetRange((currentPageAA - 1) * itemperpage, itemperpage);
                showAnalogAlarmData(ref subData, (currentPageAA - 1) * itemperpage);
            }
            catch
            {
                int count = analogAlertData.Count - (currentPageAA - 1) * itemperpage;
                List<AnalogAlert> subData = analogAlertData.GetRange((currentPageAA - 1) * itemperpage, count);
                showAnalogAlarmData(ref subData, (currentPageAA - 1) * itemperpage);
            }
        }
        private int getMaxPage(int item, int itemForPage)
        {
            int max = item / itemForPage;
            if ((item % itemForPage) != 0) max++;
            return max;
        }

        private void cbxDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DigitalAlert> digitalAlertNew = getDigitalAlert("dalerts");
            List<DigitalAlert> digitalAlertFilterData = new List<DigitalAlert>();
            if (cbxDD.SelectedItem.ToString() == "All")
            {
                digitalAlertData = digitalAlertNew;
            }
            else
            {
                foreach (var item in digitalAlertNew)
                {
                    if (item.tagname == cbxDD.SelectedItem.ToString())
                    {
                        digitalAlertFilterData.Add(item);
                    }
                }
                digitalAlertData = digitalAlertFilterData;
            }
                maxPageDA = getMaxPage(digitalAlertData.Count, itemperpage);
                currentPageDA = 1;
                try
                {
                    btnNextDA.Enabled = true;
                    btnPreviousDA.Enabled = false;
                    digitalAlertFilterData = digitalAlertData.GetRange(0, itemperpage);
                }
                catch
                {
                    btnNextDA.Enabled = false;
                    btnPreviousDA.Enabled = false;
                    digitalAlertFilterData = digitalAlertData.GetRange(0, digitalAlertData.Count);
                }
                /* Clear DataGrid */
                dGVDigitalAlarms.Rows.Clear();

                showDigitalAlarmData(ref digitalAlertFilterData, 0);
        }

        private void cbxAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<AnalogAlert> analogAlertNew = getAnalogAlert("aalerts");
            List<AnalogAlert> analogAlertFilterData = new List<AnalogAlert>();
            if (cbxAA.SelectedItem.ToString() == "All")
            {
                analogAlertData = analogAlertNew;
            }
            else
            {
                foreach (var item in analogAlertNew)
                {
                    if (item.tagname == cbxAA.SelectedItem.ToString())
                    {
                        analogAlertFilterData.Add(item);
                    }
                }
                analogAlertData = analogAlertFilterData;
            }
            maxPageAA = getMaxPage(analogAlertData.Count, itemperpage);
            currentPageAA = 1;
            try
            {
                btnNextAA.Enabled = true;
                btnPreviousAA.Enabled = false;
                analogAlertFilterData = analogAlertData.GetRange(0, itemperpage);
            }
            catch
            {
                btnNextAA.Enabled = false;
                btnPreviousAA.Enabled = false;
                analogAlertFilterData = analogAlertData.GetRange(0, analogAlertData.Count);
            }
            /* Clear DataGrid */
            dGVAnalogAlarms.Rows.Clear();

            showAnalogAlarmData(ref analogAlertFilterData, 0);
        }
    }

    public class DigitalAlert
    {
        public ObjectId id { get; set; }
        public string device_id { get; set; }
        public string tagname { get; set; }
        public string value { get; set; }
        public BsonDateTime timestamps { get; set; }
        public BsonDateTime createdAt { get; set; }
        public BsonDateTime updatedAt { get; set; }
        public int __v { get; set; }
    }
    public class AnalogAlert
    {
        public ObjectId id { get; set; }
        public string device_id { get; set; }
        public string tagname { get; set; }
        public double value { get; set; }
        public string state { get; set; }
        public BsonDateTime timestamps { get; set; }
        public BsonDateTime createdAt { get; set; }
        public BsonDateTime updatedAt { get; set; }
        public int __v { get; set; }
    }
}
