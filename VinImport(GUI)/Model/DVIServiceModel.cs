using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VinImport_GUI_.Model
{
    public class DVIServiceModel : Utilities.ViewModelBase
    {

        private string _stockTemp;
        public string StockTemp
        {
            get
            {
                try
                {
                    return _stockTemp;

                }
                catch (Exception)
                {
                    return ("N/A");
                }
            }
            set { _stockTemp = value; OnPropertyChanged(); }
        }


        public DVIServiceModel()
        {
            //ServiceReference1.monitorSoapClient ds;

            //_stockTemp = ds.StockTempAsync();


        }

    }


}


