using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppAirLineReservation.MyUserControl;
using WpfAppAirLineReservation.Properties;

namespace WpfAppAirLineReservation
{
    /// <summary>
    /// 選擇航班_WPF.xaml 的互動邏輯
    /// </summary>
    public partial class 選擇航班_WPF : Window
    {
        public 選擇航班_WPF()
        {
            InitializeComponent();
            CollectDataFromAirLine();
            CreateButtonWithFlightSchedule(MainWindow.DepartureTime);
        }

        private void CreateButtonWithFlightSchedule(DateTime SelectTime)
        {
            for (int i = -5; i <= 5; i++)
            {
                //產假航班資料
                List<PlaneTicketDetailList> Lists = new List<PlaneTicketDetailList>();
                int FlightCount = R.Next(5,15);
                for (int j = 0; j <= FlightCount; j++)
                {
                    PlaneTicketDetailList list = new PlaneTicketDetailList();
                    list.AirLineName = AirLines[R.Next(0, AirLines.Count)].AirLineName;
                    list.AirLineID = AirLines[R.Next(0, AirLines.Count)].AirLineID;
                    list.DepartureTime = DateTime.Parse(SelectTime.AddDays(i).ToString("yyyy/MM/dd ") + " " + GenerateRandomDates().ToString("HH:mm"));
                    list.ArrivalTime = list.DepartureTime.AddHours(R.Next(3, 15)).AddMinutes(R.Next(0, 30));
                    list.EconomyClass = R.Next(24000, 25000);
                    list.BusinessClass = R.Next(27000, 29000);
                    list.FirstClass = R.Next(29000, 30000);
                    list.flightNumber = Guid.NewGuid().ToString().Substring(0, 4); 
                    list.ID = Guid.NewGuid().ToString();
                    Lists.Add(list);
                }
                //<Button Margin="10" Height="80" Width="80" Padding="20"/>
                Button Btn = new Button();
                Btn.Height = 80;
                Btn.Width = 80;
                Btn.Margin = new Thickness(8);
                //Btn.Name =$"{SelectTime.AddDays(i).ToString(@"MMdd dd")}";
                Btn.Content = SelectTime.AddDays(i).ToString("MM月dd日\ndddd") + "\n" + $"{(decimal)Lists[R.Next(0, Lists.Count)].EconomyClass:C0}起";

                Btn.Tag = Lists; //某日所有航班的資料儲存至Tag

                Btn.GotFocus += Btn_GotFocus;

                listBox2.Items.Add(Btn);

            }
               
        }
        private void Btn_GotFocus(object sender, EventArgs e)
        {
            List<PlaneTicketDetailList> lists = new List<PlaneTicketDetailList>();
            lists = (List<PlaneTicketDetailList>)((Button)sender).Tag;
            DeparturelistBox.Items.Clear();

            for (int i = 0; i <= lists.Count - 1; i++)
            {
                //TicketDetail SchedulePanel = new TicketDetail();
                //SchedulePanel.AirLine = lists[i].AirLineName;
                //SchedulePanel.DepartureTime = lists[i].DepartureTime;
                //SchedulePanel.DeparturePlace = MainWindow.DeparturePlace;
                //SchedulePanel.FlyTime = lists[i].ArrivalTime.Subtract(lists[i].DepartureTime);
                //SchedulePanel.ArrivalTime = lists[i].ArrivalTime;
                //SchedulePanel.ArrivalPlace = MainWindow.ArrivalPlace;
                //SchedulePanel.FirstClassAllInformation = lists[i];
                //SchedulePanel.FirstClassPrice = lists[i].FirstClass;
                //SchedulePanel.BusinessClassAllInformation = lists[i];
                //SchedulePanel.BusinessClassPrice = lists[i].BusinessClass;
                //SchedulePanel.EconomyClassAllInformation = lists[i];
                //SchedulePanel.EconomyClassPrice = lists[i].EconomyClass;

                //DeparturelistBox.Items.Add(new TicketDetailWPF() {  DeparturePlace = MainWindow.DeparturePlace, FlyTime = lists[i].ArrivalTime.Subtract(lists[i].DepartureTime)
                //    , ArrivalPlace = MainWindow.ArrivalPlace, ArrivalTime = lists[i].ArrivalTime, AirLine = lists[i].AirLineName
            //});
                TicketDetailWPF W = new TicketDetailWPF();
                W.DepartureTime = lists[i].DepartureTime;
                W.DeparturePlace = MainWindow.DeparturePlace;
                W.FlyTime = lists[i].ArrivalTime.Subtract(lists[i].DepartureTime);
                W.ArrivalPlace = MainWindow.ArrivalPlace;
                W.ArrivalTime = lists[i].ArrivalTime;
                W.AirLine = lists[i].AirLineName;
                W.AirLineID = lists[i].AirLineID;
                W.ListStore = lists[i];
             
                W.FirstClassPrice = lists[i].FirstClass;
                W.FirstClassButtonNotify += W_FirstClassButtonNotify;
                W.BusinessClassPrice = lists[i].BusinessClass;
                W.BusinessClassButtonNotify += W_BusinessClassButtonNotify;
                W.EconomyClassPrice = lists[i].EconomyClass;
                W.EconomyClassButtonNotify += W_EconomyClassButtonNotify;

                W.FlightNumber = lists[i].flightNumber;
                DeparturelistBox.Items.Add(W);




            }

            //foreach (TicketDetail x in flowLayoutPanel2.Controls.OfType<TicketDetail>())
            //{
            //    foreach (GroupBox XX in x.Controls.OfType<GroupBox>())
            //    {
            //        foreach (Button XXX in XX.Controls.OfType<Button>())
            //        {
            //            XXX.Click += XXX_Click;
            //        }

            //    }
            //}
        }

