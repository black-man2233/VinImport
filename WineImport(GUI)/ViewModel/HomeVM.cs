using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineImport_GUI_.Model.DateAndTime;

namespace WineImport_GUI_.ViewModel
{
    internal class HomeVM : Utilities.ViewModelBase
    {
        private DateModel _date;
        public DateModel Date
        {
            get => _date;
            set { _date = value; OnPropertyChanged(); }
        }

        private string _userName;

        public string UserName
        {
            get => this._userName;
            set { _userName = value; OnPropertyChanged(); }
        }

        public HomeVM()
        {
            _date = new DateModel();
            _userName = "Kevin Bamwesa";
        }
    }
}
