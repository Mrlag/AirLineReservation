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
        

        public class TaxFreeProductOrder
        {
            public int TaxFreeProductOrderID { set; get; }
            public string CouponID { set; get; }
            public string PaymentMethodID { set; get; }
            public string PassengerID { set; get; }
            public DateTime OrderDate { set; get; }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            //這邊有新增AirLineReservationEntities2建構子的參數
            AirLineReservationEntities2 db = new AirLineReservationEntities2(CustomerMainWindow.GetSQLConnectionString);

            System.Windows.Data.CollectionViewSource customerorderViewSource;

            //load資料
            db.TaxFreeProductOrders.Load();

            var query = from TForder in db.TaxFreeProductOrders
                        where TForder.PassengerID == CustomerMainWindow.loginmemberID
                        select new TaxFreeProductOrder
                        {
                            TaxFreeProductOrderID = TForder.TaxFreeProductOrderID,
                            CouponID = TForder.Coupon.CouponCode,
                            PaymentMethodID = TForder.PaymentMethod.PaymentMethod1,
                            PassengerID = TForder.Passenger.FirstName + TForder.Passenger.LastName,
                            OrderDate = TForder.OrderDate
                        };

            //將CollectionViewSource跟Page.Resources的CollectionViewSource做連繫
            customerorderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("taxFreeProductOrderViewSource")));


            customerorderViewSource.Source = query.ToList();



        }
    }
}
