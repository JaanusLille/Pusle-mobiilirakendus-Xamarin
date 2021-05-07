using Pusle_mobiilirakendus_Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Pusle_mobiilirakendus_Xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}