using System.ComponentModel;
using System.Globalization;
using RSG;
using TMPro;
using UnityEngine;
using ViewModel;

namespace View
{
    public class TestView : AbstractView
    {
        [SerializeField] private TestViewModel viewModel;
        [SerializeField] private TextMeshProUGUI floatTextField;

        private void Awake()
        {
            viewModel.PropertyChanged += ViewModelOnPropertyChanged;
            viewModel.Init();
            SetData();
        }

        private void ViewModelOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SetData();
        }

        public void Save()
        {
            if (viewModel.Save().CanExecute(string.Empty))
            {
                viewModel.Save().Execute(string.Empty);
            }
        }

        private void SetData()
        {
            floatTextField.text = viewModel.FloatRefValue.ToString(CultureInfo.InvariantCulture);
        }

        protected override IPromise AnimateOn()
        {
            return Promise.Resolved();
        }

        protected override IPromise AnimateOff()
        {
            return Promise.Resolved();
        }
    }
}
