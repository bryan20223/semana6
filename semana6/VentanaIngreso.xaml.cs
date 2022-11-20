using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace semana6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaIngreso : ContentPage
    {
        private object txtcodigo;
        private object txtnombre;
        private object txtNombre;
        private object txtapellido;
        private object txtEdad;

        public VentanaIngreso()
        {
            InitializeComponent();

        }
        private void btnInsertar_Clicked(object sender, EventArgs e, System.Collections.Specialized.NameValueCollection parametros)
        {

            WebClient cliente = new WebClient();
            
            try
            {
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("Codigo", txtcodigo.Text);
                parametros.Add("Nombre", txtNombre.Text);

                parametros.Add("Apellido", txtApellido.Text);
                parametros.Add("Edad", txtEdad.Text);






                cliente.UploadValues("http://192.168.100.7/odonto/post.php", "POST",parametros);
        }

            
            catch (Exception)
            {
             
        
            }
        }

        private  async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        }
    }
