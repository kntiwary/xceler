using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xceler.Model;
using xceler.ViewModel;

namespace xceler.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterDetails : ContentPage
    {
        public User User { get; set; }
        public EnterDetails()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new EnterDetailsViewModel();
        }

        void Handle_DateSelectedAsync(object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            DateTime date = e.NewDate;
            var vm = BindingContext as EnterDetailsViewModel;
            vm.UpdateDob(date);
        }

        async Task  Handle_Clicked(object sender, System.EventArgs e)
        {
            if(await DisplayAlert("", "Do you want to save the Changes","Ok","Cancel"))
            {
                User = new User();
                var vm = BindingContext as EnterDetailsViewModel;
                User =await vm.OnTappedUser(this);
               
                await Navigation.PushAsync(new ConformationPage(User));
            }
            return;
        }
    }
}
