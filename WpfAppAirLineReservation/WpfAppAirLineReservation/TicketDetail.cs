using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfAppAirLineReservation
{
    public partial class TicketDetail : UserControl
    {
        public TicketDetail()
        {
            InitializeComponent();
            foreach (Button x in groupBox1.Controls.OfType<Button>())
            {
                //x.Click += X_Click;

            }
        }

        //private void X_Click(object sender, EventArgs e)
        //{
        //    foreach (Button x in groupBox1.Controls.OfType<Button>())
        //    {
        //        x.BackColor = System.Drawing.SystemColors.ButtonFace;
        //    }
        //    ((Button)sender).BackColor=Color.Orange;
        //}

        public DateTime DepartureTime
        {
            set
            {
                DepartureTimeLabel.Text = value.ToLongTimeString();
            }

        }

        public string DeparturePlace
        {
            set
            {
                DeparturePlaceLabel.Text = value;
            }
        }
        public TimeSpan FlyTime
        {
            set
            {
                FlyTimeLabel.Text = $"{value:c}";
            }

        }
        public DateTime ArrivalTime
        {
            set
            {
                ArrivalTimeLabel.Text = value.ToLongTimeString();
            }
        }

        public string ArrivalPlace
        {
            set
            {
                ArrivalPlaceLabel.Text = value;
            }
        }
        public string AirLine
        {
            set
            {
                groupBox1.Text = value;
            }

        }
        public object FirstClassAllInformation
        {
            set
            {
                FirstClassButton.Tag = value;
               
            }

        }
        Random R = new Random(Guid.NewGuid().GetHashCode());
        public int FirstClassPrice
        {
            set
            {
                FirstClassButton.Text = $"{value:C0}/位\n尚有{R.Next(MainWindow.PeopleCount, MainWindow.PeopleCount +50)}位";



            }

        }
        public object BusinessClassAllInformation
        {
            set
            {
                BusinessClassButton.Tag = value;

            }

        }
        public int BusinessClassPrice
        {
            set
            {
                BusinessClassButton.Text = $"{value:C0}/位\n尚有{R.Next(MainWindow.PeopleCount, MainWindow.PeopleCount + 50)}位";

            }

        }
        public object EconomyClassAllInformation
        {
            set
            {
                EconomyClassButton.Tag = value;

            }

        }
        public int EconomyClassPrice
        {
            set
            {
                EconomyClassButton.Text = $"{value:C0}/位\n尚有{R.Next(MainWindow.PeopleCount, MainWindow.PeopleCount + 50)}位";

            }

        }





        class PlaneTicketDetailListCopy
        {
            internal int ButtonTag;
            internal string ID;
            internal string AirLineName;
            internal string AirLineID;
            internal DateTime DepartureTime;
            internal DateTime ArrivalTime;
            internal int EconomyClass;
            internal int BusinessClass;
            internal int FirstClass;
            internal int KidPrice;
            internal int TotalPrice;
            internal string CouponCode;
            internal string Status = null;
        }


    }
}
