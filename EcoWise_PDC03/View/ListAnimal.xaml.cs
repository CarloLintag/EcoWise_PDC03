using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoWise_PDC03.Model;
using EcoWise_PDC03.ViewModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoWise_PDC03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListAnimal : ContentPage
    {
        AnimalListViewModel viewModel;
        public ListAnimal()
        {
            InitializeComponent();
            viewModel = new AnimalListViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            showAnimalList();
        }
        private void showAnimalList()
        {
            var res = viewModel.GetAllAnimalLists().Result;
            AnimalListView.ItemsSource = res;

        }
        private void btnAddRecord_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AddAnimal());
        }
        private async void AnimalListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                AnimalModel obj = (AnimalModel)e.SelectedItem;
                string res = await DisplayActionSheet("Operation", "Cancel", null, "Update", "Delete");

                switch (res)
                {
                    case "Update":
                        await this.Navigation.PushAsync(new AddAnimal(obj));
                        break;
                    case "Delete":
                        viewModel.DeleteAnimalList(obj);
                        showAnimalList();
                        break;
                }
                AnimalListView.SelectedItem = null;
            }
        }

    }
}