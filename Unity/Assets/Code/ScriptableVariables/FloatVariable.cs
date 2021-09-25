using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(fileName = "NewFloatVar", menuName = "DataVariables/Float")]
    public sealed class FloatVariable : ScriptableObject, INotifyPropertyChanged
    {
        [SerializeField] private float value;
        [SerializeField] private double tolerance = 0.005;
        
        private float _value;
        public event PropertyChangedEventHandler PropertyChanged;

        public float Value
        {
            set
            {
                this.value = value; 
                OnValidate();
            }
            get => _value;
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnValidate()
        {
            if (Math.Abs(value - _value) < tolerance)
            {
                return;
            }
            
            _value = value;
            OnPropertyChanged(ToString());
        }
    }
}