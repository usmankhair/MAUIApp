using System.Windows.Input;

namespace App.Mobile.MAUI.Pages;

public partial class OnDemandView : ContentPage
{
    public ICommand CreateCommand { get; private set; }

    public OnDemandView()
    {
        InitializeComponent();

        CreateCommand = new Command<Type>((Type viewType) =>
        {
            View view = (View)Activator.CreateInstance(viewType);
            view.VerticalOptions = LayoutOptions.Center;
            stackLayout.Add(view);
        });

        BindingContext = this;
    }
}