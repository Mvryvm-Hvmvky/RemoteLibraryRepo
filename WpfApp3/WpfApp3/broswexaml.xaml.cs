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
using System.Data.Entity.Migrations;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for broswexaml.xaml
    /// </summary>
    public partial class broswexaml : Page
    {
        LibiraryEntities db = new LibiraryEntities();

        public string cate;

        public broswexaml(string cat)
        {
            cate = cat;
            InitializeComponent();
            showentity(cat);


        }
        void showentity(string category)
        {

            var ID = db.Categories.Where(x => x.catergoryName == category).Select(x => x.categoryID).FirstOrDefault();

            DGlibirary.ItemsSource = db.Books.Where(z =>  z.categoryID == ID).Select(x => new { x.bookID,  x.bookName, x.authorName ,x.categoryID  }).ToList();

        }


        private void Add_butt_Click(object sender, RoutedEventArgs e)
        {

            Book book = new Book();

            book.bookID = int.Parse(IDtxt.Text);
            book.bookName = Namext.Text;
            book.authorName = authertxt.Text;
            book.categoryID = int.Parse(catIDtxt.Text);

            db.Books.Add(book);
            db.SaveChanges();
            showentity(cate);

        }

        private void Update_butt_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            int id = int.Parse(IDtxt.Text);

            book = db.Books.First(x => x.bookID == id);
            book.bookName = Namext.Text;
            book.authorName = authertxt.Text;
            book.categoryID = int.Parse(catIDtxt.Text);

            db.Books.AddOrUpdate(book);
            db.SaveChanges();
            showentity(cate);

        }

        private void Delete_butt(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            int id = int.Parse(IDtxt.Text);

            book = db.Books.Remove(db.Books.First(x => x.bookID == id));

            db.SaveChanges();
            showentity(cate);

        }

        private void Search_butt(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            string Search = searchtxt.Text;

            DGlibirary.ItemsSource = db.Books.Where(x => x.bookName == Search).Select(x => new { x.bookID, x.bookName, x.authorName, x.categoryID }).ToList();

            db.SaveChanges();
            
        }
    }
}
