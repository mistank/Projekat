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
    public partial class UCSearchPassenger : UserControl
    {
        public UCSearchPassenger()
        {
            InitializeComponent();
            editBtn.Enabled = false;
            saveDiscardPanel.Visible = false;

            fieldsPanel.Enabled = false;

            LoadComboBox();
            LoadDgv();

        }
        private void LoadDgv()
        {
            var dataSource = SearchPassenger();
            if (dataSource != null)
            {
                passengersDgv.DataSource = dataSource;
                passengersDgv.Columns["Values"].Visible = false;
                passengersDgv.Columns["TableName"].Visible = false;
            }
        }
        private void LoadComboBox()
        {
            PropertyInfo[] properties = typeof(Passenger).GetProperties().Where(prop => prop.Name != "TableName" && prop.Name != "Values").ToArray();
            searchByCb.DataSource = properties;
            searchByCb.DisplayMember = "Name";
            searchByCb.SelectedIndex = -1;
        }
        public void SetFields()
        {
            firstNameTb.Text = (string)passengersDgv.SelectedRows[0].Cells["FirstName"].Value;
            lastNameTb.Text = (string)passengersDgv.SelectedRows[0].Cells["LastName"].Value;
            phoneTb.Text = (string)passengersDgv.SelectedRows[0].Cells["Phone"].Value;
        }
        public void ClearFields()
        {
            foreach (Guna2TextBox tb in fieldsPanel.Controls.OfType<Guna2TextBox>().ToList())
            {
                tb.Text = "";
            }
        }
        private object SearchPassenger(string enteredValue = "")
        {

            SearchValue searchValue = new SearchValue()
            {
                Parameter = ((PropertyInfo)searchByCb.SelectedItem)?.Name,
                Value = enteredValue,
                Type = typeof(Passenger)
            };
            //trenutno castujem samo iz string u int, posle treba i datume, o tom potom
            if (searchValue.Type == typeof(int)) searchValue.Value = (int)searchValue.Value;
            return SearchPassengerController.Instance.Search(searchValue);
        }
        private void EditPassenger()
        {
            Passenger editedPassenger = new Passenger()
            {
                FirstName = firstNameTb.Text,
                LastName = lastNameTb.Text,
                Phone = phoneTb.Text,
            };
            Passenger origPassenger = new Passenger()
            {
                FirstName = (string)passengersDgv.SelectedRows[0].Cells["FirstName"].Value,
                LastName = (string)passengersDgv.SelectedRows[0].Cells["LastName"].Value,
                Phone = (string)passengersDgv.SelectedRows[0].Cells["Phone"].Value,
                JMBG = (string)passengersDgv.SelectedRows[0].Cells["JMBG"].Value,
            };

            EditValue editValue = new EditValue()
            {
                OriginalValue = origPassenger,
                EditedValue = editedPassenger,
                Type = typeof(Passenger)
            };
            EditPassengerController.Instance.EditPassenger(editValue);
        }
        private void searchBarTb_TextChanged(object sender, EventArgs e)
        {
            passengersDgv.DataSource = SearchPassenger(searchTb.Text);
        }
        private void searchByCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Enableujem textbox");
            if (searchByCb.SelectedIndex != -1) searchTb.Enabled = true;
            else searchTb.Enabled = false;
        }
        private void passengersDgv_DoubleClick(object sender, EventArgs e)
        {
            SetFields();
            editBtn.Enabled = true;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm saving changes?", "Saving Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (CheckFields() && CheckPhoneNumber() && CheckNames()){
                    EditPassenger();
                    saveDiscardPanel.Visible = false;
                    editBtn.Visible = true;
                    passengersDgv.DataSource = SearchPassenger();
                    passengersDgv.Enabled = true;
                    fieldsPanel.Enabled = false;
                    searchTb.Text = "";
                    ClearFields();
                }
            }
        }

        private bool CheckNames()
        {
            if (firstNameTb.Text.Any(char.IsDigit) || lastNameTb.Text.Any(char.IsDigit)) return false;
            return true;
        }

        private bool CheckPhoneNumber()
        {
            if (phoneTb.Text.Length != 10 || !phoneTb.Text.All(char.IsDigit))
            {
                MessageBox.Show("Wrong phone number format","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CheckFields()
        {
            bool fieldsEntered = true;
            foreach (Guna2TextBox tb in fieldsPanel.Controls.OfType<Guna2TextBox>().ToList())
            {
                if (string.IsNullOrEmpty(tb.Text) || tb.Text.Trim(' ').Contains(" "))
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
            if (!fieldsEntered) MessageBox.Show("Some fields are empty or contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return fieldsEntered;
        }
        private void discardBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = true;
            saveDiscardPanel.Visible = false;
            SetFields();
            passengersDgv.Enabled = true;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = false;
            saveDiscardPanel.Visible = true;
            fieldsPanel.Enabled = true;
            passengersDgv.Enabled = false;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int passengerRowIndex = passengersDgv.SelectedRows[0].Index;
            DeletePassengerController.Instance.Delete((Passenger)passengersDgv.Rows[passengerRowIndex].DataBoundItem);
            LoadDgv();
        }
    }
}
