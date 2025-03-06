using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.ViewModels.Admin.DAM;
using MVVM.ViewModels.Admin.OMS;
using MVVM.ViewModels.Admin.PIM;
using MVVM.Views.Admin;
using MVVM.Views.Admin.PIM;

namespace MVVM.ViewModels.Admin;

public partial class AdminWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isPaneOpen = true;

    [ObservableProperty] 
    private ViewModelBase _currentViewModel;

    public AdminWindowViewModel()
    {
        CurrentViewModel = new DashboardViewModel();
    }
    
    [RelayCommand]
    private void TogglePane()
    {
        IsPaneOpen = !IsPaneOpen;
    }
    
    [RelayCommand]
    private void ChangeViewModel(string viewName)
    {
        switch (viewName)
        {
            case "Dashboard": 
                CurrentViewModel = new DashboardViewModel();
                break;
            case "PIM":
                CurrentViewModel = new PIMViewModel();
                break;
            case "OMS":
                CurrentViewModel = new OMSViewModel();
                break;
            case "DAM":
                CurrentViewModel = new DAMViewModel();
                break;
        }
    }
}