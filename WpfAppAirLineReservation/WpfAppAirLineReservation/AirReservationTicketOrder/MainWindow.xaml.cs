using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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

namespace WpfAppAirLineReservation
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Combobox1.SelectedIndex = 1;
            Combobox2.SelectedIndex = 2;
            AdultComboBox.SelectedIndex = 1;
            KidComboBox.SelectedIndex = 1;
            CityCountryList = ListsFromCountryCity();
            DepartureDatePicker.SelectedDate = DateTime.Today;
            ArrivalDatePicker.SelectedDate = DateTime.Today.AddDays(1);
            FillComboBox();
        }

        private void FillComboBox()
        {
            for (int i = 0; i <= 5; i++)
            {
                AdultComboBox.Items.Add($"{i}人");
                KidComboBox.Items.Add($"{i}人");
            }
        }

        public static string DeparturePlace;
        public static string ArrivalPlace;
        public static DateTime DepartureTime;
        public static DateTime ArrivalTime;
        public static int PeopleCount;
        public static int KidCount;
        public static int AdultCount; 

        public class Item
        {
            public string Country { get; set; }
            public string City { get; set; }
           
        }
        public class ComboboxGroup<Item>
        {
            public string CategoryName { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO檢查格子輸入

            DeparturePlace = (string)Combobox1.SelectedItem;
            ArrivalPlace = (string)Combobox2.SelectedItem;
            ArrivalTime = ArrivalDatePicker.SelectedDate.Value;
            DepartureTime = DepartureDatePicker.SelectedDate.Value;
            AdultCount = int.Parse(AdultComboBox.SelectedItem.ToString().Substring(0, 1));
            KidCount = int.Parse(KidComboBox.SelectedItem.ToString().Substring(0, 1));
            PeopleCount = AdultCount + KidCount;
            Window w = new 選擇航班_WPF();
            w.Show();
            this.Hide();




        }

        //List<CountryCity> CountryCityLists = new List<CountryCity>();
        List<string> AirPorts = new List<string>();

        public static List<CountryCity> CityCountryList = new List<CountryCity>();
        private List<CountryCity> ListsFromCountryCity()
        {
            CountryCity CityCountry = new CountryCity();
            
            try
            {
                SqlConnection Conn = null;
                using (Conn = new SqlConnection())
                {
                    Conn.ConnectionString = Settings.Default.AirLineReservation;
                    using (SqlCommand SqlCom = new SqlCommand())
                    {
                        SqlCom.CommandText = $"select * from City join Country on City.CountryID=Country.CountryID";
                        SqlCom.Connection = Conn;
                        Conn.Open();
                        using (SqlDataReader DataReader = SqlCom.ExecuteReader())
                        {
                            while (DataReader.Read())
                            {
                                CityCountry.City=(DataReader[$"CityName"].ToString());
                                Combobox1.Items.Add(CityCountry.City);
                                Combobox2.Items.Add(CityCountry.City);
                                CityCountry.CityID= (DataReader[$"CityID"].ToString());
                                CityCountry.Country= (DataReader[$"CountryName"].ToString());
                                CityCountry.CountryID= (DataReader[$"CountryID"].ToString());
                                CityCountryList.Add(CityCountry);
                            }
                            return CityCountryList;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return CityCountryList;
            }


        }

       




    }
    public class CountryCity
    {
        internal string Country;
        internal string CountryID;
        internal string City;
        internal string CityID;
    }

}
