using ShoppingAssignment.Views;

namespace ShoppingAssignment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}
