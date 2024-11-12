using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApp3
{
    public partial class category : Page
    {
        LibiraryEntities libiraryEntities = new LibiraryEntities();
        public category()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var selectedItem = Listone.SelectedItem as ListBoxItem;

            if (Listone.SelectedItem is ListBoxItem selectedItem)
            {
               
                string categoryName = selectedItem.Content.ToString();
               
                broswexaml bro = new broswexaml(categoryName);

                this.NavigationService.Navigate(bro);
                
            }
            else
            {
          
                MessageBox.Show("Please select a category.");
            }
        }
    }
}
