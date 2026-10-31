using Reni_Cafe.Commands;
using Reni_Cafe.Services;
using Reni_Cafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Reni_Cafe.ViewModels;

public class DashboardViewModel : ViewModelBase
{
    private readonly INavigationService _navigation;

    public string Title => "Dashboard";

    public ICommand LogoutCommand { get; }

    public DashboardViewModel(INavigationService navigation)
    {
        _navigation = navigation;

        LogoutCommand = new RelayCommand(
            () => _navigation.NavigateTo<LoginViewModel>());
    }
}