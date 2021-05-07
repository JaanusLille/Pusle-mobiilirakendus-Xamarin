using Pusle_mobiilirakendus_Xamarin.ViewModels;
using Pusle_mobiilirakendus_Xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Pusle_mobiilirakendus_Xamarin
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
