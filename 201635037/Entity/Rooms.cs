using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201635037.Entity
{
    public class Rooms
    {
        public int Id { get; set; }
        public string ContactNum { get; set; }
        public int SeatRow { get; set; }
        public int SeatColmn { get; set; }
        public int AllSeats { get; set; }
        public DateTime DateBlock { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string FullInfo
        {
            get
            {
                return $"Room No: {Id}|||||Movie ID:{MovieId}||||| Total Seats :{AllSeats}";
            }
        }
        public string AllData { get {
                return $"Room No:{Id}|ContactNumber:{ContactNum}|SeatRow:{SeatRow}|SeatColumn:{SeatColmn}|AllSeats{AllSeats}|DateBlock{DateBlock}|MovieId:{MovieId}";            } }
    }
}