        private void W_EconomyClassButtonNotify(object sender, object sender2)
        {
            MessageBoxResult Result = MessageBox.Show("行程確認?", "起飛資訊", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Result == MessageBoxResult.Yes)
            {
                foreach (ExpanderList x in ExpanderStack.Children.OfType<ExpanderList>())
                {
                    if (x.Name == "出發明細")
                    {
                        ExpanderStack.Children.Remove(x);
                        break;
                    }
                }

                var item = ((Button)sender).Tag;
                var template = (TicketDetailWPF)sender2;
                ExpanderList EpdList = new ExpanderList();
                EpdList.Name = "出發明細";
                EpdList.ExpandHeader = "出發明細";
                EpdList.FlightNumber = template.FlightNumber;
                EpdList.FlightTime = template.DepartureTime.ToString("HH:mm");

                EpdList.FlightTime2 = template.ArrivalTime.ToString("HH:mm");
                EpdList.ArrivalTime = template.ArrivalTime;
                EpdList.FlightDate = template.DepartureTime.ToString("MM月dd日");
                EpdList.FlightClass = "經濟艙";
                EpdList.FlightPrice = (int)item;
                EpdList.DeparturePlace = template.DeparturePlace;
                EpdList.ArrivalPlace = template.ArrivalPlace;
                EpdList.ExpanderButtonNotify += EpdList_ExpanderButtonNotify;
                ExpanderStack.Children.Add(EpdList);

                NextStepButton.IsEnabled = true;

                //點選的訂票資料儲存
                ClientList = new ClientOrderList();
                ClientList.AirLineID = template.AirLineID;
                ClientList.AirLineName = template.AirLine;
                ClientList.flightNumber = template.FlightNumber;
                ClientList.DepartureDateTime = template.DepartureTime;
                ClientList.ArrivalDateTime = template.ArrivalTime;
                ClientList.ClassType = "經濟艙";
                ClientList.ClassPrice = (int)item;
                ClientList.DeparturePlace = template.DeparturePlace;
                ClientList.ArrivalPlace = template.ArrivalPlace;



                listBox2.IsEnabled = false;
                GoExpander.IsEnabled = false;
                GoExpander.IsExpanded = false;
                OrderDetailExpander.IsExpanded = true;

            }
        }

