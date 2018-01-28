using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xceler.ViewModel;

namespace xceler.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JsonList : ContentPage
    {
        public JsonList()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new JsonListViewModel();
        }
    }
}
