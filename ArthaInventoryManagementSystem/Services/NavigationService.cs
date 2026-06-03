using System.Windows.Controls;

namespace ArthaInventoryManagementSystem.Services;

public class NavigationService
{
    private readonly Frame _frame;

    public NavigationService(Frame frame)
    {
        _frame = frame;
    }

    public void NavigateTo<T>() where T : Page
    {
        var page = (Page)Activator.CreateInstance(typeof(T));
        _frame.Navigate(page);
    }
}