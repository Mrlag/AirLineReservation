using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfAppAirLineReservation.Properties;

namespace WpfAppAirLineReservation
{
    public partial class 選擇航班 : Form
    {
        public 選擇航班()
        {
            InitializeComponent();
            
            CollectDataFromAirLine();
            CreateButtonWithFlightSchedule(MainWindow.DepartureTime);

        }

        private void CreateButtonWithFlightSchedule(DateTime SelectTime)
        {
            
            
            for (int i = -5; i <= 5; i++)
            {
                List<PlaneTicketDetailList> Lists = new List<PlaneTicketDetailList>();
                int FlightCount = R.Next(0, 5);
                for (int j = 0; j <= FlightCount; j++)
                {
                    PlaneTicketDetailList list = new PlaneTicketDetailList();
                    list.AirLineName = AirLines[R.Next(0, AirLines.Count)].AirLineName;
                    list.AirLineID = AirLines[R.Next(0, AirLines.Count)].AirLineID;
                    list.DepartureTime = DateTime.Parse(SelectTime.AddDays(i).ToString("yyyy/MM/dd ") + " " + GenerateRandomDates().ToString("HH:mm"));
                    list.ArrivalTime = list.DepartureTime.AddHours(R.Next(3, 15)).AddMinutes(R.Next(0,30));
                    list.EconomyClass = R.Next(24000, 25000);
                    list.BusinessClass = R.Next(27000, 29000);
                    list.FirstClass = R.Next(29000,30000);
                    list.ID = Guid.NewGuid().ToString();
                    Lists.Add(list);
                }
                Button Btn = new Button();
                Btn.Name = SelectTime.AddDays(i).ToShortDateString();
                Btn.Text= SelectTime.AddDays(i).ToShortDateString()+"\n" + $"{(decimal)Lists[R.Next(0,Lists.Count)].EconomyClass:C0}";
                Btn.Tag = Lists;
                Btn.Size = new Size(100,100);
                Btn.GotFocus += Btn_GotFocus;
                flowLayoutPanel1.Controls.Add(Btn);
            }
            
        }

        private void Btn_GotFocus(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            List<PlaneTicketDetailList> lists = new List<PlaneTicketDetailList>();
            lists = (List<PlaneTicketDetailList>)((Button)sender).Tag;
            for (int i = 0; i <= lists.Count - 1; i++)
            {
                TicketDetail SchedulePanel = new TicketDetail();
                SchedulePanel.AirLine = lists[i].AirLineName;
                SchedulePanel.DepartureTime = lists[i].DepartureTime;
                SchedulePanel.DeparturePlace = MainWindow.DeparturePlace;
                SchedulePanel.FlyTime = lists[i].ArrivalTime.Subtract(lists[i].DepartureTime);
                SchedulePanel.ArrivalTime = lists[i].ArrivalTime;
                SchedulePanel.ArrivalPlace = MainWindow.ArrivalPlace;
                SchedulePanel.FirstClassAllInformation = lists[i];
                SchedulePanel.FirstClassPrice = lists[i].FirstClass;
                SchedulePanel.BusinessClassAllInformation = lists[i];
                SchedulePanel.BusinessClassPrice = lists[i].BusinessClass;
                SchedulePanel.EconomyClassAllInformation = lists[i];
                SchedulePanel.EconomyClassPrice = lists[i].EconomyClass;


                flowLayoutPanel2.Controls.Add(SchedulePanel);
            }

            foreach (TicketDetail x in flowLayoutPanel2.Controls.OfType<TicketDetail>())
            {
                foreach (GroupBox XX in x.Controls.OfType<GroupBox>())
                {
                    foreach (Button XXX in XX.Controls.OfType<Button>())
                    {
                        XXX.Click += XXX_Click;
                    }

                }
            }
        }

