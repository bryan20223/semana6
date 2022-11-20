using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using Xamarin.Forms;

namespace semana6
{
    public partial class VentanaIngreso : ContentPage
    {
        private const string Url = "http://192.168.100.7/odonto/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<semana6.Datos> _post;

        public object MyListView { get; private set; }

        public VentanaIngreso()
        {
            InitializeComponent();
            get();
        }


        private async void get()
        {
            {
            var content = await client.GetStringAsync(Url);
            List<semana6.Datos> posts =JsonConvert.DeserializeObject<List<semana6.Datos>>(content);
            _post = new ObservableCollection<Datos>(posts);
              


        }
    }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}