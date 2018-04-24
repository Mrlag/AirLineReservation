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

namespace WpfAppAirLineReservation.MyUserControl
{
    /// <summary>
    /// ExpanderList.xaml 的互動邏輯
    /// </summary>
    public partial class ExpanderList : UserControl
    {
        public ExpanderList()
        {
            InitializeComponent();
        }

        public string ExpandHeader
        {
            set
            {
                ExHeader.Header = value;
            }

        }

        public string FlightNumber
        {
            set
            {
                FlightNumberLabel.Content = $"航班號碼:{value}";
            }
        }

        public string FlightTime2
        {
            set
            {
                FlightTimeLabel2.Content = $"降落時間:{value}";
            }

        }



        public string FlightTime
        {
            set
            {
                FlightTimeLabel.Content = $"起飛時間:{value}";
            }
        }
        public string FlightDate
        {
            set
            {
                FlightDateLabel.Content = $"日期:{value}";
            }
        }
        public string FlightClass
        {
            set
            {
                FlightClassLabel.Content = $"艙等:{value}";
            }

        }
        public string FlightDeparturePlace
        {
            set
            {
                DeparturePlaceLabel.Content = $"{value}";
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
                DeparturePlaceLabel.Content = $"{value}";
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
                ArrivalPlaceLabel.Content = $"{value}";
            }

        }
        public int FlightPrice
        {
            set
            {
                FlightPriceLabel.Content = $"{value:C0}/位";
            }
        }

        //public DateTime DepartureTime
        //{
        //    set
        //    {
        //        DepartureTimeLabel.Content = value.ToString("HH:mm");
        //    }

        //}

        public DateTime ArrivalTime
        {
            set
            {
                ArrivalPlaceLabel.Content = value.ToString("HH:mm");
            }

        }



        public delegate void MyEventHandler(object sender, object sender2);
        public event MyEventHandler ExpanderButtonNotify;


        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ExpanderButtonNotify(sender,e);
        }

       
    }
}
