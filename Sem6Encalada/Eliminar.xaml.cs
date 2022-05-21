using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sem6Encalada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eliminar : ContentPage
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtCodigo.Text);

            HttpClient client = new HttpClient();
            var resultado = await client.DeleteAsync(string.Concat("http://192.168.22.11/moviles/post.php", Id));
            if (resultado.IsSuccessStatusCode)
            {
                await DisplayAlert("Fallo", "Registro Eliminado", "Cerrar");
            }
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}