using MiDietaApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MiDietaApp.Views
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