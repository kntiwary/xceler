﻿using System;
using System.Collections.Generic;
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


            navigationDrawerList.ItemsSource = MenuItmeList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(xcelerPage)));
        }
    }
}
