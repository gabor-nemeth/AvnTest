using Avalonia;
using Avalonia.Controls;
using AvnTest;

var builder = AvnAppBuilder.BuildApp();
builder.StartWithClassicDesktopLifetime(args, ShutdownMode.OnMainWindowClose);
