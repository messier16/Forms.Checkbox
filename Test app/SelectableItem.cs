using System.ComponentModel;

namespace CheckboxTestApp
{
    public class SelectableItem : INotifyPropertyChanged
    {
        private string _text;

        public string Text
        {
            get { return _text; } 
            set { _text = value;  RaiseChange("Text");}
        }

        private bool _isChecked;

        public bool IsChecked
        {
            get { return _isChecked; } 
            set { _isChecked = value; RaiseChange("IsChecked"); }
        }

        private bool _isSelectable;

        public bool IsSelectable
        {
            get { return _isSelectable; } 
            set { _isSelectable = value; RaiseChange("IsSelectable"); }
        }

        private bool _isVisible;

        public bool IsVisible
        {
            get { return _isVisible; } 
            set { _isVisible = value; RaiseChange("IsVisible"); }
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


