using System;
using System.Collections.Generic;

using Xamarin.Forms;
using xceler.Model;
using xceler.ViewModel;

namespace xceler.View
{
    public partial class MainP : ContentPage
    {
        public MainP(User user)
        {
            //NavigationPage.SetHasNavigationBar(this, false);
           // NavigationPage.SetHasBackButton(this,true);
            InitializeComponent();
            BindingContext = new MainPageViewModel(user);
            MessagingCenter.Send(this, "MenuDisabled");


        }
       
        //protected override async void 
        //{
        //    MessagingCenter.Send(this, "MenuEnabled");
        //}

        protected override async void OnDisappearing ()
        {
            
           MessagingCenter.Send(this, "MenuEnabled");
        }

    }

}
