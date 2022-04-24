using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Media;
using Avalonia.Platform;

namespace AvnTest;

public class AvnApp : Application
{
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
        {
            desktopLifetime.MainWindow = new MainWindow();
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewLifetime)
        {
            singleViewLifetime.MainView = new MainView();
        }

        base.OnFrameworkInitializationCompleted();
    }    
}

class MainWindow : Window
{
    public MainWindow()
    {
        Renderer.DrawFps = true;
        Width = 640;
        Height = 480;
        Background = Brushes.Green;
        TransparencyLevelHint = WindowTransparencyLevel.None;
        Title = "Main Window";
        WindowState = WindowState.Normal;
        
        Content = new Button
        {
            Content = "Click Me!"
        };
        
        DebugOutput();
    }

    public void DebugOutput()
    {
        Console.WriteLine($"TransparencyLevelHint = {TransparencyLevelHint}");
        Console.WriteLine($"ExtendClientAreaChromeHints = {ExtendClientAreaChromeHints}");
        Console.WriteLine($"ExtendClientAreaToDecorationsHint = {ExtendClientAreaToDecorationsHint}");
        Console.WriteLine($"Background opacity = {Background?.Opacity}");
    }
}

class MainView : UserControl
{
    public MainView()
    {
        Background = new SolidColorBrush(Colors.Red);
    }
}
