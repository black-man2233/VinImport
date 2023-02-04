using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinImport_GUI_.Model;

namespace VinImport_GUI_.ViewModel
{
    class ProductsVM : Utilities.ViewModelBase
    {
		DVIServiceModel db = new();

		private string _stockTemp;

		public string StockTemp
		{
			get { return db.StockTemp; }
			set { _stockTemp = value; }
		}


	}
}
