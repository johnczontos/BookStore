using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
// https://christianfindlay.com/2020/09/11/inotifypropertychanged/

namespace BookStore.Model
{
    class Book : INotifyPropertyChanged
    {
        private long isbn;
        private string title;
        private string author;
        private int year;
        private string status;

        public long ISBN
        {
            get { return isbn; }
            set
            {
                isbn = value;
                OnPropertyChanged("ISBN");
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }
        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
