using Commands;
using ScriptableVariables;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(menuName = "ViewModels/Test")]
    public sealed class TestViewModel : AbstractViewModel
    {
        [SerializeField] private FloatVariable floatReference;

        public float FloatRefValue => floatReference.Value;

        public override void Init()
        {
            floatReference.PropertyChanged += (sender, args) => { OnPropertyChanged(args.PropertyName); };
        }

        public Command Save()
        {
            return new Command((o) => { Debug.Log("DoSave"); },
                param => true);
        }
    }
}
