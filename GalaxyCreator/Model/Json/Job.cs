﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;

namespace GalaxyCreator.Model.Json
{
    public class Job : ObservableObject
    {
        private String _id;
        public String Id
        {
            get { return _id; }
            set
            {
                Set(ref _id, value);
            }
        }

        private String _name;
        public String Name
        {
            get { return _name; }
            set
            {
                Set(ref _name, value);
            }
        }

        private bool? _startActive = null;
        public bool? StartActive
        {
            get { return _startActive; }
            set
            {
                Set(ref _startActive, value);
            }
        }

        private bool? _disabled = null;
        public bool? Disabled
        {
            get { return _disabled; }
            set
            {
                Set(ref _disabled, value);
            }
        }

        private bool? _rebuild = null;
        public bool? Rebuild
        {
            get { return _rebuild; }
            set
            {
                Set(ref _rebuild, value);
            }
        }

        private bool? _comandeerable = null;
        public bool? Commandeerable
        {
            get { return _comandeerable; }
            set
            {
                Set(ref _comandeerable, value);
            }
        }

        private bool? _subordinate = null;
        public bool? Subordinate
        {
            get { return _subordinate; }
            set
            {
                Set(ref _subordinate, value);
            }
        }

        private Boolean _buildatshipyard = true;
        public Boolean Buildatshipyard
        {
            get { return _buildatshipyard; }
            set
            {
                Set(ref _buildatshipyard, value);
            }
        }

        private JobLocation _jobLocation = new JobLocation();
        public JobLocation JobLocation
        {
            get { return _jobLocation; }
            set
            {
                Set(ref _jobLocation, value);
            }
        }

        private JobCategory _jobCategory = new JobCategory();
        public JobCategory JobCategory
        {
            get { return _jobCategory; }
            set
            {
                Set(ref _jobCategory, value);
            }
        }

        private JobQuota _jobQuota = new JobQuota();
        public JobQuota JobQuota
        {
            get { return _jobQuota; }
            set
            {
                Set(ref _jobQuota, value);
            }
        }

        private IList<JobOrder> _orders = new List<JobOrder>();
        public IList<JobOrder> Orders
        {
            get { return _orders; }
            set
            {
                Set(ref _orders, value);
            }
        }

        private String _basket;
        public String Basket
        {
            get { return _basket; }
            set
            {
                Set(ref _basket, value);
            }
        }

        private String _encounters;
        public String Encounters
        {
            get { return _encounters; }
            set
            {
                Set(ref _encounters, value);
            }
        }

        private String _time;
        public String Time
        {
            get { return _time; }
            set
            {
                Set(ref _time, value);
            }
        }

        private Ship _ship = new Ship();
        public Ship Ship
        {
            get { return _ship; }
            set
            {
                Set(ref _ship, value);
            }
        }

        private IList<String> _subordinates = new List<String>();
        public IList<String> Subordinates
        {
            get { return _subordinates; }
            set
            {
                Set(ref _subordinates, value);
            }
        }
    }
}
