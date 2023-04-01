using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WineImport_GUI_.Model;
using WineImport_GUI_.Utilities;

namespace WineImport_GUI_.ViewModel
{
    internal class NavigationVM : Utilities.ViewModelBase
    {
        #region Properties

        private object _currentView = new HomeVM();

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public static DatabaseModel StockItems = new DatabaseModel();

        #endregion

        #region ICommands

        public ICommand HomeCommand { get; }
        public ICommand ProductsCommand { get; }

        #endregion

        #region Commands Functions

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