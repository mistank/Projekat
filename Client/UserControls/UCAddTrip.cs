using Client.Controller;
using Common.Domain;
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
    public partial class UCAddTrip : UserControl
    {
        public UCAddTrip()
        {
            InitializeComponent();

            LoadDestinationsDgv();
            destinationTb.Enabled = false;
        }

        private void addTripBtn_Click(object sender, EventArgs e)
        {
            if (departureDateDp.Value.Date<DateTime.Now.Date || departureDateDp.Value.Date >= arrivalDataDp.Value.Date)
            {
                MessageBox.Show("Departure date must not be in the past and has to be before the arrival date","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!priceTb.Text.All(char.IsDigit) || string.IsNullOrEmpty(priceTb.Text))
            {
                MessageBox.Show("Price format is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(destinationTb.Text))
            {
                MessageBox.Show("Enter destination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddTrip();
            }
        }
        private void AddTrip()
        {
            int rowIndex = destinationsDgv.SelectedRows[0].Index;
            Trip trip = new Trip()
            {
                DepartureDate = departureDateDp.Value,
                ArrivalDate = arrivalDataDp.Value,
                Price = Int32.Parse(priceTb.Text),
                Destination = (Destination)destinationsDgv.Rows[rowIndex].DataBoundItem
            };
            AddTripController.Instance.AddTrip(trip);
        }
        private void LoadDestinationsDgv()
        {
            var dataSource = SearchDestination();
            destinationsDgv.DataSource = dataSource;
            if (dataSource != null)
            {
                destinationsDgv.Columns["TableName"].Visible = false;
                destinationsDgv.Columns["Values"].Visible = false;
                destinationsDgv.Columns["Id"].Visible = false;
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
            string name = (string)destinationsDgv.SelectedRows[0].Cells["DestinationName"].Value;
            string state = destinationsDgv.SelectedRows[0].Cells["State"].Value.ToString();
            destinationTb.Text = $"{name}, {state}";
            searchDestinationTb.Text = "";
            searchDestinationTb.Enabled = false;
        }
        private void searchDestinationTb_TextChanged(object sender, EventArgs e)
        {
            var dataSource = SearchDestination(searchDestinationTb.Text);
            destinationsDgv.DataSource = dataSource;
        }

    }
}
