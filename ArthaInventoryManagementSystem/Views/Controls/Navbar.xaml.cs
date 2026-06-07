using System.Windows;
using System.Windows.Controls;
using ArthaInventoryManagementSystem.ViewModels;

namespace ArthaInventoryManagementSystem.Controls;

public partial class Navbar : UserControl
{
    // Scoped locally to access inside click methods
    private NavigationViewModel? _viewModel => DataContext as NavigationViewModel;

    // WPF can now call this without crashing!
    public Navbar()
    {
        InitializeComponent();
    }
    
    private void OpenProducts(object sender, RoutedEventArgs e)
    {
        // Safe navigation via the inherited DataContext
        _viewModel?.openProducts(); 
    }

    private void OpenSongs(object sender, RoutedEventArgs e)
    {
        _viewModel?.openSongs();
    }
    private void OpenDashboard(object sender, RoutedEventArgs e)
    {
        _viewModel?.openDashboard();
    }
    private void OpenBilling(object sender, RoutedEventArgs e)
    {
        _viewModel?.openBilling();
    }
}