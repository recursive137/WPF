using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WpfApplication1.DataBind;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Car> cars = new List<Car>();
            string[] carNames = new string[] { "Ferrari", "Mercedes", "Fiat", "Opel", "Hyundai", "KIA", "Ford", "BMW", "Renault", "Mazda", "Honda" };

            for (int i = 0; i < 11; i++)
            {
                cars.Add(new Car() { CarName=carNames[i], Speed=(i+1)*10});
            }
            this.DataContext = cars;
        }
    }
}
