using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xceler.Model;
using xceler.Services;
namespace xceler.View
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        
        List<Hamburgermenu> menuItmeList;
        public List<Hamburgermenu> MenuItmeList { get; set; }
       
        public MenuPage()
        {
            InitializeComponent();
            var HamburgerService = new HamburgermenuItem();
            MenuItmeList = HamburgerService.GetItem();


            MessagingCenter.Subscribe<ConformationPage>(this, "MenuDisabled", (sender) => { IsPresented = false; NavigationPage.SetHasNavigationBar(this, false); });
            MessagingCenter.Subscribe<ConformationPage>(this, "MenuEnabled", (sender) => { IsPresented = false; NavigationPage.SetHasNavigationBar(this, true); });

            navigationDrawerList.ItemsSource = MenuItmeList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(xcelerPage)));
        }
        private async Task OnMenuItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Hamburgermenu)e.SelectedItem;
            Type page = item.Navigation;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
