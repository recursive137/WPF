using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModels
{
    public class CurrencyConverterViewModel : Notifier
    {
        #region BindableProperties
        private decimal euros;

        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }

        private decimal dollars;

        public decimal Dollars
        {
            get { return dollars; }
            set
            {
                dollars = value;
                OnPropertyChanged("Dollars");
            }
        }
        #endregion

        virtual protected void OnEurosChanged()
        {
            Dollars = Euros * 1.1M;
        }
    }
}
