﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaxyCreator.Model;
using GalaxyCreator.Model.Json;
using GalaxyCreator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace GalaxyCreator.ViewModel
{
    public class SectorEditViewModel: ViewModelBase
    {
        private Cluster _selectedMapCluster;

        private RelayCommand _isEnabledClickedCommand;

        private RelayCommand _addStationClickCommand;

        private RelayCommand _addBeltClickCommand;

        private RelayCommand _addSpaceObjectClickCommand;

        private RelayCommand<object> _deleteStationClickCommand;

        private RelayCommand<object> _deleteBeltClickCommand;

        private RelayCommand<object> _deleteSpaceObjectCommand;

        public Cluster SelectedMapCluster
        {
            get
            { 
                return _selectedMapCluster;
            }
            set
            {
                Set(ref _selectedMapCluster, value);
            }
        }

        public RelayCommand IsEnabledClickedCommand
        {
            get
            {
                if (_isEnabledClickedCommand == null)
                {
                    _isEnabledClickedCommand = new RelayCommand(() => IsEnabledClicked());
                }

                return _isEnabledClickedCommand;
            }
        }

        public RelayCommand AddStationClickCommand
        {
            get
            {
                if (_addStationClickCommand == null)
                {
                    _addStationClickCommand = new RelayCommand(() => AddStationClick());
                }

                return _addStationClickCommand;
            }
        }

        public RelayCommand AddBeltClickCommand
        {
            get
            {
                if (_addBeltClickCommand == null)
                {
                    _addBeltClickCommand = new RelayCommand(() => AddBeltClick());
                }

                return _addBeltClickCommand;
            }
        }

        public RelayCommand AddSpaceObjectClickCommand
        {
            get
            {
                if (_addSpaceObjectClickCommand == null)
                {
                    _addSpaceObjectClickCommand = new RelayCommand(() => AddSpaceObjectClick());
                }

                return _addSpaceObjectClickCommand;
            }
        }

        public RelayCommand<object> DeleteStationClickCommand
        {
            get
            {
                if (_deleteStationClickCommand == null)
                {
                    _deleteStationClickCommand = new RelayCommand<object>((parm) => DeleteStationClick(parm));
                }

                return _deleteStationClickCommand;
            }
        }

        public RelayCommand<object> DeleteBeltClickCommand
        {
            get
            {
                if (_deleteBeltClickCommand == null)
                {
                    _deleteBeltClickCommand = new RelayCommand<object>((parm) => DeleteBeltClick(parm));
                }

                return _deleteBeltClickCommand;
            }
        }

        public RelayCommand<object> DeleteSpaceObjectClickCommand
        {
            get
            {
                if (_deleteSpaceObjectCommand == null)
                {
                    _deleteSpaceObjectCommand = new RelayCommand<object>((parm) => DeleteSpaceObjectClick(parm));
                }

                return _deleteSpaceObjectCommand;
            }
        }

        public SectorEditViewModel(Cluster cluser)
        {
            SelectedMapCluster = cluser;
        }


        public void IsEnabledClicked()
        {
            if(_selectedMapCluster.IsEnabled == true)
            {
                ClusterHelperFunctions.ChooseClusterFillColour(_selectedMapCluster);
            }
            else
            {
                _selectedMapCluster.Polygon.Fill = Brushes.LightGray;
               
            }

        }

        public void AddStationClick()
        {
            _selectedMapCluster.Stations.Add(new Station());
        }

        public void AddBeltClick()
        {
            _selectedMapCluster.Belts.Add(new Belt());
        }

        public void AddSpaceObjectClick()
        {
            _selectedMapCluster.SpaceObjects.Add(new SpaceObject());
        }

        public void DeleteStationClick(object ob)
        {
            _selectedMapCluster.Stations.Remove((Station)ob);
        }

        public void DeleteBeltClick(object ob)
        {
            _selectedMapCluster.Belts.Remove((Belt)ob);
        }

        public void DeleteSpaceObjectClick(object ob)
        {
            _selectedMapCluster.SpaceObjects.Remove((SpaceObject)ob);
        }
    }
}
