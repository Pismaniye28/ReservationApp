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
    public partial class Settings : Form
    {
        DataAccess db = new DataAccess();
        public Settings()
        {
            InitializeComponent();
            //Movies
            LBFullMovies.DataSource = db.GetMovies();
            LBFullMovies.DisplayMember = "AllData";
            //Rooms
            LBFullRooms.DataSource = db.GetRooms();
            LBFullRooms.DisplayMember = "AllData";
            //Customers
            LBFullCustomer.DataSource = db.GetCustomer();
            LBFullCustomer.DisplayMember = "AllData";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateRoom_Click(object sender, EventArgs e)
        {
            db.InsertRoom(contactNum.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)seatNumericUpDown3.Value, dateTimePicker1.Value, (int)numericUpDown4.Value);
        }

        private void LBFullRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void contactNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void seatNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateMovie_Click(object sender, EventArgs e)
        {
            db.InsertMovie(TBTitle.Text, TBDescription.Text, releaseDate.Value, ShowTime.Value, (int)numericUpDown7.Value);
            
        }

        private void TBTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void releaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            db.DeleteMovie((int)numericUpDown5.Value);
            this.Invalidate();
            this.Update();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
 
        }

        private void LBFullMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReservationForm();
            reservationForm.Show();
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            db.DeleteCustomer((int)numericUpDown6.Value);
        }
    }
}
