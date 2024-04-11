using Newtonsoft.Json;
using DadJokesApp.Models;
using System.Windows.Input;
namespace DadJokesApp
{
    public partial class MainPage : ContentPage
    {
        private string _LatestJoke;

        public string LatestJoke
        {
            get { return _LatestJoke; }
            set { _LatestJoke = value;
                OnPropertyChanged();
            }
        }

        public ICommand NewJokeCommand { get; set; }
        private HttpClient _client;


        public MainPage()
        {
            InitializeComponent();

            NewJokeCommand = new Command(GetLatestJoke);

            BindingContext = this;

            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async void GetLatestJoke(object parameterss)
        {

           string response = await _client.GetStringAsync(new Uri ("https://icanhazdadjoke.com/"));


           DadJoke latestJoke = JsonConvert.DeserializeObject <DadJoke> (response);
            
            if (latestJoke != null)
            {
                LatestJoke = latestJoke.joke;

            }
        }
    }

}
