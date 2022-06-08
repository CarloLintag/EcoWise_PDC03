using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EcoWise_PDC03.Model;
using EcoWise_PDC03.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoWise_PDC03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAnimal : ContentPage
    {
        AnimalListViewModel _viewModel;

        bool _isUpdate;
        int id;

        public AddAnimal()
        {
            InitializeComponent();
            _viewModel = new AnimalListViewModel();
            _isUpdate = false;
        }

        public AddAnimal(AnimalModel obj)
        {
            InitializeComponent();
            _viewModel = new AnimalListViewModel();
            if (obj != null)
            {
                id = obj.id;
                AnimalCode.Text = obj.AnimalCode;
                InitialIdentification.Text = obj.InitialIdentification;
                Kingdom.Text = obj.Kingdom;
                Class.Text = obj.Class;
                Family.Text = obj.Family;
                Genus.Text = obj.Genus;
                ScientificName.Text = obj.ScientificName;
                Taxonomy.Text = obj.Taxonomy;
                Characteristics.Text = obj.Characteristics;
                Habitat.Text = obj.Habitat;
                Threats.Text = obj.Threats;
                Conservation.Text = obj.Conservation;
                _isUpdate = true;
            }
        }

        private async void btnSaveUpdate_Clicked(object sender, EventArgs e)
        {
            AnimalModel obj = new AnimalModel();
            obj.id = id;
            obj.AnimalCode = AnimalCode.Text;
            obj.InitialIdentification = InitialIdentification.Text;
            obj.Kingdom = Kingdom.Text;
            obj.Class = Class.Text;
            obj.Family = Family.Text;
            obj.Genus = Genus.Text;
            obj.ScientificName = ScientificName.Text;
            obj.Taxonomy = Taxonomy.Text;
            obj.Characteristics = Characteristics.Text;
            obj.Habitat = Habitat.Text;
            obj.Threats = Threats.Text;
            obj.Conservation = Conservation.Text;

            if (_isUpdate)
            {
                obj.id = id;
                await _viewModel.UpdateAnimalList(obj);
            }
            else
            {
                _viewModel.InsertAnimalList(obj);
            }
            await this.Navigation.PopAsync();
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListAnimal());
        }

    }
}