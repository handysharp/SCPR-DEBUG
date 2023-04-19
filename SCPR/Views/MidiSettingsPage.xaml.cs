using SCPR.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using Windows.Devices.Midi;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;
using Microsoft.UI.Xaml;
using static SCPR.Views.MainPage;
using Windows.UI.Notifications;

using Microsoft.UI;
using Microsoft.UI.Dispatching;
using Windows.ApplicationModel.Activation;
using static SCPR.ViewModels.MidiSettingsViewModel;
using System.Text;

namespace SCPR.Views;

// An empty page that can be used on its own or navigated to within a Frame.
public sealed partial class MidiSettingsPage : Page
{
    // From the template
    public MidiSettingsViewModel ViewModel { get; } = new();

// Main Page    
    private MainPage rootPage;

    public MidiSettingsPage()
    {
        ViewModel = App.GetService<MidiSettingsViewModel>();
        this.InitializeComponent();
    }

    // Set the rootpage context when entering the scenario
    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        rootPage = MainPage.Current;
    }

    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
        base.OnNavigatedFrom(e);
    }
}