using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace CheckboxTestApp
{
    public class DummyViewModel : INotifyPropertyChanged
    {
        public DummyViewModel()
        {
            var items = Enumerable.Range(0, 30)
                .Select(i => new SelectableItem { 
                    Text = "Item " + i,
                    IsVisible = true,
                    IsSelectable = i % 2 == 0,
                    IsChecked = i % 3 == 0
                });
            Items = new ObservableCollection<SelectableItem>(items);
        }

        private bool _check1;

        public bool Check1
        {
            get { return _check1; } 
            set { _check1 = value; RaiseChange("Check1"); }
        }

        private bool _check2;

        public bool Check2
        {
            get { return _check2; } 
            set { _check2 = value; RaiseChange("Check2"); }
        }

        private ObservableCollection<SelectableItem> _items;

        public ObservableCollection<SelectableItem> Items
        {
            get { return _items; } 
            set { _items = value; RaiseChange("Items"); }
        }

        private void RaiseChange(string propertyName = null)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}


