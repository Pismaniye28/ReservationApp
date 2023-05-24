using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201635037.Entity
{
    public class Reservation
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int SeatNumber { get; set; }
        public DateTime ReservationTime { get; set; }
        public int RoomId { get; set; }
        public Rooms Room { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
