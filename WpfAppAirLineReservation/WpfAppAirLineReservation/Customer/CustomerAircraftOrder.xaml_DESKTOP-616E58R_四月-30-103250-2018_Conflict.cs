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
        
        //自訂Entity_ConnectionString   
        public string GetSQLConnectionString()
        {
            SqlConnectionStringBuilder providerCs = new SqlConnectionStringBuilder();

            providerCs.DataSource = "220.135.38.91,727";
            providerCs.InitialCatalog = "AirLineReservation";
            providerCs.IntegratedSecurity = false;
            //providerCs.UserInstance = true;
            providerCs.UserID = "sa";
            providerCs.Password = "12345678";

            var csBuilder = new EntityConnectionStringBuilder();

            csBuilder.Provider = "System.Data.SqlClient";
            csBuilder.ProviderConnectionString = providerCs.ToString();
            //Metadata使用原先EntityConnectionStringBuilder的Metadata
            csBuilder.Metadata = @"res://*/AirLineReservationModel1.csdl|res://*/AirLineReservationModel1.ssdl|res://*/AirLineReservationModel1.msl";

            return csBuilder.ToString();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            //這邊有新增AirLineReservationEntities2建構子的參數
            AirLineReservationEntities2 db = new AirLineReservationEntities2(GetSQLConnectionString());
            
            System.Windows.Data.CollectionViewSource customerorderViewSource;
            
            
            //load資料
            db.Orders.Include("City").Include("PaymentMethod").Load();

            //將CollectionViewSource跟Page.Resources的CollectionViewSource做連繫
            customerorderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerorder")));

            var query = from order in db.Orders 
                        where order.UniformNo != null
                        select new {
                            OrderID=order.OrderID,
                            AirLineID = order.AirLine.AirLineName,
                            TravalClassID = order.TravelClass.TravalClassName,
                            DeparturePlace =order.City.CityName,
                            DepartureDate = order.DepartureDate.TimeOfDay,
                            DepartureTime = order.DepartureTime,
                            ArrivalPlace = order.City1.CityName,
                            //ArrivalDate = order.ArrivalDate,
                            ArrivalTime =order.ArrivalTime,
                            PaymentMethodID=order.PaymentMethod.PaymentMethod1,
                            FlightRoute=order.FlightRoute,
                            AdultCount=order.AdultCount,
                            AdultPrice=order.AdultPrice,
                            ChildCount=order.ChildCount,
                            ChildPrice=order.ChildPrice,
                            ServiceFee=order.ServiceFee
                        };


            customerorderViewSource.Source = query.ToList();



        }

        private void orderDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
