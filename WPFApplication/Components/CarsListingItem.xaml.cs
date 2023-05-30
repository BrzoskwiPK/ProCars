using System.Windows;
using System.Windows.Controls;

namespace WPFApplication.Components
{
    /// <summary>
    /// Logika interakcji dla klasy CarsListingItem.xaml
    /// </summary>
    public partial class CarsListingItem : UserControl
    {
        public CarsListingItem()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dropdown.IsOpen = false;
        }
    }
}
