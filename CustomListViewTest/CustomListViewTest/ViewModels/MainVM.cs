using CustomListViewTest.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CustomListViewTest.ViewModels
{
    public class MainVM : BindableObject
    {
        private ObservableCollection<Expandable<Person>> people = new ObservableCollection<Expandable<Person>>();
        public ObservableCollection<Expandable<Person>> People
        {
            get { return people; }
            set
            {
                people = value;
                OnPropertyChanged(nameof(People));
            }
        }
    }
}
