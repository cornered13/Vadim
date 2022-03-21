using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Data;

namespace MVVM1.DA
{
    internal class PersonViewModel : DependencyObject
    {


        public string FilterText    
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        public static readonly DependencyProperty FilterTextProperty
            =
            DependencyProperty.Register("FilterText ", typeof(string), typeof(PersonViewModel), new PropertyMetadata(""));


        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(PersonViewModel), new PropertyMetadata(null));

        public PersonViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Person.GetPersons());
        }

    }
}
