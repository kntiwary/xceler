using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xceler.ViewModel;

namespace xceler.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewLocalDetail : ContentPage
    {
        public ViewLocalDetail()
        {
            InitializeComponent();
            BindingContext = new ViewLocalDetailVeiwModel();
        }
    }
}
