using System.Windows.Controls;

namespace ArthaInventoryManagementSystem.Pages;

public partial class Songs : Page
{
    public Songs()
    {
        InitializeComponent();
        SongsList.ItemsSource = GetSongs();

    }

    public List<string> GetSongs()
    {
        List<string> songs = new List<string>();
        songs.Add("no asd");
        songs.Add("asdas");
        return songs;
    }
}