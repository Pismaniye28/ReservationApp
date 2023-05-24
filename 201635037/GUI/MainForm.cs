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
    public partial class MainForm : Form
    {
        DataAccess db = new DataAccess();
        List<Movie> Movies = new List<Movie>();
        List<Rooms> Rooms = new List<Rooms>();
   
        public MainForm()
        {
            InitializeComponent();
            LBMovies.DataSource = db.GetMovies();
            LBMovies.DisplayMember = "FullInfo";

            LBRooms.DataSource = db.GetRooms();
            LBRooms.DisplayMember = "FullInfo";
        }

        private void LBRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            
        }

        private void LBMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            var Settings = new Settings();
            Settings.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            var data = db.GetByCustomerID((int)numericUpDown1.Value);
            var data2 = db.GetMoviesByCustomerId((int)numericUpDown1.Value);
            var movieTitles = string.Join(", ", data2.Select(d => d.Title));
            var seatNumber = string.Join(", ", data.Select(d => d.SeatNumber));
            var dateTime = string.Join(", ", data.Select(d => d.ReservationTime));

            var ticket = new ConfirmationForm(dateTime, movieTitles, seatNumber);
            ticket.ShowDialog();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reser = new ReservationForm();
            reser.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
