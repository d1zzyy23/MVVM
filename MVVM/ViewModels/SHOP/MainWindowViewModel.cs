using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.ViewModels.Admin;
using MVVM.Views.Admin;

namespace MVVM.ViewModels.SHOP;

public partial class MainWindowViewModel : ViewModelBase
{
    [RelayCommand]
    private void OpenAdmin()
    {
        var window = new AdminWindow()
        {
            DataContext = new AdminWindowViewModel()
        };
        window.Show();
    }
}