using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp1.Model;

namespace HotelApp1.ViewModel
{
    class GuestViewModel
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public void GemGuest()
        {
            Guest newGuest = new Guest();
            //newGuest.Address
        }
    }
}
