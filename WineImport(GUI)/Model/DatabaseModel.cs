using System.Collections.ObjectModel;
using WineImport_GUI_.DVIService;

namespace WineImport_GUI_.Model
{
    public class DatabaseModel : Utilities.ViewModelBase
    {
        #region Properties

        private string _outDoorHumidity;

        public string OutDoorHumidity
        {
            get { return _outDoorHumidity; }
            set
            {
                _outDoorHumidity = value;
                OnPropertyChanged();
            }
        }

        private string _outdoorTemp;

        public string OutdoorTemp
        {
            get { return _outdoorTemp; }
            set
            {
                _outdoorTemp = value;
                OnPropertyChanged();
            }
        }

        private string _stockTemp;

        public string StockTemp
        {
            get { return _stockTemp; }
            set
            {
                _stockTemp = value;
                OnPropertyChanged();
            }
        }

        private string _stockHumidity;

        public string StockHumidity
        {
            get { return _stockHumidity; }
            set
            {
                _stockHumidity = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _stockItemsUnderMin;

        public ObservableCollection<string> StockItemsUnderMin
        {
            get { return _stockItemsUnderMin; }
            set
            {
                StockItemsUnderMin = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<string> _stockItemsOverMax;

        public ObservableCollection<string> StockItemsOverMax
        {
            get { return _stockItemsUnderMin; }
            set
            {
                _stockItemsOverMax = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<string> _stockItemsMostSold;

        public ObservableCollection<string> StockItemsMostSold
        {
            get { return _stockItemsUnderMin; }
            set
            {
                _stockItemsMostSold = value;
                OnPropertyChanged();
            }
        }

        #endregion
        
        #region Constructor

        public DatabaseModel()
        {
            DVIService.monitorSoapClient ds = new monitorSoapClient();
            this._outDoorHumidity = ds.OutdoorHumidity().ToString();
            this._outdoorTemp = ds.OutdoorTemp().ToString();
            this._stockTemp = ds.StockTemp().ToString();
            this._stockHumidity = ds.StockHumidity().ToString();

            #region List Filling

            this._stockItemsUnderMin = new ObservableCollection<string>();

            foreach (var item in ds.StockItemsUnderMin())
            {
                this._stockItemsUnderMin.Add(item);
            }

            this._stockItemsOverMax = new ObservableCollection<string>();
            foreach (var item in ds.StockItemsUnderMin())
            {
                this._stockItemsOverMax.Add(item);
            }

            this._stockItemsMostSold = new ObservableCollection<string>();
            foreach (var item in ds.StockItemsUnderMin())
            {
                this._stockItemsMostSold.Add(item);
            }

            #endregion
        }

        #endregion
    }
}