using _201635037.Data;
using _201635037.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201635037.GUI
{
    public partial class ReservationForm : Form
    {
        DataAccess db = new DataAccess();
        public ReservationForm()
        {
            InitializeComponent();


            listBox1.DataSource = db.GetMovies();
            listBox1.DisplayMember = "FullInfo";

            listBox2.DataSource = db.GetRooms();
            listBox2.DisplayMember = "FullInfo";
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            // Load initial data or perform any necessary setup
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         

            // Save the customer and reservation data to the database or perform any desired operations
            db.SaveCustomer(txtName.Text, txtSurname.Text, txtPhoneNumber.Text);
            db.SaveReservation(txtMovieTitle.Text, (int)numericUpDown1.Value,(int)numericUpDown3.Value, dateTimePicker1.Value, (int)numericUpDown2.Value);

            MessageBox.Show("Reservation saved successfully!");

            // Clear the form fields after saving
            ClearForm();
        }


        private void ClearForm()
        {
            // Clear all form fields
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtMovieTitle.Text = string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
