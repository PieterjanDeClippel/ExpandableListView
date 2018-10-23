using CustomListViewTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomListViewTest.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void omiAdd_Clicked(object sender, EventArgs e)
        {
            viewModel.People.Add(new Expandable<Entities.Person>(new Entities.Person { FirstName = "Pieterjan", LastName = "De Clippel" }));
            viewModel.People.Add(new Expandable<Entities.Person>(new Entities.Person { FirstName = "Siel", LastName = "Vansteenbrugge" }));
        }

        private void omiToggle_Clicked(object sender, EventArgs e)
        {
            //viewModel.IsExpanded = !viewModel.IsExpanded;
        }

        Expandable<Entities.Person> old;
        private void lvPeople_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (Expandable<Entities.Person>)e.Item;

            // hide the previous item
            if (old != null) old.IsVisible = false;

            if (old == item)
            {
                old = null;
            }
            else
            {
                // toggle the tapped item
                item.IsVisible = !item.IsVisible;
                old = item;
            }
        }
    }
}