        private void XXX_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach (TicketDetail x in flowLayoutPanel2.Controls.OfType<TicketDetail>())
            {
                foreach (GroupBox XX in x.Controls.OfType<GroupBox>())
                {
                    foreach (Button XXX in XX.Controls.OfType<Button>())
                    {
                        XXX.BackColor = System.Drawing.SystemColors.ButtonFace;
                    }

                }
            }
             ((Button)sender).BackColor = Color.Orange;
            int SelectClass=0;
            if (((Button)sender).Name == "FirstClassButton")
                SelectClass = ((PlaneTicketDetailList)((Button)sender).Tag).FirstClass;
            else if (((Button)sender).Name == "BusinessClassButton")
                SelectClass = ((PlaneTicketDetailList)((Button)sender).Tag).BusinessClass;
            else if (((Button)sender).Name == "EconomyClassButton")
                SelectClass = ((PlaneTicketDetailList)((Button)sender).Tag).EconomyClass;
            label1.Text = $"去程\n航空公司:{((PlaneTicketDetailList)((Button)sender).Tag).AirLineName}\n" +
                $"出發地:{MainWindow.DeparturePlace}\n" +
                $"目的地:{MainWindow.ArrivalPlace}\n" +
                $"班機出發時間:{((PlaneTicketDetailList)((Button)sender).Tag).DepartureTime}\n" +
                $"班機抵達時間:{((PlaneTicketDetailList)((Button)sender).Tag).ArrivalTime}\n" +
                $"人數:{MainWindow.PeopleCount}人\n" +
                $"總價位:{SelectClass* MainWindow.AdultCount+ SelectClass*MainWindow.KidCount:C0}";

        }

        List<AirLine> AirLines = new List<AirLine>();





        private void AddFlightData(DateTimePicker DP2, List<PlaneTicketDetailList> List)
        {
            for (int i = 0; i <= R.Next(15, 30) - 1; i++)
            {
                int temp = R.Next(0, 10);
                int pp;
                int tempPrice = R.Next(20000, 25000);
                PlaneTicketDetailList Fake = new PlaneTicketDetailList();
                Fake.AirLineName = AirLines[pp = R.Next(0, AirLines.Count)].AirLineName;
                Fake.AirLineID = AirLines[pp].AirLineID; ;
                Fake.DepartureTime = DateTime.Parse(DP2.Value.AddDays(temp).ToString("yyyy/MM/dd ") + " " + GenerateRandomDates().ToString("HH:mm"));
                Fake.ArrivalTime = Fake.DepartureTime.AddHours(R.Next(3, 15));
                Fake.ButtonTag = temp;
                Fake.EconomyClass = tempPrice;
                Fake.KidPrice = tempPrice + R.Next(1000, 2501);
                //Fake.TotalPrice = tempPrice * Convert.ToInt16(comboBox3.Text.Substring(0, 1)) + Fake.KidPrice * Convert.ToInt16(comboBox4.Text.Substring(0, 1));

                Fake.ID = Guid.NewGuid().ToString();
                List.Add(Fake);

            }
        }


        Random R = new Random(Guid.NewGuid().GetHashCode());

        public DateTime GenerateRandomDates()
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());

            var year = 2018;
            var month = rnd.Next(1, 13);
            var days = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, days,
               rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60), rnd.Next(0, 1000));
        }










        //類別及屬性
        internal class AirLine
        {
            internal string AirLineName;
            internal string AirLineID;
        }
        internal class PlaneClass
        {
            internal string ClassName;
            internal string ClassID;
            public override string ToString()   //object.ToString
            {
                return this.ClassName;
            }
        }
        

        internal class PlaneTicketDetailList
        {
            internal int ButtonTag;
            internal string ID;
            internal string AirLineName;
            internal string AirLineID;
            internal DateTime DepartureTime;
            internal DateTime ArrivalTime;
            internal int EconomyClass;
            internal int BusinessClass;
            internal int FirstClass;
            internal int KidPrice;
            internal int TotalPrice;
            internal string CouponCode;
            internal string Status = null;
        }
        internal class CouponCheck
        {
            internal string CouponCode;

        }



        //---------------
       
        private void CollectDataFromAirLine()
        {

            try
            {
                SqlConnection Conn = null;
                using (Conn = new SqlConnection())
                {
                    Conn.ConnectionString = Settings.Default.AirLineReservation;
                    using (SqlCommand SqlCom = new SqlCommand())
                    {
                        SqlCom.CommandText = $"select * from AirLine";
                        SqlCom.Connection = Conn;
                        Conn.Open();
                        using (SqlDataReader DataReader = SqlCom.ExecuteReader())
                        {
                            while (DataReader.Read())
                            {
                                AirLine AirLine = new AirLine();
                                AirLine.AirLineID = DataReader[$"AirLineID"].ToString();
                                AirLine.AirLineName = DataReader[$"AirLineName"].ToString();
                                AirLines.Add(AirLine);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.HorizontalScroll.Value += 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.HorizontalScroll.Value -= 100;
            }
            catch (Exception x)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Button x in flowLayoutPanel2.Controls.OfType<Button>())
            {
                
                if(x.BackColor == Color.Orange)
            }
        }
    }
}
