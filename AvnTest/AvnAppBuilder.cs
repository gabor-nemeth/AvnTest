using System;
using Avalonia;
using Avalonia.Dialogs;

namespace AvnTest
{
    public class AvnAppBuilder
    {
        public static AppBuilder BuildApp()
        {
            return AppBuilder.Configure<AvnApp>()
                .UsePlatformDetect()
                .UseSkia()
                .UseManagedSystemDialogs()
                .With(new MacOSPlatformOptions { ShowInDock = true})
                // .AfterSetup(builder =>
                // {
                //     builder.Instance!.AttachDevTools(new Avalonia.Diagnostics.DevToolsOptions() { StartupScreenIndex = 1, });
                // })
                .LogToTrace();
        }
    }
}
