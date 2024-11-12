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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Welocme.xaml
    /// </summary>
    public partial class Welocme : Page
    {
        public Welocme()
        {
            InitializeComponent();
        }

        private void navbtn(object sender, RoutedEventArgs e)
        {
            category cat =  new category();
            NavigationService.Navigate(cat);
        }
    }
}
