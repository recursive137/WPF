using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Model;

namespace WpfApplication1.ViewModels
{
    public class CurrencyConverterMoreComplexViewModel : CurrencyConverterViewModel
    {
        private decimal converted;

        public decimal Converted
        {
            get { return converted; }
            set
            {
                converted = value;
                OnPropertyChanged("Converted");
            }
        }

        private Currency selectedCurrency;

        public Currency SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
                OnSelectedCurrencyChanged();
            }
        }

        private IEnumerable<Currency> currencies;

        public IEnumerable<Currency> Currencies
        {
            get { return currencies; }
            set
            {
                currencies = value;
                OnPropertyChanged("Currencies");
            }
        }

        private string resultText;

        public string ResultText
        {
            get { return resultText; }
            set
            {
                resultText = value;
                OnPropertyChanged("ResultText");
            }
        }

        public CurrencyConverterMoreComplexViewModel()
        {
            Currencies = new Currency[] {
                new Currency("US Dollar", 1.1M),
                new Currency("British Pound", 0.9M)
            };
        }

        void OnSelectedCurrencyChanged()
        {
            ComputeConverted();
        }

        void ComputeConverted()
        {
            if (SelectedCurrency == null)
            {
                return;
            }
            Converted = Euros * SelectedCurrency.Rate;
            ResultText = string.Format("Amount in {0}", SelectedCurrency.Title);
        }

        protected override void OnEurosChanged()
        {
            //base.OnEurosChanged();
            ComputeConverted();
        }
    }
}
