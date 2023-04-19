using SCPR.ViewModels;
using SCPR.Views;

using Microsoft.UI.Dispatching;
using Windows.UI.Core;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using Windows.UI.Notifications;

using Windows.Devices.Midi;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;

using static SCPR.Views.MainPage;
using static SCPR.Views.MidiSettingsPage;
using static SCPR.ViewModels.MidiSettingsViewModel;
using System.ComponentModel;

namespace SCPR.ViewModels;

// This class needs to be a partial for the CTK.MVVM's generator ***************
public partial class MidiSettingsViewModel : ObservableRecipient
{
    public MidiSettingsViewModel()
    {
    }

// CTK.MVVM will generate StatusBarColor
    [ObservableProperty]
    private SolidColorBrush statusBarColor;

// CTK.MVVM will generate StatusBarText
    [ObservableProperty]
    private string statusBarText;


    // Display a message to the user. This method may be called from any thread.
    public void NotifyUser(string strMessage, NotifyType type, DispatcherQueue dispatcher)
    {
        // ************************* CHECK IF THE DISPATCHER COMMANDS WORK IN WINUI 3 *********************************
//        var dispatcher = Microsoft.UI.Dispatching.DispatcherQueue.GetForCurrentThread();

        if (dispatcher.HasThreadAccess)
        {
            UpdateStatus(strMessage, type);
        }
        else
        {
            var task = dispatcher.TryEnqueue(DispatcherQueuePriority.Normal, () => UpdateStatus(strMessage, type));
        }
    }

    public void UpdateStatus(string strMessage, NotifyType type)
    {
        StatusBarText = strMessage;
        switch (type)
        {
            case NotifyType.StatusMessage:
                StatusBarColor = new SolidColorBrush(Colors.Green);
                break;
            case NotifyType.ErrorMessage:
                StatusBarColor = new SolidColorBrush(Colors.Red);
                break;
        }
    }

    public enum NotifyType
    {
        StatusMessage,
        ErrorMessage
    };
}