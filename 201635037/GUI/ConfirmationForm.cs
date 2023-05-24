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

namespace _201635037
{
    public partial class ConfirmationForm : Form
    {
        private string dateTime;
        private string movies;
        private string seat;

        public ConfirmationForm(string dateTime, string movies, string seat)
        {
            InitializeComponent();
            this.dateTime = dateTime;
            this.movies = movies;
            this.seat = seat;
            DisplayReservationDetails();
        }

        private void DisplayReservationDetails()
        {
            lblMovieTitle.Text = movies;
            lblSeatNumber.Text = seat;
            lblReservationTime.Text = dateTime;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
