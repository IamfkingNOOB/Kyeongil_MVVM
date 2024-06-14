using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using ViewModel.Extensions;

public class TopLeftUI : MonoBehaviour
{
    // UIs
    [SerializeField] private Text Text_Name;
    [SerializeField] private Text Text_Level;
    [SerializeField] Image Image_Icon;

    // View Model을 들고 있게 됩니다.
    private TopLeftViewModel _vm;

    private void OnEnable()
    {
        if (_vm == null)
        {
            _vm = new TopLeftViewModel();

            _vm.PropertyChanged += OnPropertyChanged;
            _vm.RegisterEventsOnEnable();
            _vm.RefreshViewModel();
        }
    }

    private void OnDisable()
    {
        if (_vm != null)
        {
            _vm.UnRegisterEventsOnDisable();
            _vm.PropertyChanged -= OnPropertyChanged;
            _vm = null;
        }
    }

    private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(_vm.Name):
                Text_Name.text = _vm.Name;
                break;

            case nameof(_vm.Level):
                Text_Level.text = $"{_vm.Level}";
                break;

            case nameof(_vm.IconName):
                break;
        }
    }

}
