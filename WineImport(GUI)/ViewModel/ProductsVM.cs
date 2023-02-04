using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineImport_GUI_.Model;

namespace WineImport_GUI_.ViewModel
{
    internal class ProductsVM : Utilities.ViewModelBase
    {
		private DatabaseModel _stock;
		public DatabaseModel Stock
		{
			get { return _stock; }
			set { _stock = value; OnPropertyChanged(); }
		}

		public ProductsVM()
		{
			_stock = new DatabaseModel();

        }

	}
}
