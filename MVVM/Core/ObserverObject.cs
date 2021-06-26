using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WimeraSampleProject.MVVM.Core
{
    public class ObservarObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
