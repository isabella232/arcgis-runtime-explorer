﻿using System.Security.RightsManagement;
using System.Windows;
using Esri.ArcGISRuntime.Mapping;
using GalaSoft.MvvmLight;

namespace EsriDe.RuntimeExplorer.ViewModel
{
    public class MapViewModel : ViewModelBase
    {
        private Map _map = new Map(Basemap.CreateStreetsVector());

        public Map Map
        {
            get => _map;
            set => Set(ref _map, value);
        }

        private Layer _selectedLayer;

        public Layer SelectedLayer
        {
            get => _selectedLayer;
            set => Set(ref _selectedLayer, value);
        }
    }
}
