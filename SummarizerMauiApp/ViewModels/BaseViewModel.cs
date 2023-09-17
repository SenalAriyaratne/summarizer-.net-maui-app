
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SummarizerMauiApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public BaseViewModel() { }

        public event PropertyChangedEventHandler PropertyChanged;

     
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        bool _stateisbusy;
        public bool StateIsBusy
        {
            get => _stateisbusy;
            set
            {
                _stateisbusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(StateIsNotBusy));
            }
        }

        public bool StateIsNotBusy => !StateIsBusy;

        string _pagetitle;
        public string PageTitle
        {
            get => _pagetitle;
            set
            {
                if(_pagetitle != value)
                {
                    _pagetitle = value;
                    OnPropertyChanged();
                }
               
            }
        }


    }
}
