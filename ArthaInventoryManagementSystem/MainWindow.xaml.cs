using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ArthaInventoryManagementSystem.Pages;

namespace ArthaInventoryManagementSystem;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainFrame.Navigate(new Dashboard());
    }
    private void OpenProducts(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new Products());
    }

    private void OpenSongs(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new  Songs());
    }
}