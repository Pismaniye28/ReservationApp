using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201635037.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int ReservationId { get; set; }
        public string AllData
        {
            get
            {
                return $"Customer ID:{Id}|CustomerFullName:{Name},{Surname}|PhoneNumber:{PhoneNumber}|ReservationId:{ReservationId}";
            }
        }
    }
}
