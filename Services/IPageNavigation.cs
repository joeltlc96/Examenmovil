using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Services
{
    public interface IPageNavigation
    {
        Task PushAsync(Page page);
        Task PopAsync();
        Task PushModalAsync(Page page);
        Task PopModalAsync();
    }
}
