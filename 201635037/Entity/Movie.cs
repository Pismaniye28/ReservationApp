using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201635037.Entity
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Showtimes { get; set;}
        public int RoomId { get; set; }

        public string FullInfo {
            get
            {
                return $"{Title}|||||{Description}|||||{Showtimes}|||||Room No :{RoomId}";
            }
        }
        public string AllData
        {
            get
            {
                return $"Movie ID:{Id}|Title:{Title}|Description:{Description}|ReleaseDate:{ReleaseDate}|Showtimes:{Showtimes}|RoomId{RoomId}";
            }
        }
    }
}

