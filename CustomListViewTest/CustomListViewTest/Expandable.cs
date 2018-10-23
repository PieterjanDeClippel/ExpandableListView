using CustomListViewTest.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CustomListViewTest
{
    public class Expandable<T> : BindableObject
    {
        public Expandable(T item)
        {
            this.item = item;
        }

        private T item;
        public T Item
        {
            get { return item; }
        }

        private bool isVisible;
        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }
    }
}
