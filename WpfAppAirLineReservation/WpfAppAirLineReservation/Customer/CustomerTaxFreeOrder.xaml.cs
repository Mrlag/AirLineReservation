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

namespace WpfAppAirLineReservation.Customer
{
    /// <summary>
    /// TaxFreeOrder.xaml 的互動邏輯
    /// </summary>
    public partial class CustomerTaxFreeOrder : Page
    {
        public CustomerTaxFreeOrder()
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

        public class TaxFreeProductOrder
        {
            public int TaxFreeProductOrderID { set; get; }
            public string CouponID{ set; get; }
            public string PaymentMethodID { set; get; }
            public string PassengerID { set; get; }
            public DateTime OrderDate { set; get; }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            //這邊有新增AirLineReservationEntities2建構子的參數
            AirLineReservationEntities2 db = new AirLineReservationEntities2(GetSQLConnectionString());

            System.Windows.Data.CollectionViewSource customerorderViewSource;

            //load資料
            db.TaxFreeProductOrders.Load();

            var query = from TForder in db.TaxFreeProductOrders
                       select new TaxFreeProductOrder
                       {
                           TaxFreeProductOrderID=TForder.TaxFreeProductOrderID,
                           CouponID=TForder.Coupon.CouponCode,
                           PaymentMethodID=TForder.PaymentMethod.PaymentMethod1,
                           PassengerID=TForder.Passenger.FirstName+TForder.Passenger.LastName,
                           OrderDate=TForder.OrderDate
                       };

            //將CollectionViewSource跟Page.Resources的CollectionViewSource做連繫
            customerorderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("taxFreeProductOrderViewSource")));

           
            customerorderViewSource.Source = query.ToList();



        }
    }
}
