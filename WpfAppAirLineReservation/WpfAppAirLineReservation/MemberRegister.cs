using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfAppAirLineReservation
{
    public partial class MemberRegister : Form
    {
        public MemberRegister()
        {
            InitializeComponent();
            EmailTB.GotFocus += new EventHandler(TextGotFocus);
            EmailTB.LostFocus += new EventHandler(EmailTB_LostFocus);
            
            foreach (TextBox x in this.Controls.OfType<TextBox>())
            {
                x.Focus();
                x.Select();
                
            }
            EmailTB.Focus();
            EmailTB.Select();
            PassportTB.Select();
            
        }

        private void EmailTB_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(EmailTB.Text))
                EmailTB.Text = "Example@xxxxx.com";
        }

        private void TextGotFocus(object sender, EventArgs e)
            {
            EmailTB.Text = "";
            EmailTB.ForeColor = Color.Gray;
        }

        private void MemberRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            AirLineReservationEntities dc = new AirLineReservationEntities();
            dc.Passengers.AddRange(new Passenger() { PassportNo = PassportTB.Text, FirstName=FirstNameTB.Text,LastName=LastNameTB.Text,
            Gender=comboBox1.Text,ContactNumber=ContactPersonTB.Text,PassengerEmail=EmailTB.Text,BornDate=BorndateTimePicker.Value,PassportExpiredDate=PexpireddateTimePicker2.Value,Country=CountryTB.Text});
            dc.SaveChanges();
        }
    }
}
