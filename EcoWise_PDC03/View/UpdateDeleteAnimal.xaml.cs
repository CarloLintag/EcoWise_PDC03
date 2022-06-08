using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoWise_PDC03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateDeleteAnimal : ContentPage
    {
        public UpdateDeleteAnimal()
        {
            InitializeComponent();
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListAnimal());
        }
    }
}