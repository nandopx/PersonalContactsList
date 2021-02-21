using PersonalContactsList.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalContactsList.Views
{
    public partial class frmNewContactForm : Form
    {
        public frmNewContactForm ()
        {
            InitializeComponent();
        }

        private void frmNewContactForm_Load ( object sender, EventArgs e )
        {

        }

        private void textBox1_TextChanged ( object sender, EventArgs e )
        {

        }

        private void textBox2_TextChanged ( object sender, EventArgs e )
        {

        }

        private void btnSaveContact_Click ( object sender, EventArgs e )
        {
            var controller = new ContactController();
            controller.NewContact( txbName.Text, txbPhone.Text, txbEmail.Text, txbBirthday.Text,
                txbLineAddress.Text, txbNumber.Text, txbComplement.Text, txbdistrict.Text, txbCity.Text,
                cmbProvince.Text, txbPostalCode.Text, cmbAddresType.Text );

            MessageBox.Show("Contact saved!");

            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
    }
}
