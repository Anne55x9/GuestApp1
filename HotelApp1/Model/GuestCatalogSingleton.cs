﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using HotelApp1.Model;
using HotelApp1.Persistency;

namespace HotelApp1.Model
{
    public class GuestCatalogSingleton : INotifyPropertyChanged
    {
        private static GuestCatalogSingleton Instance;

        private ObservableCollection<Guest> guestList;

        public ObservableCollection<Guest> GuestList
        {
            get { return guestList; }
            set
            {
                guestList = value;
                OnPropertyChanged(nameof(GuestList));
            }
        }

        // contructor
        public GuestCatalogSingleton()
        {
            GuestList = new ObservableCollection<Guest>();
            LoadGuests();
        }

        #region Implementering af Singleton
        // implementering af Singleton
        public static GuestCatalogSingleton SingletonInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new GuestCatalogSingleton();
                }
                return Instance;
            }
        }

        #endregion

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

        #region Hent alle gæster
        public async void LoadGuests()
        {
            GuestList = await PersistencyService.GetAllGuests();
        }
        #endregion

    }
}