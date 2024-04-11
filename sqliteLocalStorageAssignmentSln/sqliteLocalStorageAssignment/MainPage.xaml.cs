using System.Collections.ObjectModel;
using sqliteLocalStorageAssignment;
using ShoppingLocalMaui;

using sqliteLocalStorageAssignment.Services;
using sqliteLocalStorageAssignment.Models;


namespace ShoppingLocalMaui;
public partial class MainPage : ContentPage
{
    private ShoppingLocalDatabase _database;

    private User _currentUser;

    public User CurrentUser
    {
        get { return _currentUser; }

        set
        {
            _currentUser = value;

            OnPropertyChanged();
        }

    }

    public MainPage()
    {


        InitializeComponent();

        _database = new ShoppingLocalDatabase();

        BindingContext = this;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();
    }

    
    

    private void LoadData()
    {
        User user = _database.GetUserById(1);

        CurrentUser = user;
    }
}
