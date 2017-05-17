using MyAttemptX.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyAttemptX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse"
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    },

                    new NavigationPage(new HistogramPage())
                    {
                        Title = "Histogram"                        
                    }
                }
            };
        }
    }
}
