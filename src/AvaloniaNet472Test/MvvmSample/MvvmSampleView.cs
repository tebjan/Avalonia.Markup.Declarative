using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Declarative;

namespace AvaloniaNet472Test.MvvmSample
{
    public class MvvmSampleView : ViewBase<MvvmSampleViewModel>
    {
        protected override void OnCreated()
        {
            ViewModel = new MvvmSampleViewModel();
        }

        protected override object Build(MvvmSampleViewModel vm) =>
            new StackPanel()
                .Children(
                    new TextBlock()
                        .Text(@vm.MyProperty),

                    new Button()
                        .Content("Execute Command")
                        .Command(new Binding(nameof(vm.MyCommand))) 
                        .CommandParameter(), //pass current data context (ViewModel) as command parameter

                    new TextBlock()
                        .Text(Bind(vm.Counter)), //we can't directly set int to string property yet via @binding notation

                    new Button()
                        .Content("Increment")
                        .Command(new Binding(nameof(vm.AddCommand)))
                );
    }
}