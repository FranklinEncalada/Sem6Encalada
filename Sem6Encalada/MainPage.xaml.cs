using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sem6Encalada
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btninsertar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Insertar());
        }

        private async void btneliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Eliminar ());
        }

        private async void btnmodificar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Modificar ());
        }
    }
}
