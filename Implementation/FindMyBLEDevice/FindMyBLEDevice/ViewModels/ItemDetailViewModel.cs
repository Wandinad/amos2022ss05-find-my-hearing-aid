﻿using FindMyBLEDevice.Models;
using Xamarin.Forms;

namespace FindMyBLEDevice.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        private int _currentRssi;
        public int CurrentRssi
        {
            get => _currentRssi;
            set => SetProperty(ref _currentRssi, value);
        }

        public BTDevice Device
        {
            get => App.DevicesStore.SelectedDevice;
        }

        public void OnAppearing()
        {
            App.Bluetooth.StartRssiPolling(Device.BT_GUID, (int v) => {
                CurrentRssi = v;
            });

        }

        public void OnDisappearing()
        {
            App.Bluetooth.StopRssiPolling();
        }

    }
}
