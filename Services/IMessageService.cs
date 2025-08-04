using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Services
{
    public interface IMessageService
    {
        void mostrarSnackbar(string message, int tiempo = 3);
    }
}
