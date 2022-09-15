using Microsoft.UI.Xaml.Controls;

using Project_Lavender.ViewModels;

namespace Project_Lavender.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
