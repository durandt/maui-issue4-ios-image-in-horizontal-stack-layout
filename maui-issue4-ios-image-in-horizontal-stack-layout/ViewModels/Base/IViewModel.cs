using System;
namespace maui_issue4_ios_image_in_horizontal_stack_layout.ViewModels.Base;

public interface IViewModel
{
    public bool IsInitialized { get; set; }
    public bool IsBusy { get; }

    Task InitializeAsync();
}

