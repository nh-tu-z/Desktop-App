using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Chart */
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
/* MQTT */
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
/* use to parse JSON */
using Newtonsoft.Json.Linq;

namespace DesktopApp.ChildForm
{
    public partial class Dashboard : Form
    {
        /**/
        private static string idProject;
        /* chart variable */
        private static List<double> nonValue = new List<double>(5) { 1, 2, 3, 4, 1 };
        private static List<double> oneValue = new List<double>(5) { 1, 3, 4, 5, 1 };
        private static List<double> twoValue = new List<double>(5) { 1, 4, 5, 6, 1 };
        private static List<double> threeValue = new List<double>(5) { 1, 5, 6, 7, 1 };

        /**/
        private static MqttClient client;
        private static readonly string mqttURI = "tailor.cloudmqtt.com";
        private static readonly int mqttPort = 11045;
        private static readonly string username = "bobipxju";
        private static readonly string password = "-6rHRc15nFdG";
        private static readonly string clientId = Guid.NewGuid().ToString();
        private static string topicPublish = "CabinetDevice";
        /**/
        private string DALIdata;
        public Dashboard(string projectId)
        {
            InitializeComponent();

            /* Get ID Project */
            idProject = projectId;
            /*topicPublish = idProject + "/control";*/
            topicPublish = "CabinetDevice";
            #region Init Chart Line

            //I
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double>(nonValue),
                Title = "I",
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(155, 93, 229)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 3,
                PointGeometrySize = 10,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });
            //I1
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double>(oneValue),
                Title = "I1",
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(138, 201, 38)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 2,
                PointGeometrySize = 10,
                PointForeground =
                  new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            //I2
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double>(twoValue),
                Title = "I2",
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(215, 38, 61)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 2,
                PointGeometrySize = 10,
                PointForeground =
                  new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            //I3
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double>(threeValue),
                Title = "I3",
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(252, 255, 253)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 2,
                PointGeometrySize = 10,
                PointForeground =
                  new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });



            var ax = new Axis();

            cartesianChart1.AxisX.Add(new Axis
            {
                IsMerged = true,
                ShowLabels = false,
                Separator = new Separator
                {
                    Stroke = System.Windows.Media.Brushes.Transparent
                }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            #endregion
        }

        #region Sub MQTT
        Action<string, string> ReceiveAction;
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ReceiveAction = Receive;
            try
            {
                this.BeginInvoke(ReceiveAction, Encoding.UTF8.GetString(e.Message), e.Topic);
            }
            catch { };
        }
        void Receive(string resMessage, string topic)
        {
            SeriesCollection series = new SeriesCollection();

            if (topic == "CabinetDevice01")
            {
                JObject data;
                try
                {
                    data = JObject.Parse(resMessage);
                    if (data.ContainsKey("V1N"))
                    {
                        /**/
                        V1N.Text = data["V1N"].ToString();
                        V2N.Text = data["V2N"].ToString();
                        V3N.Text = data["V3N"].ToString();
                        VLN.Text = data["AV_LN"].ToString();

                        /**/
                        KW0.Text = data["Total_KW"].ToString();
                        KW1.Text = data["KW1"].ToString();
                        KW2.Text = data["KW2"].ToString();
                        KW3.Text = data["KW3"].ToString();

                        /**/
                        KVA0.Text = data["Total_KVA"].ToString();
                        KVA1.Text = data["KVA1"].ToString();
                        KVA2.Text = data["KVA2"].ToString();
                        KVA3.Text = data["KVA3"].ToString();

                        /**/
                        KVAR0.Text = data["Total_KVAR"].ToString();
                        KVAR1.Text = data["KVA1"].ToString();
                        KVAR2.Text = data["KVA2"].ToString();
                        KVAR3.Text = data["KVA3"].ToString();

                        /**/
                        PF0.Text = data["A_VF"].ToString();
                        PF1.Text = data["PF1"].ToString();
                        PF2.Text = data["PF2"].ToString();
                        PF3.Text = data["PF3"].ToString();

                        /**/
                        KWH.Text = data["KWH"].ToString();
                        freq.Text = data["f"].ToString();

                        /**/
                        double iNon = Convert.ToDouble(data["AI"]);
                        double iOne = Convert.ToDouble(data["I1"]);
                        double iTwo = Convert.ToDouble(data["I2"]);
                        double iThree = Convert.ToDouble(data["I3"]);

                        series.Add(new LineSeries()
                        {
                            Values = new ChartValues<double>(limitValueList(nonValue, iNon)),
                            Title = "I",
                            StrokeThickness = 2,
                            Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(155, 93, 229)),
                            Fill = System.Windows.Media.Brushes.Transparent,
                            LineSmoothness = 3,
                            PointGeometrySize = 10,
                            PointForeground =
                            new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
                        });
                        series.Add(new LineSeries()
                        {
                            Values = new ChartValues<double>(limitValueList(oneValue, iOne)),
                            Title = "I1",
                            StrokeThickness = 2,
                            Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(138, 201, 38)),
                            Fill = System.Windows.Media.Brushes.Transparent,
                            LineSmoothness = 2,
                            PointGeometrySize = 10,
                            PointForeground =
                            new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
                        });
                        series.Add(new LineSeries()
                        {
                            Values = new ChartValues<double>(limitValueList(twoValue, iTwo)),
                            Title = "I2",
                            StrokeThickness = 2,
                            Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(215, 38, 61)),
                            Fill = System.Windows.Media.Brushes.Transparent,
                            LineSmoothness = 2,
                            PointGeometrySize = 10,
                            PointForeground =
                            new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
                        });
                        series.Add(new LineSeries()
                        {
                            Values = new ChartValues<double>(limitValueList(threeValue, iThree)),
                            Title = "I3",
                            StrokeThickness = 2,
                            Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(252, 255, 253)),
                            Fill = System.Windows.Media.Brushes.Transparent,
                            LineSmoothness = 2,
                            PointGeometrySize = 10,
                            PointForeground =
                            new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
                        });
                        cartesianChart1.Series = series;

                        copyList(nonValue, limitValueList(nonValue, iNon));
                        copyList(oneValue, limitValueList(oneValue, iOne));
                        copyList(twoValue, limitValueList(twoValue, iTwo));
                        copyList(threeValue, limitValueList(threeValue, iThree));
                    }
                    else if (data.ContainsKey("SensorA"))
                    {
                        DI0.Text = checkState(data["SensorA"].ToString());
                        DI1.Text = checkState(data["SensorB"].ToString());
                        DO0.Text = checkState(data["RelayA"].ToString());
                        DO1.Text = checkState(data["RelayB"].ToString());
                    }
                }
                catch
                {
/*                    Application.Exit();*/
                }           
            }
        }
        #endregion

        private void Dashboard_Load(object sender, EventArgs e)
        {
            #region Connect MQTT
            try
            {
                client = new MqttClient(mqttURI, mqttPort, false, MqttSslProtocols.None, null, null)
                {
                    ProtocolVersion = MqttProtocolVersion.Version_3_1
                };
                client.Connect(clientId, username, password, true, 60);
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                client.Subscribe(new string[] { topicPublish, "CabinetDevice01" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            }
            catch (Exception)
            {
                Application.Exit();
            }
            #endregion
        }

        string checkState(string strIn)
        {
            if (strIn == "0")
            {
                return "OFF";
            }
            else return "ON";
        }

        private List<double> limitValueList(List<double> data, double value)
        {
            List<double> listData = new List<double>(data);
            if (data.Count < 5)
            {

                listData.Add(value);


            }
            else
            {
                int count = data.Count - 5;
                for (int i = 0; i < count + 1; i++)
                {
                    listData.RemoveAt(0);
                }
                listData.Add(value);

            }
            return listData;
        }
        private bool copyList(List<double> one, List<double> two)
        {
            one.Clear();
            foreach (var item in two)
            {
                one.Add(item);
            }
            return true;

        }

        private void onRelayA_Click(object sender, EventArgs e)
        {
            string message = "ON1";
            client.Publish(topicPublish, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void offRelayA_Click(object sender, EventArgs e)
        {
            string message = "OFF1";
            client.Publish(topicPublish, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void onRelayB_Click(object sender, EventArgs e)
        {
            string message = "ON2";
            client.Publish(topicPublish, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void offRelayB_Click(object sender, EventArgs e)
        {
            string message = "OFF2";
            client.Publish(topicPublish, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void btnDALISend_Click(object sender, EventArgs e)
        {
            client.Publish(topicPublish, Encoding.UTF8.GetBytes(convertDALIOption(DALIdata)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void cbxDALI_SelectedIndexChanged(object sender, EventArgs e)
        {
            DALIdata = cbxDALI.SelectedItem.ToString();
        }
        private string convertDALIOption(string strIn)
        {
            string result = null;
            if(strIn == "MAX")
            {
                result = "DLMAX";
            }
            else if(strIn == "OFF")
            {
                result = "DLOFF";
            }
            else if(strIn == "MIN")
            {
                result = "DLMIN";
            }
            return result;
        }
    }
}
