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
        public void mostrarSnackbar(string mensaje, int tiempo = 3)
        {
            Snackbar.Make(mensaje, duration: TimeSpan.FromSeconds(tiempo)).Show();
        }
    }
}
