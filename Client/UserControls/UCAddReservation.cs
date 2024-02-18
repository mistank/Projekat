using Client.Controller;
using Common.Domain;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCAddReservation : UserControl
    {
        public UCAddReservation()
        {
            InitializeComponent();

            LoadComboBox();
            LoadTripsDgv();
            LoadPassengersDgv();
            LoadDestinationsDgv();
            passengerFielsPanel.Enabled = false;

        }

        private void LoadPassengersDgv()
        {
            var dataSource = SearhPassengers();
            if (dataSource != null)
            {
                passengersDgv.DataSource = dataSource;
                passengersDgv.Columns["TableName"].Visible = false;
                passengersDgv.Columns["Values"].Visible = false;
                //tripsDgv.Columns["Id"].Visible = false;
            }
        }
        private object SearhPassengers(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = "Name",
                Value = enteredValue,
                Type = typeof(Passenger)
            };
            return SearchPassengerController.Instance.Search(searchValue);
        }
        private void LoadDestinationsDgv()
        {
            var dataSource = SearchDestination();
            if (dataSource != null)
            {
                destinationsDgv.DataSource = dataSource;
                destinationsDgv.Columns["TableName"].Visible = false;
                destinationsDgv.Columns["Values"].Visible = false;
                destinationsDgv.Columns["Id"].Visible = false;
            }
        }
        private void LoadTripsDgv()
        {
            var dataSource = SearchTrips();
            if (dataSource != null)
            {
                tripsDgv.DataSource = dataSource;
                tripsDgv.Columns["TableName"].Visible = false;
                tripsDgv.Columns["Values"].Visible = false;
                tripsDgv.Columns["Id"].Visible = false;
            }
        }
        private void tripsDgv_DoubleClick(object sender, EventArgs e)
        {
            SetTripFields();
        }
        public void SetTripFields()
        {
            departureDateDp.Value = (DateTime)tripsDgv.SelectedRows[0].Cells["DepartureDate"].Value;
            arrivalDateDp.Value = (DateTime)tripsDgv.SelectedRows[0].Cells["ArrivalDate"].Value;
            priceTb.Text = tripsDgv.SelectedRows[0].Cells["Price"].Value.ToString();
            destinationTb.Text = tripsDgv.SelectedRows[0].Cells["Destination"].Value.ToString();
        }
        private object SearchTrips(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = "Destination",
                Value = enteredValue,
                Type = typeof(Trip)
            };
            return SearchTripController.Instance.Search(searchValue);
        }
        private void LoadComboBox()
        {
            List<ReservationStatus> statusList = Enum.GetValues(typeof(ReservationStatus)).Cast<ReservationStatus>().ToList();
            statusCb.DataSource = statusList;
            statusCb.DisplayMember = "Name";
            statusCb.SelectedIndex = -1;
        }
        private void addReservationBtn_Click(object sender, EventArgs e)
        {
            if (CheckFields()) AddTrip();
            else MessageBox.Show("Some fields are empty");
        }
        private void AddTrip()
        {
            int passengerRowIndex = passengersDgv.SelectedRows[0].Index;
            int tripRowIndex = tripsDgv.SelectedRows[0].Index;

            Reservation reservation = new Reservation()
            {
                ReservationDate = DateTime.Now,
                Passenger = (Passenger)passengersDgv.Rows[passengerRowIndex].DataBoundItem,
                Trip = (Trip)tripsDgv.Rows[tripRowIndex].DataBoundItem,
                Status = (ReservationStatus)statusCb.SelectedItem
            };
            AddReservationController.Instance.AddReservation(reservation);
        }
        private void passengersDgv_DoubleClick(object sender, EventArgs e)
        {
            SetPassengerFields();
        }
        public void SetPassengerFields()
        {
            firstNameTb.Text = (string)passengersDgv.SelectedRows[0].Cells["FirstName"].Value;
            lastNameTb.Text = (string)passengersDgv.SelectedRows[0].Cells["LastName"].Value;
            phoneTb.Text = (string)passengersDgv.SelectedRows[0].Cells["Phone"].Value;
        }
        private void Dp_DropDown(object sender, EventArgs e)
        {
            ((Guna2DateTimePicker)sender).FillColor = System.Drawing.Color.FromArgb(10, 186, 180);
            ((Guna2DateTimePicker)sender).ForeColor = System.Drawing.Color.Black;
        }
        private void Dp_Leave(object sender, EventArgs e)
        {
            ((Guna2DateTimePicker)sender).FillColor = System.Drawing.Color.FromArgb(22, 23, 22);
            ((Guna2DateTimePicker)sender).ForeColor = System.Drawing.Color.White;
        }
        private void searchPassengerTb_TextChanged(object sender, EventArgs e)
        {
            passengersDgv.DataSource = SearchPassenger(searchPassengerTb.Text);
        }
        private object SearchPassenger(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = "FirstName",
                Value = enteredValue,
                Type = typeof(Passenger)
            };
            //trenutno castujem samo iz string u int, posle treba i datume, o tom potom
            if (searchValue.Type == typeof(int)) searchValue.Value = (int)searchValue.Value;
            return SearchPassengerController.Instance.Search(searchValue);
        }
        private object SearchDestination(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = "DestinationName",
                Value = enteredValue,
                Type = typeof(Destination)
            };
            //trenutno castujem samo iz string u int, posle treba i datume, o tom potom
            if (searchValue.Type == typeof(int)) searchValue.Value = (int)searchValue.Value;
            return SearchTripController.Instance.Search(searchValue);
        }
        private void destinationsDgv_DoubleClick(object sender, EventArgs e)
        {
            int destinationId = (int)destinationsDgv.SelectedRows[0].Cells["Id"].Value;
            tripsDgv.DataSource = SearchTrips(destinationId.ToString());
            if (tripsDgv.Columns.Count > 0)
            {
                tripsDgv.Columns["TableName"].Visible = false;
                tripsDgv.Columns["Values"].Visible = false;
                tripsDgv.Columns["Id"].Visible = false;
            }
        }
        private void searchDestinationTb_TextChanged(object sender, EventArgs e)
        {
            destinationsDgv.DataSource = SearchDestination(searchDestinationTb.Text);
        }
        private bool CheckFields()
        {
            List<Guna2TextBox> textBoxes = new List<Guna2TextBox>() { firstNameTb, lastNameTb, phoneTb, priceTb, destinationTb };
            bool fieldsEntered = true;
            foreach (Guna2TextBox tb in textBoxes)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    fieldsEntered = false;
                    tb.BorderColor = Color.Red;
                    tb.BorderThickness = 1;
                }
                else
                {
                    tb.BorderColor = Color.Red;
                    tb.BorderThickness = 0;
                }
            }
            if (statusCb.SelectedIndex == -1)
            {
                fieldsEntered = false;
                statusCb.BorderThickness = 1;
                statusCb.BorderColor = Color.Red;
            }
            else
            {
                statusCb.BorderThickness = 0;
                statusCb.BorderColor = Color.Red;
            }

            return fieldsEntered;
        }
    }
}
