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
    public partial class UCSearchReservation : UserControl
    {
        public UCSearchReservation()
        {
            InitializeComponent();

            searchTb.Enabled = false;
            editBtn.Enabled = false;
            saveDiscardPanel.Visible = false;

            passengerSearchPanel.Visible = false;
            passengerFieldsPanel.Enabled = false;

            tripSearchPanel.Visible = false;
            tripSearchPanel.Enabled = false;

            reservationDp.Enabled = false;

            LoadSearchByComboBox();
            LoadStatusComboBox();
            LoadDgv();

        }

        private void LoadDgv()
        {
            object dataSource = SearchReservation();
            reservationsDgv.DataSource = dataSource;
            if (dataSource != null)
            {
                reservationsDgv.Columns["Values"].Visible = false;
                reservationsDgv.Columns["TableName"].Visible = false;
                reservationsDgv.Columns["Id"].Visible = false;
                reservationsDgv.ClearSelection();
            }
        }
        private object SearchReservation(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = ((PropertyInfo)searchByCb.SelectedItem)?.Name,
                Value = enteredValue,
                Type = typeof(Reservation)
            };
            //trenutno castujem samo iz string u int, posle treba i datume, o tom potom
            if (searchValue.Type == typeof(int)) searchValue.Value = (int)searchValue.Value;
            return SearchReservationController.Instance.Search(searchValue);
        }
        private void LoadTripsDgv()
        {
            var dataSource = SearchTrip();
            if (dataSource != null)
            {
                tripsDgv.DataSource = dataSource;
                if (tripsDgv.Columns.Count > 0)
                {
                    tripsDgv.Columns["TableName"].Visible = false;
                    tripsDgv.Columns["Values"].Visible = false;
                    tripsDgv.Columns["Id"].Visible = false;
                }
            }
        }
        private void LoadSearchByComboBox()
        {
            PropertyInfo[] properties = typeof(Reservation).GetProperties().Where(prop => prop.Name != "TableName" && prop.Name != "Values" && prop.Name != "Id").ToArray();
            searchByCb.DataSource = properties;
            searchByCb.DisplayMember = "Name";
            searchByCb.SelectedIndex = -1;
            statusCb.ValueMember = "Value";
        }
        private void LoadStatusComboBox()
        {
            List<ReservationStatus> statusList = Enum.GetValues(typeof(ReservationStatus)).Cast<ReservationStatus>().ToList();
            statusCb.DataSource = statusList;
            statusCb.DisplayMember = "Name";
            statusCb.SelectedIndex = -1;
        }
        private object SearchTrips(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = "Destination",
                Value = enteredValue,
                Type = typeof(Trip)
            };
            //trenutno castujem samo iz string u int, posle treba i datume, o tom potom
            if (searchValue.Type == typeof(int)) searchValue.Value = (int)searchValue.Value;
            return SearchTripController.Instance.Search(searchValue);
        }
        private void EditReservation()
        {
            // Dobijanje objekta iz DataSource-a koji odgovara odabranom redu
            int reservationRowIndex = reservationsDgv.SelectedRows[0].Index;
            Reservation origReservation = (Reservation)reservationsDgv.Rows[reservationRowIndex].DataBoundItem;

            int passengerRowIndex = passengersDgv.SelectedRows[0].Index;
            int tripRowIndex = tripsDgv.SelectedRows[0].Index;

            Reservation editedReservation = new Reservation()
            {
                Passenger = (Passenger)passengersDgv.Rows[passengerRowIndex].DataBoundItem,
                Trip = (Trip)tripsDgv.Rows[tripRowIndex].DataBoundItem,
                ReservationDate = origReservation.ReservationDate,
                Status = (ReservationStatus)statusCb.SelectedItem
            };
            EditValue editValue = new EditValue()
            {
                OriginalValue = origReservation,
                EditedValue = editedReservation,
                Type = typeof(Reservation)
            };
            EditReservationController.Instance.EditReservation(editValue);
        }
        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            var dataSource = SearchReservation(searchTb.Text);
            if (dataSource != null)
            {
                reservationsDgv.DataSource = dataSource;
                if (reservationsDgv.Columns.Count > 0)
                {
                    reservationsDgv.Columns["TableName"].Visible = false;
                    reservationsDgv.Columns["Values"].Visible = false;
                    reservationsDgv.Columns["Id"].Visible = false;
                }
            }
        }
        private void searchTripTb_TextChanged(object sender, EventArgs e)
        {
            var dataSource = SearchTrips(searchDestinationTb.Text);
            if (dataSource != null)
            {
                tripsDgv.DataSource = dataSource;
                tripsDgv.Columns["TableName"].Visible = false;
                tripsDgv.Columns["Values"].Visible = false;
                tripsDgv.Columns["Id"].Visible = false;
            }

        }
        private void searchByCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchByCb.SelectedIndex != -1)
            {
                switch (((PropertyInfo)searchByCb.SelectedItem).Name)
                {
                    case "Trip":
                        tripSearchPanel.Visible = true;
                        tripSearchPanel.Enabled = true;
                        passengerSearchPanel.Visible = false;
                        searchTb.Enabled = false;
                        reservationDp.Enabled = false;
                        LoadDestinationsDgv();
                        LoadTripsDgv();
                        LoadDgv();
                        break;
                    case "Passenger":
                        searchTb.Enabled = false;
                        passengerSearchPanel.Visible = true;
                        tripSearchPanel.Visible = false;
                        reservationDp.Enabled = false;
                        LoadPassengersDgv();
                        LoadDgv();
                        break;
                    case "Status":
                        searchTb.Enabled = true;
                        reservationDp.Enabled = false;
                        passengerSearchPanel.Visible = false;
                        tripSearchPanel.Visible = false;
                        LoadDgv();
                        break;
                    case "ReservationDate":
                        reservationDp.Enabled = true;
                        searchTb.Enabled = false;
                        passengerSearchPanel.Visible = false;
                        tripSearchPanel.Visible = false;
                        LoadDgv();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                searchTb.Enabled = false;
                passengerSearchPanel.Visible = false;
                tripSearchPanel.Visible = false;
                reservationDp.Enabled = false;
            }
        }
        private void tripsDgv_DoubleClick(object sender, EventArgs e)
        {
            int tripId = (int)tripsDgv.SelectedRows[0].Cells["Id"].Value;
            if (editBtn.Enabled) SetTripFields(true);
            else
            {
                var dataSource = SearchReservation(tripId.ToString());
                if (dataSource != null)
                {
                    reservationsDgv.DataSource = dataSource;
                    if (reservationsDgv.Rows.Count > 0)
                    {
                        reservationsDgv.Columns["Values"].Visible = false;
                        reservationsDgv.Columns["TableName"].Visible = false;
                        reservationsDgv.Columns["Id"].Visible = false;
                        reservationsDgv.ClearSelection();
                    }
                }
            }
        }
        private void passengerDgv_DoubleClick(object sender, EventArgs e)
        {
            string passengerJmbg = (string)passengersDgv.SelectedRows[0].Cells["JMBG"].Value;
            if (editBtn.Enabled) SetPassengerFields(true);
            else
            {
                var dataSource = SearchReservation(passengerJmbg);
                if (dataSource != null)
                {
                    reservationsDgv.DataSource = dataSource;
                    if (reservationsDgv.Rows.Count > 0)
                    {
                        reservationsDgv.DataSource = dataSource;
                        reservationsDgv.Columns["Values"].Visible = false;
                        reservationsDgv.Columns["TableName"].Visible = false;
                        reservationsDgv.Columns["Id"].Visible = false;
                        reservationsDgv.ClearSelection();
                        MessageBox.Show("System found a reservation with the specified values.", "Reservation found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("System didn't find a reservation with the specified values.", "Reservation not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void reservationsDgv_DoubleClick(object sender, EventArgs e)
        {
            statusCb.SelectedItem = reservationsDgv.SelectedRows[0].Cells["Status"].Value;
            reservationDp.Value = (DateTime)reservationsDgv.SelectedRows[0].Cells["ReservationDate"].Value;
            passengerSearchPanel.Enabled = false;
            tripSearchPanel.Enabled = false;
            editBtn.Enabled = true;
            reservationDp.Enabled = false;
            searchByCb.SelectedIndex = -1;
            searchByCb.Enabled = false;
            LoadDestinationsDgv();
            LoadPassengersDgv();
            LoadTripsDgv();
            SetTripFields();
            SetPassengerFields();

            MessageBox.Show("The system has successfully entered the trip", "Trip entered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SetTripFields(Boolean edit = false)
        {
            Trip trip;
            int rowIndex;
            if (edit)
            {
                rowIndex = tripsDgv.SelectedRows[0].Index;
                trip = (Trip)tripsDgv.Rows[rowIndex].DataBoundItem;
            }
            else
            {
                trip = (Trip)reservationsDgv.SelectedRows[0].Cells["Trip"].Value;
            }
            departureDateDp.Value = trip.DepartureDate;
            arrivalDateDp.Value = trip.ArrivalDate;
            priceTb.Text = $"{trip.Price}";
            destinationTb.Text = trip.Destination.ToString();
        }
        public void SetPassengerFields(Boolean edit = false)
        {
            Passenger passenger;
            int rowIndex;
            if (edit && passengersDgv.SelectedRows.Count > 0)
            {
                rowIndex = passengersDgv.SelectedRows[0].Index;
                passenger = (Passenger)passengersDgv.Rows[rowIndex].DataBoundItem;
            }
            else
            {
                passenger = (Passenger)reservationsDgv.SelectedRows[0].Cells["Passenger"].Value;
            }
            firstNameTb.Text = passenger.FirstName;
            lastNameTb.Text = passenger.LastName;
            phoneTb.Text = passenger.Phone;

        }
        public void ClearFields()
        {
            foreach (Guna2TextBox tb in passengerFieldsPanel.Controls.OfType<Guna2TextBox>().ToList())
            {
                tb.Text = "";
            }

            foreach (Guna2TextBox tb in tripFieldsPanel.Controls.OfType<Guna2TextBox>().ToList())
            {
                tb.Text = "";
            }
            searchByCb.SelectedIndex = -1;
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
        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm saving changes?", "Saving Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EditReservation();
                saveDiscardPanel.Visible = false;
                searchByCb.Enabled = true;

                editBtn.Visible = true;
                editBtn.Enabled = false;

                tripsDgv.DataSource = SearchTrips();
                tripsDgv.Enabled = true;

                passengersDgv.DataSource = SearchPassenger();
                passengersDgv.Enabled = true;

                passengerFieldsPanel.Enabled = false;
                searchTb.Text = "";

                ClearFields();
                tripSearchPanel.Visible = false;
                passengerSearchPanel.Visible = false;
                tripsDgv.ClearSelection();
                passengersDgv.ClearSelection();

                searchDestinationTb.Text = "";
                searchPassengerTb.Text = "";
                LoadDgv();

                MessageBox.Show($"Reservation successfuly edited!", "Reservation successfully edited!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = false;
            saveDiscardPanel.Visible = true;

            passengerSearchPanel.Visible = true;
            passengerSearchPanel.Enabled = true;

            tripSearchPanel.Visible = true;
            tripSearchPanel.Enabled = true;

            passengersDgv.Enabled = true;
            tripsDgv.Enabled = true;

            searchByCb.Enabled = false;
            searchTb.Enabled = false;

            tripFieldsPanel.Enabled = true;
            passengerFieldsPanel.Enabled = true;
            reservationDp.Enabled = false;

            LoadTripsDgv();
            LoadPassengersDgv();
            LoadDestinationsDgv();
        }
        private void LoadPassengersDgv()
        {
            var dataSource = SearchPassenger();
            if (dataSource != null)
            {
                passengersDgv.DataSource = dataSource;
                passengersDgv.Columns["TableName"].Visible = false;
                passengersDgv.Columns["Values"].Visible = false;
                passengersDgv.Columns["JMBG"].Visible = false;
            }
        }
        private void discardBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = true;
            saveDiscardPanel.Visible = false;
            SetPassengerFields();
            SetTripFields();
            tripsDgv.Enabled = true;
            passengerSearchPanel.Visible = false;
            tripSearchPanel.Visible = false;
            ClearFields();
        }
        private object SearchTrip(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = "Destination",
                Value = enteredValue,
                Type = typeof(Trip)
            };
            //trenutno castujem samo iz string u int, posle treba i datume, o tom potom
            if (searchValue.Type == typeof(int)) searchValue.Value = (int)searchValue.Value;
            return SearchTripController.Instance.Search(searchValue);
        }
        private void Cb_DropDown(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).FillColor = Color.FromArgb(10, 186, 180);
            ((Guna2ComboBox)sender).ForeColor = Color.Black;
        }
        private void Cb_DropDownClosed(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).FillColor = Color.FromArgb(22, 23, 22);
            ((Guna2ComboBox)sender).ForeColor = Color.White;

        }
        private void searchPassengerTb_TextChanged(object sender, EventArgs e)
        {
            var dataSource = SearchPassenger(searchPassengerTb.Text);
            if (dataSource != null)
            {
                passengersDgv.DataSource = dataSource;
                if (passengersDgv.Rows.Count > 0)
                {
                    passengersDgv.Columns["TableName"].Visible = false;
                    passengersDgv.Columns["Values"].Visible = false;
                    passengersDgv.Columns["JMBG"].Visible = false;
                }
            }
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
            tripsDgv.DataSource = SearchTrip(destinationId.ToString());
            if (tripsDgv.Columns.Count > 0)
            {
                tripsDgv.Columns["TableName"].Visible = false;
                tripsDgv.Columns["Values"].Visible = false;
                tripsDgv.Columns["Id"].Visible = false;
            }
            //searchByCb.SelectedIndex = -1;
            reservationDp.Enabled = false;
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
        private void searchDestinationTb_TextChanged(object sender, EventArgs e)
        {
            var dataSource = SearchDestination(searchDestinationTb.Text);
            if (dataSource != null)
            {
                destinationsDgv.DataSource = dataSource;
                if (destinationsDgv.Rows.Count > 0)
                {
                    destinationsDgv.Columns["TableName"].Visible = false;
                    destinationsDgv.Columns["Values"].Visible = false;
                    destinationsDgv.Columns["Id"].Visible = false;
                }
            }

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int reservationRowIndex = reservationsDgv.SelectedRows[0].Index;
            DeleteReservationController.Instance.Delete((Reservation)reservationsDgv.Rows[reservationRowIndex].DataBoundItem);

            searchByCb.Enabled = true;
            searchByCb.SelectedIndex = -1;
            saveDiscardPanel.Visible = false;

            editBtn.Visible = true;
            editBtn.Enabled = false;

            tripsDgv.DataSource = SearchTrips();
            tripsDgv.Enabled = true;

            passengersDgv.DataSource = SearchPassenger();
            passengersDgv.Enabled = true;

            passengerFieldsPanel.Enabled = false;
            searchTb.Text = "";

            ClearFields();
            tripSearchPanel.Visible = false;
            passengerSearchPanel.Visible = false;
            tripsDgv.ClearSelection();
            passengersDgv.ClearSelection();

            searchDestinationTb.Text = "";
            searchPassengerTb.Text = "";
            LoadDgv();


        }
        private void reservationDp_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Odabran item u Cb-u " + searchByCb.SelectedIndex);
            if (searchByCb.SelectedIndex == 0)
            {
                Console.WriteLine("Uso sam u if");
                reservationsDgv.DataSource = SearchReservation(string.Format("{0:yyyy-MM-dd}", reservationDp.Value));
                if (reservationsDgv.SelectedRows.Count > 0)
                {
                    reservationsDgv.Columns["TableName"].Visible = false;
                    reservationsDgv.Columns["Values"].Visible = false;
                    reservationsDgv.Columns["Id"].Visible = false;
                }
            }
        }
    }
}
