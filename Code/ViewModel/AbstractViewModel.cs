using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace hMvvm.ViewModel
{
    [CreateAssetMenu(fileName = "NewModel", menuName = "hMvvm/Model")]
    public abstract class AbstractViewModel : ScriptableObject, INotifyPropertyChanged
    {
        public abstract void Init();
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}