using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinImport_GUI_.Model.DateAndTime
{
    class DateModel : Utilities.ViewModelBase
    {
        #region Properties
        private string? _cityName;
        public string? Name
        {
            get { return _cityName; }
            set { _cityName = value; OnPropertyChanged(); }
        }

        private int _day;
        public int Day
        {
            get { return _day; }
            set { _day = value; OnPropertyChanged(); }
        }

        private int _month;
        public int Month
        {
            get { return _month; }
            set { _month = value; OnPropertyChanged(); }
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; OnPropertyChanged(); }
        }

        #endregion

        #region Cunstructor
        public DateModel()
        {
            DateTime dateTime = DateTime.Now;

            this.Day = dateTime.Day;
            this.Month = dateTime.Month;
            this.Year = dateTime.Year;

        }

        #endregion


    }
}
