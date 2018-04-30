using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppAirLineReservation.Properties;

namespace WpfAppAirLineReservation.Customer
{
    /// <summary>
    /// AircraftOrder.xaml 的互動邏輯
    /// </summary>
    public partial class CustomerAircraftOrder : Page
    {
        public CustomerAircraftOrder()
        {
            InitializeComponent();
        }

        public class mycustomerorder
        {
            public int OrderID { set; get; }
            public string AirLineID { set; get; }
            public string TravalClassID { set; get; }
            public string DeparturePlace { set; get; }
            public DateTime DepartureDate { set; get; }
            public TimeSpan DepartureTime { set; get; }
            public string ArrivalPlace { set; get; }
            public DateTime ArrivalDate { set; get; }
            public TimeSpan ArrivalTime { set; get; }
            public string PaymentMethodID { set; get; }
            public int FlightRoute { set; get; }
            public int AdultCount { set; get; }
            public decimal AdultPrice { set; get; }
            public int ChildCount { set; get; }
            public decimal ChildPrice { set; get; }
            public decimal ServiceFee { set; get; }
            public DateTime OrderDate { set; get; }
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            //這邊有新增AirLineReservationEntities2建構子的參數
            AirLineReservationEntities2 db = new AirLineReservationEntities2(CustomerMainWindow.GetSQLConnectionString);

            System.Windows.Data.CollectionViewSource customerorderViewSource;

            //load資料
            db.Orders.Include("City").Include("PaymentMethod").Load();

            //將CollectionViewSource跟Page.Resources的CollectionViewSource做連繫
            customerorderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerorder")));

            var query = from order in db.Orders                        
                        where order.MemberID==CustomerMainWindow.loginmemberID
                        select new mycustomerorder
                        {
                            OrderID = order.OrderID,
                            AirLineID = order.AirLine.AirLineName,
                            TravalClassID = order.TravelClass.TravalClassName,
                            DeparturePlace = order.City.CityName,
                            DepartureDate=order.DepartureDate,
                            DepartureTime = order.DepartureTime,
                            ArrivalPlace = order.City1.CityName,
                            ArrivalDate = order.ArrivalDate,
                            ArrivalTime = order.ArrivalTime,
                            PaymentMethodID = order.PaymentMethod.PaymentMethod1,
                            FlightRoute = (int)order.FlightRoute,
                            AdultCount = order.AdultCount,
                            AdultPrice = order.AdultPrice,
                            ChildCount = order.ChildCount,
                            ChildPrice = order.ChildPrice,
                            ServiceFee = order.ServiceFee,
                            OrderDate = order.OrderDate
                        };


            customerorderViewSource.Source = query.ToArray();



        }

        private void orderDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
