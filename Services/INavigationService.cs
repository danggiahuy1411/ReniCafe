using Reni_Cafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reni_Cafe.Services;

public interface INavigationService
{
    ViewModelBase? CurrentViewModel { get; }

    event Action? CurrentViewModelChanged;

    void NavigateTo<TViewModel>()
        where TViewModel : ViewModelBase;
}