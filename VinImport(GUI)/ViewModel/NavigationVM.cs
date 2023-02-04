using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VinImport_GUI_.Utilities;

namespace VinImport_GUI_.ViewModel
{
    internal class NavigationVM : Utilities.ViewModelBase
    {
        #region Properties
        private object _currentView = new HomeVM();
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        private static string _totalCartItems = "0";
        public string TotalCartItems
        {
            get
            {
                return _totalCartItems;
            }
            set
            {
                _totalCartItems = value;
                OnPropertyChanged("TotalCartItems");
            }
        }
        #endregion

        #region ICommands
        public ICommand HomeCommand { get; set; }
        public ICommand ProductsCommand { get; set; }

        #endregion

        #region CommandsFunction
        private void Home(Object obj) => CurrentView = new HomeVM();
        private void Product(Object obj) => CurrentView = new ProductsVM();

        #endregion

        #region Constructor
        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            ProductsCommand = new RelayCommand(Product);


            //Startup Page
            this.CurrentView = new HomeVM();
        }
        #endregion
    }
}
