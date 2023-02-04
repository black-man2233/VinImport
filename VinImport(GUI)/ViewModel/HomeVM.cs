using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinImport_GUI_.Model.DateAndTime;

namespace VinImport_GUI_.ViewModel
{
    internal class HomeVM:Utilities.ViewModelBase
    {
		private DateModel _date;
		public DateModel Date
		{
			get { return _date; }
			set { _date = value; OnPropertyChanged(); }
		}

		private string _userName;

		public string UserName
		{
			get { return _userName; }
			set { _userName = value;OnPropertyChanged(); }
		}



		public HomeVM()
		{
			_date = new DateModel();
			_userName = "Kevin Bamwesa";

		}

	}
}
