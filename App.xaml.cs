using ExampleApp.Views;

namespace ExampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Playground();
        }
    }
}

