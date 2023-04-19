using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using SCPR.ViewModels;

namespace SCPR.Views;

[ObservableObject]
public sealed partial class CircleOfFifthsPage : Page
{
    [ObservableProperty]
    private int keyIndex = 0;

    public CircleOfFifthsPage()
    {
        ViewModel = App.GetService<CircleOfFifthsViewModel>();
        this.InitializeComponent();
    }

    public CircleOfFifthsViewModel ViewModel { get; } = new();

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
//        canvas1.Draw += DrawCofFOutline;  - REMOVED
    }

    private void keyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        KeyIndex = keyComboBox.SelectedIndex;
        //        CircleOfFifthsViewModel.DrawCircleOfFifths(sender, e, keyIndex);  - REMOVED
        CircleOfFifthsViewModel.ChangeDegrees(KeyIndex);
    }
}
