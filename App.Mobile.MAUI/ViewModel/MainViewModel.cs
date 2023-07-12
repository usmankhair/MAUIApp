using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using App.Mobile.MAUI.Pages;

namespace App.Mobile.MAUI.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity Connectivity;
        public MainViewModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<string>();
            Connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            if(Connectivity.NetworkAccess!= NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Uh oh!", "No Internet", "OK");
            }

            Items.Add(Text);
            // add new item
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s) 
        {
            if(Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Detail(string s)
        {
            // A query string passing
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?text={s}");

            // complex data object passing
            //await Shell.Current.GoToAsync($"{nameof(DetailPage)}",
            //    new Dictionary<string, object>
            //    {
            //        { nameof(DetailPage), new object()},
            //    });
        }
    }

    // Without ObservableObject, custom implementation

    public class MainViewModel1 : INotifyPropertyChanged
    {
        string text;

        public string Text
        {
            get => text;
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
