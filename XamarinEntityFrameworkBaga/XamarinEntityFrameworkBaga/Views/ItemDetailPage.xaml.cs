using System.ComponentModel;
using Xamarin.Forms;
using XamarinEntityFrameworkBaga.ViewModels;

namespace XamarinEntityFrameworkBaga.Views
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