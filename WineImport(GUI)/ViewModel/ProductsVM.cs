using WineImport_GUI_.Model;

namespace WineImport_GUI_.ViewModel
{
    internal class ProductsVM : Utilities.ViewModelBase
    {
        private DatabaseModel _stock;

        public DatabaseModel Stocks
        {
            get => this._stock;
            set
            {
                _stock = value;
                OnPropertyChanged();
            }
        }

        public ProductsVM()
        {
            _stock = NavigationVM.StockItems;
        }
    }
}