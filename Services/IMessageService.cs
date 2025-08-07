using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Services
{
    public interface IMessageService
    {
        void showSnakBar(string mensaje, int duration = 3000);
        Task ShowAlertAsync(string titulo, string mensaje, string boton);
    }
}
