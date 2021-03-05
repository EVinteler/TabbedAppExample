using System;
using System.Collections.Generic;
using TabbedAppExample.ViewModels;
using TabbedAppExample.Views;
using Xamarin.Forms;

namespace TabbedAppExample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
