using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerFrm : Form
    {
        private OrdersDBEntities dbContext = new WindowsFormsApp1.OrdersDBEntities();
        private OrdersDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter = new OrdersDBDataSetTableAdapters.CustomerTableAdapter();
        private OrdersDBDataSet.CustomerDataTable customerDataTable = null;
        private OrdersDBDataSet.CustomerRow customerRowInst = null;

        public CustomerFrm()
        {
            InitializeComponent();
        }

        public CustomerFrm(Guid customerID)
        {
            InitializeComponent();

            customerDataTable = customerTableAdapter.GetDataByID(customerID);
            customerRowInst = customerDataTable.Single();

            txtFirstName.Text = customerRowInst.FirstName;
            txtSurname.Text = customerRowInst.LastName;
                          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool validDetails = true;
            // Test Text Boxes
            if ((txtFirstName.Text == String.Empty) || txtSurname.Text == String.Empty)
            {
                validDetails = false;
                lblErrorMsg.Visible = true;

                if (txtFirstName.Text == String.Empty)
                {
                    txtFirstName.Focus();
                    txtFirstName.BackColor = Color.Beige;
                }
                else
                {
                    txtSurname.Focus();
                    txtSurname.BackColor = Color.Beige;

                }
            }

            if (validDetails == true)
            {
                customerRowInst.FirstName = txtFirstName.Text;
                customerRowInst.LastName = txtSurname.Text;
                customerTableAdapter.Update(customerRowInst);

                this.Close();
            }
            else
            {

            }

        }

        internal OrdersDBEntities GetDBContext()
        {
            return dbContext;
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorMsg.Visible = false;
            txtFirstName.BackColor = Color.White;

            // // Allowing only any letter OR Digit  and Allowing BackSpace character
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')   
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorMsg.Visible = false;
            txtSurname.BackColor = Color.White;

            // // Allowing only any letter OR Digit  and Allowing BackSpace character
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
