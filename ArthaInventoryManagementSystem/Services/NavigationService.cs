using System.Windows.Controls;

namespace ArthaInventoryManagementSystem.Services;

public class NavigationService
{
    // We will set this frame once the MainWindow initializes
    private Frame? _frame;

    public void Initialize(Frame frame)
    {
        _frame = frame;
    }

    public void NavigateTo<T>() where T : Page
    {
        if (_frame == null)
        {
            throw new InvalidOperationException("NavigationService has not been initialized with a Frame.");
        }

        var page = (Page)Activator.CreateInstance(typeof(T))!;
        _frame.Navigate(page);
    }
}