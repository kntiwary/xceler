using Xamarin.Forms;
using xceler.View;
using Xamarin.Forms.Xaml;
using xceler.WebServ;
using xceler.DALSQLite;

namespace xceler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public static WebDataManager webDataMngr { get; private set; }
        public static AppDatabase database { get; set; }
        public App()
        {
            InitializeComponent();
            webDataMngr = new WebDataManager(new RestService());
            database = new AppDatabase();
            //MainPage = new xcelerPage();
            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
