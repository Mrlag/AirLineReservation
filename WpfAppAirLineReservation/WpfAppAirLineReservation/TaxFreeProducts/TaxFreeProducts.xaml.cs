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

namespace WpfAppAirLineReservation.TaxFreeProducts
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class TaxFreeProducts : Window
    {
        private AirLineReservationEntities1 dbcontext = new AirLineReservationEntities1();
        public TaxFreeProducts()
        {
            InitializeComponent();

            var q = from p in dbcontext.TaxFreeProducts
                    select p;
            List<TaxFreeProduct> productlist = dbcontext.TaxFreeProducts.ToList();
            this.listbox1.ItemsSource = productlist;


        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            e.Handled = true;
            int tabItem = ((sender as TabControl)).SelectedIndex;
            if (e.Source is TabControl)
            {
                List<TaxFreeProduct> productlist = dbcontext.TaxFreeProducts.Where(a => a.ProductCategoryID == tabItem + 1).ToList();

                switch (tabItem)
                {
                    case 0:
                        this.listbox1.ItemsSource = productlist;
                        break;
                    case 1:
                        this.listbox2.ItemsSource = productlist;
                        break;
                    case 2:
                        this.listbox3.ItemsSource = productlist;
                        break;
                    case 3:
                        this.listbox4.ItemsSource = productlist;
                        break;
                    case 4:
                        this.listbox5.ItemsSource = productlist;
                        break;
                    case 5:
                        this.listbox6.ItemsSource = productlist;
                        break;
                    case 6:
                        this.listbox7.ItemsSource = productlist;
                        break;
                }
            }
        }
    }

    }




