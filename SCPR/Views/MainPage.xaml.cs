using Microsoft.UI.Xaml.Controls;
using SCPR.ViewModels;

namespace SCPR.Views;

public sealed partial class MainPage : Page
{
    public static MainPage? Current;

    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        Current = this;
    }
}
