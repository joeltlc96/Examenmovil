using CommunityToolkit.Maui.Alerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Services
{
    public class MessageService : IMessageService
    
    {
        public void mostrarSnackbar(string mensaje, int duration = 3)
        {
            Snackbar.Make(mensaje, duration: TimeSpan.FromMilliseconds(duration));
        }
        public Task ShowAlertAsync(string titulo, string mensaje, string boton)
        {
            var mainPage = Application.Current?.MainPage;

            if (mainPage is not null)
            {
                return mainPage.DisplayAlert(titulo, mensaje, boton);
            }
            return Task.CompletedTask;
        }
    }
}
