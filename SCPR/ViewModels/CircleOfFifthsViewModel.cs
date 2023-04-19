using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Graphics.Canvas.UI.Xaml;

namespace SCPR.ViewModels;

public partial class CircleOfFifthsViewModel : ObservableRecipient
{
    public static string[] Tonic = new string[] { "C", "G", "D", "A", "E", "B", "F#", "Db", "Ab", "Eb", "Bb", "F" };
    public static string[] Minor2 = new string[] { "Dm", "Am", "Em", "Bm", "F#m", "Dbm", "Abm", "Ebm", "Bbm", "Fm", "Cm", "Gm" };

    [ObservableProperty]
    private int keyIndex = 0;

    [ObservableProperty]
    private string note1 = "C";

    [ObservableProperty]
    private string note2 = "D";

    public CircleOfFifthsViewModel()
    {
    }

    public static void ChangeDegrees(int keyIndex)
    {
        var ViewModel = new CircleOfFifthsViewModel();
        ViewModel.Note1 = Tonic[keyIndex];
        ViewModel.Note2 = Minor2[keyIndex];
    }
}