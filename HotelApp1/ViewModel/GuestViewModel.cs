using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace HotelApp1.ViewModel
{
    class GuestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // props
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        // ICommands
        
        public ObservableCollection<Guest> GuestList { get; set; }

        private Guest selectedGuest;

        

        public Guest SelectedGuest
        {
            get { return selectedGuest; }
            set
            {
                selectedGuest = value;
                
            }
        }


        public void GemGuest()
        {
            Guest newGuest = new Guest();
            //newGuest.Address
        }

    }
}
