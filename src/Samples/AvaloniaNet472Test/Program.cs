using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Declarative;

namespace AvaloniaNet472Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<Application>()
                .UsePlatformDetect()
                .UseFluentTheme()
                .StartWithClassicDesktopLifetime(desktop =>
                {
                    desktop.MainWindow =
                        new Window()
                            .Title("Avalonia markup samples")
                            .Content(new MainView());
                }, args);
        }
    }
}
