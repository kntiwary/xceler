using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xceler.ViewModel;

namespace xceler.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterDetails : ContentPage
    {
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
    }
}
