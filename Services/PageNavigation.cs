using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Services
{
    public class PageNavigation : IPageNavigation
    {
        private INavigation Navigation => Application.Current.MainPage.Navigation;
        public Task PushAsync(Page page) => Navigation.PushAsync(page);
        public Task PopAsync() => Navigation.PopAsync();
        public Task PushModalAsync(Page page) => Navigation.PushModalAsync(page);
        public Task PopModalAsync() => Navigation.PopModalAsync();
    }
}
