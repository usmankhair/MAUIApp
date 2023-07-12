using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace App.Mobile.MAUI.ViewModel
{
    [QueryProperty("Text", "text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");

            //await Shell.Current.GoToAsync("../MainPage");
        }
    }
}