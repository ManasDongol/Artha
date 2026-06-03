using System.Windows;
using System.Windows.Controls;
using ArthaInventoryManagementSystem.Pages;

namespace ArthaInventoryManagementSystem.Controls;

public partial class Navbar : UserControl
{
    public Navbar()
    {
        InitializeComponent();
    }
    
    private void OpenProducts(object sender, RoutedEventArgs e)
    {
       // MainFrame.Navigate(new Products());
    }

    private void OpenSongs(object sender, RoutedEventArgs e)
    {
        //MainFrame.Navigate(new  Songs());
    }
}