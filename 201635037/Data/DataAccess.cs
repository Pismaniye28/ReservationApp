using _201635037.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _201635037.Data
{
    public class DataAccess
    {
        //Filmlerin hepsi
        public List<Movie> GetMovies()
        {
            using (IDbConnection c = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                c.Open();
                var movies = c.Query<Movie>("SELECT * FROM Movie").ToList();
                return movies;

            }

        }

        public List<Movie> GetMoviesByCustomerId(int Id)
        {
            using (IDbConnection c = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                c.Open();
                var customerId = Id; // Replace with the desired customer ID
                var movies = c.Query<Movie>($"SELECT * FROM Reservation WHERE CustomerId = {customerId}").ToList();
                return movies;

            }

        }

        public void InsertMovie(string title,string description,DateTime releaseDate,DateTime showTime,int roomId)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                var Id = GetMovies().Count; 
                var PK = Id = Id + 1; 
                con.Open();
                Movie mov = new Movie {Id=PK, Title = title,Description=description,ReleaseDate=releaseDate, Showtimes = showTime,RoomId=roomId };
                List<Movie> newMovie = new List<Movie>();
                newMovie.Add(mov);
                con.Execute("INSERT INTO Movie (Id,Title,Description,ReleaseDate,Showtimes,RoomId) VALUES(@Id,@Title,@Description,@ReleaseDate,@Showtimes,@RoomId)", newMovie);
            }
        }

        public void DeleteMovie(int It)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
               
              con.Open();
                con.Execute($"DELETE FROM Movie WHERE Id = {It};");
            }
        }

        //Odaların hepsi 
        public List<Rooms> GetRooms()
        {
            using (var connection = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                connection.Open();
                var rooms = connection.Query<Rooms>("SELECT * FROM Rooms").ToList();
                return rooms;
            }
        }
        public void InsertRoom(string contactNum, int seatRow, int seatColmn, int allSeats, DateTime dateBlock, int movieId)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                var Id = GetRooms().Count;
                var PK = Id = Id + 1;
                Rooms newRoom = new Rooms { Id = PK, ContactNum = contactNum, SeatRow = (int)seatRow, SeatColmn = (int)seatColmn, AllSeats = (int)allSeats, DateBlock = dateBlock, MovieId =(int) movieId };
                List<Rooms> room = new List<Rooms>();
                room.Add(newRoom);
                con.Execute("INSERT INTO Rooms (Id,ContactNum,SeatRow,SeatColmn,AllSeats,DateBlock,MovieId) VALUES(@Id,@ContactNum,@SeatRow,@SeatColmn,@AllSeats,@DateBlock,@MovieId)", room);
            }
        }
        public void DeleteRoom(int It)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {

                con.Open();
                con.Execute($"DELETE FROM Rooms WHERE Id = {It};");
            }
        }
        //Customer hepsi
        public List<Customer> GetCustomer()
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                con.Open();
                var customers = con.Query<Customer>("SELECT * FROM Customer").ToList();
                return customers;

            }

        }
        public void SaveCustomer(string name, string surname, string phoneNumber)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                var IT = GetReservation().Count;
                var IB = IT = IT + 1;
                var Id = GetCustomer().Count;
                var PK = Id = Id + 1;
                con.Open();
                Customer mov = new Customer { Id = PK, Name = name, Surname = surname, PhoneNumber = phoneNumber};
                List<Customer> newMovie = new List<Customer>();
                newMovie.Add(mov);
                con.Execute("INSERT INTO Customer (Id,Name,Surname,PhoneNumber) VALUES(@Id,@Name,@Surname,@PhoneNumber)", newMovie);
            }
        }

        public void DeleteCustomer(int value)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {

                con.Open();
                con.Execute($"DELETE FROM Customer WHERE Id = {value};");
               
            }
        }
        //Rezervasyon hepsi
        public List<Reservation> GetByCustomerID(int Id)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                con.Open();
                var customerId = Id; // Replace with the desired customer ID
                var reservations = con.Query<Reservation>($"SELECT * FROM Reservation WHERE CustomerId = {customerId}").ToList();
                return reservations;

            }

        }

        public List<Reservation> GetReservation()
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                con.Open();
                var reservation = con.Query<Reservation>("SELECT * FROM Reservation").ToList();
                return reservation;

            }

        }

        public void SaveReservation(string movieTitle, int value1, int value2, DateTime value3, int value4)
        {
            using (IDbConnection con = new SqlConnection(Helper.CnnVal("CinemaDB")))
            {
                var IT = GetReservation().Count;
                var IB = IT = IT + 1;
                var Id = GetCustomer().Count;
                
                con.Open();
                Reservation mov = new Reservation { Id = IB, MovieTitle = movieTitle, MovieId = value1, SeatNumber = value2, ReservationTime = value3, RoomId = value4, CustomerId = Id };
                List<Reservation> newMovie = new List<Reservation>();
                newMovie.Add(mov);
                con.Execute("INSERT INTO Reservation (Id,MovieTitle,MovieId,SeatNumber,ReservationTime,RoomId,CustomerId) VALUES(@Id,@MovieTitle,@MovieId,@SeatNumber,@ReservationTime,@RoomId,@CustomerId)", newMovie);
            }
        }
    }
}
