using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace ArthaInventoryManagementSystem.Views.Forms;

public partial class LoginForm : UserControl
{
    private MainWindow _mainWindow;
    public LoginForm()
    {
        InitializeComponent();
    }

  
    public void submit_login(object sender, RoutedEventArgs e)
    {
        _mainWindow = App.serviceProvider.GetRequiredService<MainWindow>();
        if (UserPass.Password=="Manas")
        {
            _mainWindow.Show(); 
            Window.GetWindow(this)?.Close();
        }
        else
        {
            MessageBox.Show("Invalid username or password");
        }
   

    }
}