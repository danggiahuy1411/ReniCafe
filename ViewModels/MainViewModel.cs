using Reni_Cafe.Services;
using System;
using System.Collections.Generic;
using System.Text;
namespace Reni_Cafe.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly INavigationService _navigation;

    public ViewModelBase? CurrentViewModel =>
        _navigation.CurrentViewModel;

    public MainViewModel(INavigationService navigation)
    {
        _navigation = navigation;

        _navigation.CurrentViewModelChanged +=
            () => OnPropertyChanged(nameof(CurrentViewModel));

        _navigation.NavigateTo<LoginViewModel>();
    }
}