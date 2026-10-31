using Microsoft.Extensions.DependencyInjection;
using Reni_Cafe.Services;
using Reni_Cafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reni_Cafe.Services;

public class NavigationService : INavigationService
{
    private readonly IServiceProvider _provider;

    public ViewModelBase? CurrentViewModel { get; private set; }

    public event Action? CurrentViewModelChanged;

    public NavigationService(IServiceProvider provider)
    {
        _provider = provider;
    }

    public void NavigateTo<TViewModel>()
        where TViewModel : ViewModelBase
    {
        CurrentViewModel =
            _provider.GetRequiredService<TViewModel>();

        CurrentViewModelChanged?.Invoke();
    }
}