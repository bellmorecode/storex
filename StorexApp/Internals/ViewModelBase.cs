using System.ComponentModel;

namespace StorexApp.Internals
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var action = PropertyChanged;
            if (action != null)
            {
                action(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
