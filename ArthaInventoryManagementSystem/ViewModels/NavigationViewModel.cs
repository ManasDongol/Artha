
using ArthaInventoryManagementSystem.Pages;
using ArthaInventoryManagementSystem.Services;
using Microsoft.Extensions.Logging;

namespace ArthaInventoryManagementSystem.ViewModels;

public class NavigationViewModel(NavigationService navigationService,ILogger<NavigationViewModel> logger)
{

  
    public void openSongs()
    {
     
        navigationService.NavigateTo<Songs>();
        //service.Navigate("Songs");
    }
    public void openDashboard()
    {
       
        navigationService.NavigateTo<Dashboard>();
        //service.Navigate("Songs");
    }
    public void openBilling()
    {
      
        navigationService.NavigateTo<Billing>();
        //service.Navigate("Songs");
    }
    public void openProducts()
    {

        navigationService.NavigateTo<Products>();
    }
}