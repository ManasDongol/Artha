using System.Windows;
using System.Windows.Controls;
using ArthaInventoryManagementSystem.ViewModels;
using Microsoft.Extensions.Logging;

namespace ArthaInventoryManagementSystem.Controls;

public partial class Navbar : UserControl
{
    // Scoped locally to access inside click methods
    private NavigationViewModel _viewModel => DataContext as NavigationViewModel;
    private LoginWindow _loginWindow;

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
        Console.Write("Openined songs");
        try
        {
            _viewModel.openSongs();
        }
        catch (Exception ex)
        {  Console.Write("issues songs");
           
            Console.WriteLine(ex.Message);
        }
      
    }
    private void OpenDashboard(object sender, RoutedEventArgs e)
    {
        _viewModel?.openDashboard();
    }
    private void OpenBilling(object sender, RoutedEventArgs e)
    {
        _viewModel?.openBilling();
    }

    private void Logout(object sender, RoutedEventArgs e)
    {
        _loginWindow = new LoginWindow();
        _loginWindow.Show();
        Window.GetWindow(this).Close();
        
    }
}