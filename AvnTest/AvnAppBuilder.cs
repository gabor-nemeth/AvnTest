using System;
using System.Reflection;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Dialogs;
using Avalonia.Themes.Fluent;

namespace AvnTest
{
    public static class AvnAppBuilder
    {
        public static AppBuilder BuildApp()
        {
            return AppBuilder.Configure<AvnApp>()
                .UsePlatformDetect()
                .UseFluentTheme()
                .UseSkia()
                .UseManagedSystemDialogs()
                .With(new MacOSPlatformOptions { ShowInDock = true})
                // .AfterSetup(builder =>
                // {
                //     builder.Instance!.AttachDevTools(new Avalonia.Diagnostics.DevToolsOptions() { StartupScreenIndex = 1, });
                // })
                .LogToTrace();
        }

        public static TAppBuilder UseFluentTheme<TAppBuilder>(this TAppBuilder builder, FluentThemeMode mode = FluentThemeMode.Light)
            where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
        {
            return builder.AfterSetup(_ => builder.Instance.Styles.Add(new FluentTheme(new Uri($"avares://{Assembly.GetExecutingAssembly().GetName()}")) { Mode = mode }));
        }
    }
}
