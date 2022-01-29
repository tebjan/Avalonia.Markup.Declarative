using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace AvaloniaNet472Test.MvvmSample
{
    public class MvvmSampleViewModel : INotifyPropertyChanged
    {
        private string _myProperty;
        private int _counter;

        public string MyProperty
        {
            get => _myProperty;
            set
            {
                if (_myProperty != value)
                {
                    _myProperty = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                OnPropertyChanged();
            }
        }

        public void MyCommand(object commandParameter)
        {
            MyProperty = $"You called command with parameter: {commandParameter}";
        }
        public void AddCommand()
        {
            Counter++;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}