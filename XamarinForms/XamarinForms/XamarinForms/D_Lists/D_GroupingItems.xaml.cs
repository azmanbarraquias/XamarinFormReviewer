using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.D_Lists.Models;

namespace XamarinForms.D_Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class D_GroupingItems : ContentPage
    {
        public D_GroupingItems()
        {
            InitializeComponent();
            PopulateListOfConstact();
        }

        public void PopulateListOfConstact()
        {
            contactListView.ItemsSource = new List<ContactGroup>()
            {
                new ContactGroup("A", "A")
                {
                    new Contact { Name = "Azman", ImageURL ="https://i.picsum.photos/id/1/100/100.jpg", Status = Status.Offline},
                    new Contact { Name = "Arron", ImageURL ="https://i.picsum.photos/id/16/100/100.jpg", Status = Status.Online}
                },

                new ContactGroup("B", "B")
                {
                    new Contact { Name = "Batman", ImageURL ="https://i.picsum.photos/id/2/100/100.jpg", Status = Status.Busy},
                    new Contact { Name = "Barraquias", ImageURL ="https://i.picsum.photos/id/23/100/100.jpg", Status = Status.Away}
                },

                new ContactGroup("S", "S")
                {
                    new Contact { Name = "Superman", ImageURL ="http://lorempixel.com/100/100/people/1/", Status = Status.Online},

                },

                new ContactGroup("J", "J")
                {
                    new Contact { Name = "Jazzman", ImageURL ="http://lorempixel.com/100/100/people/2/", Status = Status.Away},
                },

                new ContactGroup("X", "X")
                {
                    // XXX
                }
            };
        }
    }
}