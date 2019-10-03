using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    interface IConcertHall
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ticketType { get; set; }
        public Nullable<int> totalOfPpl { get; set; }
        public int AddressId { get; set; }
    }
}

