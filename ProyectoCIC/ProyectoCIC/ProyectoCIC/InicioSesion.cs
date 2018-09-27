using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoCIC
{
    public class InicioSesion : ContentPage
    {
        public InicioSesion()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}
