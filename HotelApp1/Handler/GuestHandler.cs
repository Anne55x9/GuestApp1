using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp1.ViewModel;
using HotelApp1.Model;
using HotelApp1.Common;

namespace HotelApp1.Handler
{
    class GuestHandler
    {
        //private GuestHandler MyHandler;
        public GuestViewModel gvm { get; set; }
        public GuestHandler(GuestViewModel ViewModel)
        {
            this.gvm = ViewModel;
        }

        public void AddGuest()
        {
            Guest tempGuest = new Guest();
            tempGuest.Name = gvm.Name;
            tempGuest.Address = gvm.Address;
            tempGuest.Guest_No = gvm.GuestId;
            GuestCatalogSingleton.SingletonInstance.AddNewGuest(tempGuest);
            GuestCatalogSingleton.SingletonInstance.LoadGuests();
        }
    }
}
