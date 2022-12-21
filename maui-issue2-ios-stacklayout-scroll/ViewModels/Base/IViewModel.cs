using System;
namespace maui_issue2_ios_stacklayout_scroll.ViewModels.Base;

public interface IViewModel
{
    public bool IsInitialized { get; set; }
    public bool IsBusy { get; }

    Task InitializeAsync();
}

