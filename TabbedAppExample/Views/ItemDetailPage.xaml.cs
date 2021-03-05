using System.ComponentModel;
using Xamarin.Forms;
using TabbedAppExample.ViewModels;

namespace TabbedAppExample.Views
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