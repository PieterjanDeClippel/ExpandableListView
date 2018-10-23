using CustomListViewTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomListViewTest.ViewModels
{
    public class PersonVM : BindableObject
    {
        private Person person;
        public Person Person
        {
            get { return person; }
            set
            {
                person = value;
                OnPropertyChanged(nameof(Person));
            }
        }
    }
}
