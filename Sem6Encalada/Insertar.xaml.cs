using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sem6Encalada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insertar : ContentPage
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void bntinsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtcodigo.Text);
                parametros.Add("nombre", txtnombre.Text);
                parametros.Add("apellido", txtapellido.Text);
                parametros.Add("edad", txtedad.Text);

                cliente.UploadValues("http://192.168.22.11/moviles/post.php", "POST", parametros);

                DisplayAlert("Dato Modificado", "Correctamente", "Cerrar");

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta ", ex.Message, "Ok");
            }
        }

        private async void bntRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}