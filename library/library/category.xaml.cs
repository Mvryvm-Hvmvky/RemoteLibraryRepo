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

namespace library
{
    /// <summary>
    /// Interaction logic for category.xaml
    /// </summary>
    public partial class category : Page
    {
        LibraryDBEntities db=new LibraryDBEntities();
        public category()
        {
            InitializeComponent();
            dg.ItemsSource = db.Books.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            dg.ItemsSource=db.Books.Where(x=>x.bookName==stxt.Text).ToList();
        }
    }
}
