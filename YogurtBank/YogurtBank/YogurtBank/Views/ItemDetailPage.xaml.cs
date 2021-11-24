using System.ComponentModel;
using Xamarin.Forms;
using YogurtBank.ViewModels;

namespace YogurtBank.Views
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