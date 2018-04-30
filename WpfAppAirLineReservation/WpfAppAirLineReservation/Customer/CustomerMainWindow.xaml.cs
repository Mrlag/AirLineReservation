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

        //自訂Entity_ConnectionString   
        

        private void change_page(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            this.pageview.Navigate(new Uri("/Customer/" + btn.Tag.ToString() + ".xaml", UriKind.Relative));

        }

        
    }
}
