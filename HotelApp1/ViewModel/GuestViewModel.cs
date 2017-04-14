using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using HotelApp1.Handler;
using System.Windows.Input;
using HotelApp1.Common;

namespace HotelApp1.ViewModel
{
    class GuestViewModel : INotifyPropertyChanged
    {
        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        public GuestCatalogSingleton Instance { get; set; }
        public GuestHandler MyHandler { get; set; }

        public GuestViewModel()
        {
            Instance = GuestCatalogSingleton.SingletonInstance;
            MyHandler = new GuestHandler(this);

            AddNewGuestCommand = new RelayCommand(MyHandler.AddGuest);
            DeleteGuestCommand = new RelayCommand(MyHandler.DeleteGuest);
            EditGuestCommand = new RelayCommand(MyHandler.EditGuest);
        }
        // props
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        // ICommands
        public ICommand AddNewGuestCommand { get; set; }
        public ICommand DeleteGuestCommand { get; set; }
        public ICommand EditGuestCommand { get; set; }

        public ObservableCollection<Guest> GuestList { get; set; }

        #region selectedGuest
        private Guest selectedGuest;

        public Guest SelectedGuest
        {
            get { return selectedGuest; }
            set
            {
                selectedGuest = value;
                OnPropertyChanged(nameof(SelectedGuest));
                
            }
        }
        #endregion


    }
}
