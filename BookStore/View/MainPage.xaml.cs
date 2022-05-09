using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using BookStore.ViewModel;
using BookStore.Model;

namespace BookStore.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // AddBook(txtISBN, txtTitle, txtAuthor, txtYear, txtStatus);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (BookGrid.SelectedIndex == -1)
            {
                return;
            }
            // BookGrid.Items.Remove(BookGrid.SelectedItem);

            BookViewModel dc = (BookViewModel)App.Current.MainWindow.DataContext;
            dc.RemoveBook((Book)BookGrid.SelectedItem);
        }
    }
}
