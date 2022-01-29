using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using AvaloniaNet472Test.MvvmSample;

namespace AvaloniaNet472Test
{
    public class MainView : ViewBase
    {
        protected override object Build() =>
            new Border()
                .BorderBrush(Brushes.Gray)
                .BorderThickness(1)
                .Child(
                    new StackPanel()
                        .Children(

                            new TextBlock()
                                .Padding(12)
                                .FontSize(30)
                                .HorizontalAlignment(HorizontalAlignment.Center)
                                .Text("Hello darkness my old friend!"),

                            new MvvmSampleView()
                        )
                );
    }
}