        public static ClientOrderList ClientList = new ClientOrderList(); //客戶確定下單的資料
        //商務艙按鈕
        private void W_BusinessClassButtonNotify(object sender, object sender2)
        {
            MessageBoxResult Result = MessageBox.Show("行程確認?", "起飛資訊", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Result == MessageBoxResult.Yes)
            {
                foreach (ExpanderList x in ExpanderStack.Children.OfType<ExpanderList>())
                {
                    if (x.Name == "出發明細")
                    {
                        ExpanderStack.Children.Remove(x);
                        break;
                    }
                }
                
                var item = ((Button)sender).Tag;
                var template = (TicketDetailWPF)sender2;
                ExpanderList EpdList = new ExpanderList();
                EpdList.Name = "出發明細";
                EpdList.ExpandHeader = "出發明細";
                EpdList.FlightNumber = template.FlightNumber;
                EpdList.FlightTime = template.DepartureTime.ToString("HH:mm");

                EpdList.FlightTime2 = template.ArrivalTime.ToString("HH:mm");
                EpdList.ArrivalTime = template.ArrivalTime;
                EpdList.FlightDate = template.DepartureTime.ToString("MM月dd日");
                EpdList.FlightClass = "商務艙";
              EpdList.FlightPrice = (int)item;
                EpdList.DeparturePlace = template.DeparturePlace;
                EpdList.ArrivalPlace = template.ArrivalPlace;
                EpdList.ExpanderButtonNotify += EpdList_ExpanderButtonNotify;
                ExpanderStack.Children.Add(EpdList);


                NextStepButton.IsEnabled = true;

                //點選的訂票資料儲存
                ClientList = new ClientOrderList();
                ClientList.AirLineID = template.AirLineID;
                ClientList.AirLineName = template.AirLine;
                ClientList.flightNumber = template.FlightNumber;
                ClientList.DepartureDateTime = template.DepartureTime;
                ClientList.ArrivalDateTime= template.ArrivalTime;
                ClientList.ClassType = "商務艙";
                ClientList.ClassPrice = (int)item;
                ClientList.DeparturePlace =template.DeparturePlace;
                ClientList.ArrivalPlace = template.ArrivalPlace;



                listBox2.IsEnabled = false;
                GoExpander.IsEnabled = false;
                GoExpander.IsExpanded = false;
                OrderDetailExpander.IsExpanded = true;

            }
        }
        //頭等艙按鈕
        private void W_FirstClassButtonNotify(object sender, object sender2)
        {
           MessageBoxResult Result= MessageBox.Show("行程確認?", "起飛資訊", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Result == MessageBoxResult.Yes)
            {
                foreach (ExpanderList x in ExpanderStack.Children.OfType<ExpanderList>())
                {
                    if (x.Name == "出發明細")
                    {
                        ExpanderStack.Children.Remove(x);
                        break;
                    }
                }

                var item = ((Button)sender).Tag;
                var template = (TicketDetailWPF)sender2;
                ExpanderList EpdList = new ExpanderList();
                EpdList.Name = "出發明細";
                EpdList.ExpandHeader = "出發明細";
                EpdList.FlightNumber = template.FlightNumber;
               
                EpdList.FlightTime = template.DepartureTime.ToString("HH:mm");
                EpdList.FlightTime2 = template.ArrivalTime.ToString("HH:mm");
                EpdList.FlightDate = template.DepartureTime.ToString("MM月dd日");
                EpdList.FlightClass = "頭等艙";
                EpdList.FlightPrice = (int)item;
                EpdList.DeparturePlace = template.DeparturePlace;
                EpdList.ArrivalPlace = template.ArrivalPlace;
                EpdList.ExpanderButtonNotify += EpdList_ExpanderButtonNotify;
                ExpanderStack.Children.Add(EpdList);

                NextStepButton.IsEnabled = true;


                //點選的訂票資料儲存
                ClientList = new ClientOrderList();
                ClientList.AirLineID = template.AirLineID;
                ClientList.AirLineName = template.AirLine;
                ClientList.flightNumber = template.FlightNumber;
                ClientList.DepartureDateTime = template.DepartureTime;
                ClientList.ArrivalDateTime = template.ArrivalTime;
                ClientList.ClassType = "頭等艙";
                ClientList.ClassPrice = (int)item;
                ClientList.DeparturePlace = template.DeparturePlace;
                ClientList.ArrivalPlace = template.ArrivalPlace;


                listBox2.IsEnabled = false;
                GoExpander.IsEnabled = false;
                GoExpander.IsExpanded = false;
                OrderDetailExpander.IsExpanded = true;

            }
        }

        //右上角航班明細是否重新選擇航班
        private void EpdList_ExpanderButtonNotify(object sender, object sender2)
        {
            MessageBoxResult Result = MessageBox.Show("重新選擇航班?", "航班", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Result == MessageBoxResult.Yes)
            {
                foreach (ExpanderList x in ExpanderStack.Children.OfType<ExpanderList>())
                {
                    if (x.Name == "出發明細")
                    {
                        ExpanderStack.Children.Remove(x);
                        break;
                    }


                }
                listBox2.IsEnabled = true;
                GoExpander.IsEnabled = true;
                GoExpander.IsExpanded = true;
                NextStepButton.IsEnabled = false ;

            }
            else
            {
                

            }
            

        }

        
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
        List<AirLine> AirLines = new List<AirLine>();
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
            internal int TotalPrice;
            internal string CouponCode;
            internal string Status = null;
            internal string flightNumber;
        }
        internal class CouponCheck
        {
            internal string CouponCode;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }




    }
    public class ClientOrderList
    {

        internal string AirLineName;
        internal string AirLineID;
        internal DateTime DepartureDateTime;
        internal DateTime ArrivalDateTime;
        internal string DeparturePlace;
        internal string ArrivalPlace;
        internal string ClassType;
        internal int ClassPrice;
        internal int TotalPrice;
        internal string CouponCode;
        internal string Status = null;
        internal string flightNumber;
    }


}
