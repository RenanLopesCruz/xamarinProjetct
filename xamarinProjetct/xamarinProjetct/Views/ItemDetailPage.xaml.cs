using System.ComponentModel;
using Xamarin.Forms;
using xamarinProjetct.ViewModels;

namespace xamarinProjetct.Views
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