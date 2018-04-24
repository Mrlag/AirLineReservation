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
using System.Windows.Shapes;
using WpfAppAirLineReservation.MyUserControl;
using WpfAppAirLineReservation.Properties;

namespace WpfAppAirLineReservation
{
    /// <summary>
    /// PassengerInformation.xaml 的互動邏輯
    /// </summary>
    public partial class PassengerInformation : Window
    {
        public PassengerInformation()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PassengerInformationPanel Pip = new PassengerInformationPanel();
            PassengerLists.Items.Add(Pip);

        }

        public string PassengerNumber
        {
            set
            {

            }

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (PassengerInformationPanel x in PassengerLists.Items.OfType<PassengerInformationPanel>())
            {


            }

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
                                //CountryCombo.Items.Add(DataReader[$"CountryName"].ToString());

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





        class PassengerDetail
        {
            string PassportNo;
            string FirstName;
            string LastName;

            string MenOrGirl;
            string Gender
            {
                get
                {
                    return MenOrGirl;
                }

                set
                {
                    if (value == "男")
                        MenOrGirl = "W";
                    else
                        MenOrGirl = "M";

                }
            }
            string ContactNumber;
            string PassengerEmail;
            DateTime BornDate;
            DateTime PassportExpiredDate;

            string CountryID;
            string CountryIDTransfer
            {

                get
                {
                    return CountryID;
                }

                set
                {
                    for (int i = 0; i <= MainWindow.CityCountryList.Count - 1; i++)
                    {
                        if (MainWindow.CityCountryList[i].Country == value)
                        {
                            CountryID = MainWindow.CityCountryList[i].CountryID;
                            break;
                        }
                     }
                }

            }




        }


    }

}

