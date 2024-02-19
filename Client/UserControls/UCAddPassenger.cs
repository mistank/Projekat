using Client.Controller;
using Common.Domain;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCAddPassenger : UserControl
    {
        public UCAddPassenger()
        {
            InitializeComponent();
            AddPassengerController.Instance.AddPassengerForm = this;
        }
        private bool CheckPhoneNumber()
        {
            if (phoneTb.Text.Length != 10 || !phoneTb.Text.All(char.IsDigit))
            {
                MessageBox.Show("Wrong phone number format");
                return false;
            }
            return true;
        }
        private void addPassengerBtn_Click(object sender, EventArgs e)
        {
            if(CheckFields() && CheckPhoneNumber() && CheckJMBG())AddPassenger();
            

        }
        private bool CheckJMBG()
        {
            if (JMBGTb.Text.Length != 13 || !JMBGTb.Text.All(char.IsDigit))
            {
                MessageBox.Show("Wrong JMBG format", "Adding passenger unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CheckFields()
        {
            bool fieldsEntered = true;
            foreach (Guna2TextBox tb in passengerFieldsPanel.Controls.OfType<Guna2TextBox>().ToList())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    fieldsEntered = false;
                    tb.BorderColor = Color.Red;
                    tb.BorderThickness = 1;
                }
                else
                {
                    tb.BorderThickness = 0;
                }
            }
            if(!fieldsEntered) MessageBox.Show("Some fields are empty", "Adding passenger unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return fieldsEntered;
        }
        public void AddPassenger()
        {
            Passenger passenger = new Passenger(firstNameTb.Text, lastNameTb.Text, JMBGTb.Text, phoneTb.Text);
            AddPassengerController.Instance.AddPassenger(passenger);
        }
    }
}
