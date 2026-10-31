using Reni_Cafe.Commands;
using Reni_Cafe.Services;
using Reni_Cafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Reni_Cafe.ViewModels;

public class LoginViewModel : ViewModelBase
{
    private readonly INavigationService _navigation;

    public ICommand LoginCommand { get; }

    public LoginViewModel(INavigationService navigation)
    {
        _navigation = navigation;

        LoginCommand = new RelayCommand(
            () => _navigation.NavigateTo<DashboardViewModel>());
    }
}