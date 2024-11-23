using System.ComponentModel;

namespace Todoo.Core
{
    public class Observable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string nazwa)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nazwa));
        }

            
    }
}
