using BindingDemo.Models;
using Xamarin.Forms;

namespace BindingDemo
{
    public partial class MainPage : ContentPage
	{
        private FormModel Model = new FormModel();

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = Model;
        }

        private void peopleList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("The selected person", peopleList.SelectedItem.ToString(), "Cancel");
        }

    }
}
