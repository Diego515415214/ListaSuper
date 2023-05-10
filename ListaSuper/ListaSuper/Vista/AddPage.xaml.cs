using ListaSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaSuper.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var item = new To
                {
                    Name = nombre.Text,
                    Description = descripción.Text
                };                                
                var result  = await App.Context.InsertItemAsync(item);
          if (result == 1)
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo guardar", "Aceptar");
                }

            }

            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar" );
            }
        }
    }
}