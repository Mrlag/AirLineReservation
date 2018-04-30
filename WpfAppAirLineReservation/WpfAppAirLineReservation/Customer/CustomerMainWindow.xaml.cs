using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfAppAirLineReservation.Customer
{
    /// <summary>
    /// Manager.xaml 的互動邏輯
    /// </summary>
    public partial class CustomerMainWindow : Window
    {
        public CustomerMainWindow()
        {
            InitializeComponent();
        }
        static public int loginmemberID { set; get; }

        private void change_page(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            this.pageview.Navigate(new Uri("/Customer/" + btn.Tag.ToString() + ".xaml", UriKind.Relative));

        }

        public static string GetSQLConnectionString
        {
            get
            {
                SqlConnectionStringBuilder providerCs = new SqlConnectionStringBuilder();
                providerCs.DataSource = "darren.nctu.me,727";
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
        }


    }

}
