using System;
using System.Collections.Generic;
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

namespace WpfAppAirLineReservation.MyUserControl
{
    /// <summary>
    /// PassengerInformationPanel.xaml 的互動邏輯
    /// </summary>
    public partial class PassengerInformationPanel : UserControl
    {
        public PassengerInformationPanel()
        {
            InitializeComponent();
            ListsFromCountryCity();
            GenderCombo.Items.Add("男");
            GenderCombo.Items.Add("女");
          

        }
        private void ListsFromCountryCity()
        {
           
           
            try
            {
                SqlConnection Conn = null;
                using (Conn = new SqlConnection())
                {
                    Conn.ConnectionString = Settings.Default.AirLineReservation;
                    using (SqlCommand SqlCom = new SqlCommand())
                    {
                        SqlCom.CommandText = $"select *  from Country";
                        SqlCom.Connection = Conn;
                        Conn.Open();
                        using (SqlDataReader DataReader = SqlCom.ExecuteReader())
                        {
                            while (DataReader.Read())
                            {



                                CountryCombo.Items.Add(DataReader[$"CountryName"].ToString());
                                
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public string PassengerNumber
        {
            set

            {
                PassengerNumberLabel.Content = $"{value}";
            }

        }




        internal class CountryCity
        {
            internal string Country;
            internal string CountryID;
            internal string City;
            internal string CityID;
        }

    }
}
