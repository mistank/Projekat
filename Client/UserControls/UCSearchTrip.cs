using Client.Controller;
using Common;
using Common.Domain;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCSearchTrip : UserControl
    {
        public UCSearchTrip()
        {
            InitializeComponent();

            searchTb.Enabled = false;
            editBtn.Enabled = false;
            saveDiscardPanel.Visible = false;
            destinationSearchPanel.Visible = false;
            destinationTb.Enabled = false;
            LoadComboBox();
            LoadDgv();
            DisableFields();
        }

        private void DisableFields()
        {
            departureDateDp.Enabled = false;
            arrivalDateDp.Enabled = false;
            priceTb.Enabled = false;
            destinationTb.Enabled = false;
        }
        private void LoadDgv()
        {
            var dataSource = SearchTrips();
            if (dataSource != null)
            {
                tripsDgv.DataSource = dataSource;
                tripsDgv.Columns["Values"].Visible = false;
                tripsDgv.Columns["TableName"].Visible = false;
                tripsDgv.Columns["Id"].Visible = false;

                tripsDgv.ClearSelection();
            }

        }
        private void LoadDestinationsDgv()
        {
            destinationsDgv.DataSource = SearchDestination();
            destinationsDgv.Columns["TableName"].Visible = false;
            destinationsDgv.Columns["Values"].Visible = false;
            destinationsDgv.Columns["Id"].Visible = false;
        }
        private void LoadComboBox()
        {
            PropertyInfo[] properties = typeof(Trip).GetProperties().Where(prop => prop.Name != "TableName" && prop.Name != "Values" && prop.Name != "Id").ToArray();
            searchByCb.DataSource = properties;
            searchByCb.DisplayMember = "Name";
            searchByCb.SelectedIndex = -1;
        }
        private object SearchTrips(string enteredValue = "")
        {
            SearchValue searchValue = new SearchValue()
            {
                Parameter = ((PropertyInfo)searchByCb.SelectedItem)?.Name,
                Value = enteredValue,
                Type = typeof(Trip)
            };
            //trenutno castujem samo iz string u int, posle treba i datume, o tom potom
            if (searchValue.Type == typeof(int)) searchValue.Value = (int)searchValue.Value;
            return SearchTripController.Instance.Search(searchValue);
        }
        private void EditTrips()
        {
            // Dobijanje objekta iz DataSource-a koji odgovara odabranom redu
            int destinationRowIndex = destinationsDgv.SelectedRows[0].Index;
            Trip editedTrip = new Trip()
            {
                DepartureDate = departureDateDp.Value,
                ArrivalDate = arrivalDateDp.Value,
                Price = Int32.Parse(priceTb.Text),
                Destination = (Destination)destinationsDgv.Rows[destinationRowIndex].DataBoundItem,
            };
            int tripRowIndex = tripsDgv.SelectedRows[0].Index;
            Trip origTrip = (Trip)tripsDgv.Rows[tripRowIndex].DataBoundItem;
            EditValue editValue = new EditValue()
            {
                OriginalValue = origTrip,
                EditedValue = editedTrip,
                Type = typeof(Trip)
            };
            EditTripController.Instance.EditTrip(editValue);
        }
        private void searchBarTb_TextChanged(object sender, EventArgs e)
        {
            tripsDgv.DataSource = SearchTrips(searchTb.Text);
        }
        private void searchByCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchByCb.SelectedIndex != -1)
            {
                LoadDgv();
                switch (((PropertyInfo)searchByCb.SelectedItem).Name)
                {
                    case "Destination":
                        searchTb.Enabled = false;
                        destinationSearchPanel.Visible = true;
                        destinationsDgv.Enabled = true;
                        searchDestinationTb.Enabled = true;
                        priceTb.Enabled = false;
                        LoadDestinationsDgv();
                        break;
                    case "DepartureDate":
                        searchTb.Enabled = false;
                        departureDateDp.Enabled = true;
                        arrivalDateDp.Enabled = false;
                        destinationSearchPanel.Visible = false;
                        destinationsDgv.Enabled = false;
                        searchDestinationTb.Enabled = false;
                        priceTb.Enabled = false;
                        break;
                    case "ArrivalDate":
                        searchTb.Enabled = false;
                        arrivalDateDp.Enabled = true;
                        departureDateDp.Enabled = false;
                        destinationSearchPanel.Visible = false;
                        destinationsDgv.Enabled = false;
                        searchDestinationTb.Enabled = false;
                        priceTb.Enabled = false;

                        break;
                    case "Price":
                        searchTb.Enabled = true;
                        arrivalDateDp.Enabled = false;
                        departureDateDp.Enabled = false;
                        destinationSearchPanel.Visible = false;
                        destinationsDgv.Enabled = false;
                        searchDestinationTb.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            else searchTb.Enabled = false;
        }
        private void tripsDgv_DoubleClick(object sender, EventArgs e)
        {
            if (tripsDgv.Rows.Count > 0)
            {
                editBtn.Enabled = true;
                searchByCb.Enabled = false;
                searchTb.Enabled = false;
                SetFields();
            }
        }
        public void SetFields()
        {
            if (tripsDgv.SelectedRows.Count > 0)
            {
                departureDateDp.Value = (DateTime)tripsDgv.SelectedRows[0].Cells["DepartureDate"].Value;
                arrivalDateDp.Value = (DateTime)tripsDgv.SelectedRows[0].Cells["ArrivalDate"].Value;
                priceTb.Text = tripsDgv.SelectedRows[0].Cells["Price"].Value.ToString();
                destinationTb.Text = tripsDgv.SelectedRows[0].Cells["Destination"].Value.ToString();
            }
        }
        public void ClearFields()
        {
            foreach (Guna2TextBox tb in fieldsPanel.Controls.OfType<Guna2TextBox>().ToList())
            {
                tb.Text = "";
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm saving changes?", "Saving Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (departureDateDp.Value.Date < DateTime.Now.Date || departureDateDp.Value.Date >= arrivalDateDp.Value.Date)
                {
                    MessageBox.Show("Departure date must not be in the past and has to be before the arrival date");

                    arrivalDateDp.BorderColor = Color.Red;
                    departureDateDp.BorderColor = Color.Red;

                    arrivalDateDp.BorderThickness = 1;
                    departureDateDp.BorderThickness = 1;
                    destinationTb.BorderThickness = 1;
                    priceTb.BorderThickness = 0;
                }
                else if (!priceTb.Text.All(char.IsDigit) || string.IsNullOrEmpty(priceTb.Text))
                {
                    MessageBox.Show("Price format is not correct");

                    priceTb.BorderColor = Color.Red;
                    departureDateDp.BorderThickness = 0;
                    arrivalDateDp.BorderThickness = 0;
                    destinationTb.BorderThickness = 0;
                    priceTb.BorderThickness = 1;

                }
                else if (string.IsNullOrEmpty(destinationTb.Text))
                {
                    MessageBox.Show("Enter destination");
                    destinationTb.BorderColor = Color.Red;
                    destinationTb.BorderThickness = 1;

                    departureDateDp.BorderThickness = 0;
                    arrivalDateDp.BorderThickness = 0;
                    priceTb.BorderColor = Color.Red;
                    priceTb.BorderThickness = 1;
                }
                else
                {
                    EditTrips();
                    saveDiscardPanel.Visible = false;
                    editBtn.Visible = true;
                    tripsDgv.DataSource = SearchTrips();
                    tripsDgv.Enabled = true;
                    fieldsPanel.Enabled = false;
                    searchTb.Text = "";
                    searchByCb.Enabled = true;
                    ClearFields();
                    destinationSearchPanel.Visible = false;
                    tripsDgv.ClearSelection();
                    editBtn.Enabled = false;
                    searchDestinationTb.Text = "";
                }
            }
        }
        private void discardBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = true;
            editBtn.Enabled = false;
            saveDiscardPanel.Visible = false;
            SetFields();
            tripsDgv.Enabled = true;
            destinationSearchPanel.Visible = false;
            searchTb.Enabled = true;
            searchByCb.Enabled = true;
            searchDestinationTb.Enabled = false;
            destinationsDgv.Enabled = false;
            priceTb.Enabled = false;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = false;
            saveDiscardPanel.Visible = true;
            fieldsPanel.Enabled = true;
            tripsDgv.Enabled = false;
            destinationSearchPanel.Visible = true;
            destinationSearchPanel.Enabled = true;
            searchDestinationTb.Enabled = true;
            destinationsDgv.Enabled = true;
            priceTb.Enabled = true;
            departureDateDp.Enabled = true;
            arrivalDateDp.Enabled = true;

            LoadDestinationsDgv();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int tripRowIndex = tripsDgv.SelectedRows[0].Index;
            DeleteTripController.Instance.Delete((Trip)tripsDgv.Rows[tripRowIndex].DataBoundItem);
            LoadDgv();

            editBtn.Visible = true;
            editBtn.Enabled = false;
            saveDiscardPanel.Visible = false;
            destinationSearchPanel.Visible = false;
            searchByCb.Enabled = true;
            tripsDgv.Enabled = true;
            searchByCb.SelectedIndex = -1;

            priceTb.Enabled = false;
            departureDateDp.Enabled = false;
            arrivalDateDp.Enabled = false;

            ClearFields();
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
            if (destinationsDgv.Rows.Count > 0)
            {
                int destinationId = (int)destinationsDgv.SelectedRows[0].Cells["Id"].Value;
                if (!editBtn.Enabled)
                {
                    tripsDgv.DataSource = SearchTrips(destinationId.ToString());
                    if (tripsDgv.Columns.Count > 0)
                    {
                        tripsDgv.Columns["TableName"].Visible = false;
                        tripsDgv.Columns["Values"].Visible = false;
                        tripsDgv.Columns["Id"].Visible = false;
                    }
                }
                else
                {
                    int destinationRowIndex = destinationsDgv.SelectedRows[0].Index;
                    destinationTb.Text = destinationsDgv.Rows[destinationRowIndex].DataBoundItem.ToString();
                }
            }
        }
        private void searchDestinationTb_TextChanged(object sender, EventArgs e)
        {
            destinationsDgv.DataSource = SearchDestination(searchDestinationTb.Text);
        }
        private void Dp_ValueChanged(object sender, EventArgs e)
        {
            if (!editBtn.Enabled)
            {
                DateTime searchDate = ((Guna2DateTimePicker)sender).Value;
                tripsDgv.DataSource = SearchTrips(string.Format("{0:yyyy-MM-dd}", searchDate));
                if (tripsDgv.Rows.Count > 0)
                {
                    tripsDgv.Columns["Values"].Visible = false;
                    tripsDgv.Columns["TableName"].Visible = false;
                    tripsDgv.Columns["Id"].Visible = false;
                    tripsDgv.ClearSelection();
                }

            }
        }
    }
}
