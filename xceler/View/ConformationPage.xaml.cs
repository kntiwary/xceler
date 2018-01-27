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
    public partial class ConformationPage : ContentPage
    {
        public User userdetail { get; set; }
        public ConformationPage(User user)
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(user);
            MessagingCenter.Send(this, "MenuDisabled");
            userdetail = new User();
            this.userdetail = user;

        }



        protected override async void OnDisappearing()
        {
            MessagingCenter.Send(this, "MenuEnabled");
        }
        async Task Handle_Clicked(object sender, System.EventArgs e)
        {
            if(await DisplayAlert("", "Do you want to save the Changes", "Definately", "Never"))
            {
                var vm = BindingContext as MainPageViewModel;
                await vm.SaveUser(userdetail);
                await Navigation.PopAsync();
            }
        }
    }
}
