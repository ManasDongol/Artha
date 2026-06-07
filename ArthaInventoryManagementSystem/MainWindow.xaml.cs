using System.Windows;
using ArthaInventoryManagementSystem.Pages;
using ArthaInventoryManagementSystem.ViewModels; // Make sure to include this

namespace ArthaInventoryManagementSystem;

public partial class MainWindow : Window
{
    private readonly NavigationViewModel _viewModel;

    // 1. DI passes the ViewModel straight into the window
    public MainWindow(NavigationViewModel viewModel,Services.NavigationService navigationService)
    {
        InitializeComponent();
        
        navigationService.Initialize(this.MainFrame);
        // 2. Assign the DataContext so bindings in XAML work globally across the window
        _viewModel = viewModel;
        this.DataContext = _viewModel;

        // 3. Set your default starting page
        MainFrame.Navigate(new Dashboard());
    }

    private void OpenProducts(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new Products());
    }

    private void OpenSongs(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new Songs());
    }
}