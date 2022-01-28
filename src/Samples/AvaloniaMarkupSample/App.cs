//this line is required to support Net 6 hot reload for Views

using AvaloniaMarkupSample;
using System;

using System.Reactive.Linq;

using Avalonia;

using Avalonia.Controls;

using Avalonia.Controls.ApplicationLifetimes;

using Avalonia.Data;

using Avalonia.Interactivity;

using Avalonia.Themes.Fluent;

using Avalonia.Markup.Declarative;

using Avalonia.Layout;

using Avalonia.Media;



//[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(Avalonia.Markup.Declarative.HotReloadManager))]

AppBuilder
    .Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop =>
    {
        desktop.MainWindow =
            new Window()
                .Title("Avalonia markup samples")
                .Content(new MainView());
    }, args);