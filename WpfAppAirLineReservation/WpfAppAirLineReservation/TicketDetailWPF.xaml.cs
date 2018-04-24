using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppAirLineReservation
{
    /// <summary>
    /// TicketDetailWPF.xaml 的互動邏輯
    /// </summary>
    public partial class TicketDetailWPF : UserControl
    {
        public TicketDetailWPF()
        {
            InitializeComponent();
        }

        public int Kidprice;
        public int Adultprice;
        public string CouponCode;





        DateTime DT;
        public DateTime DepartureTime
        {
            get
            {
                return DT;
            }


            set
            {
                DT = value;
                DepartureTimeTB.Text = DT.ToLongTimeString();
            }

        }
        string DP;
        public string DeparturePlace
        {
            get
            {
                return DP;
            }

            set
            {
                DP = value;
                DeparturePlaceTB.Text = value;
            }
        }
        public TimeSpan FlyTime
        {
            set
            {
                FlyTimeTB.Text = $"{value:c}";
            }

        }

        DateTime AT;
        public DateTime ArrivalTime
        {
            get

            {
                return AT;
            }

            set
            {
                AT = value;
                ArrivalTimeTB.Text = value.ToLongTimeString();
            }
        }
        string AP;
        public string ArrivalPlace
        {
            get
            {
                return AP;
            }

            set
            {
                AP = value;
                ArrivalPlaceTB.Text = value;
            }
        }
      

        public string AirLineID;

        string AirLineName;

        public string AirLine
        {

            get
            {
                return AirLineName;
            }

            set
            {
                AirLineName = value;
                DepartureGroup.Header = value;
            }

        }
        public object ListStore; //儲存所有機票資訊

        string number;
        public string FlightNumber
        {
            get
            {
                return number;

            }

            set
            { number = value;
                DepartureGroup.Header += $"\t航班號碼:{number}";
            }

        }

        Random R = new Random(Guid.NewGuid().GetHashCode());
        public int FirstClassPrice
        {
            set
            {
                FirstClassButton.Content = $"{value:C0}/位\n尚有{R.Next(MainWindow.PeopleCount, MainWindow.PeopleCount + 50)}位";
                FirstClassButton.Tag = value;


            }

        }
        //public object BusinessClassAllInformation
        //{
        //    set
        //    {
        //        BusinessClassButton.Tag = value;

        //    }

        //}
        public int BusinessClassPrice
        {
            set
            {
                BusinessClassButton.Content = $"{value:C0}/位\n尚有{R.Next(MainWindow.PeopleCount, MainWindow.PeopleCount + 50)}位";
                BusinessClassButton.Tag = value;
            }

        }
        //public object EconomyClassAllInformation
        //{
        //    set
        //    {
        //        EconomyClassButton.Tag = value;

        //    }

        //}
        public int EconomyClassPrice
        {
            set
            {
                EconomyClassButton.Content = $"{value:C0}/位\n尚有{R.Next(MainWindow.PeopleCount, MainWindow.PeopleCount + 50)}位";
                EconomyClassButton.Tag = value;
            }

        }





        class PlaneTicketDetailListCopy
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
        public delegate void MyEventHandler (object sender, object sender2);
        public event MyEventHandler FirstClassButtonNotify;
        private void FirstClassButton_Click(object sender, RoutedEventArgs e)
        {
            FirstClassButtonNotify(sender,this);
        }

        public delegate void MyEventHandlerB(object sender, object sender2);
        public event MyEventHandlerB BusinessClassButtonNotify;
        private void BusinessClassButton_Click(object sender, RoutedEventArgs e)
        {
            BusinessClassButtonNotify(sender, this);
        }

        public delegate void MyEventHandlerE(object sender, object sender2);
        public event MyEventHandlerE EconomyClassButtonNotify;

        private void EconomyClass_Click(object sender, RoutedEventArgs e)
        {
            EconomyClassButtonNotify(sender, this);
        }
    }
}
