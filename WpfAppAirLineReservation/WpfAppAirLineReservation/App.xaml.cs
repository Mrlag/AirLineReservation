using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppAirLineReservation
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            this.ShutdownMode = ShutdownMode.OnLastWindowClose;

            //AirLineReservation W = new AirLineReservation();
            //W.Show();

            MainWindow W = new MainWindow();
            W.ShowDialog();
            if (W.DialogResult == true)
            {
                W.Close();
                選擇航班 form = new 選擇航班();
                form.ShowDialog();
            }
            
        }
    }
}
