using Examen.Views;
using Examen.ViewsModels;

namespace Examen
{
    public partial class App : Application
    {
        public App(EstudiantesViewModel estudiantesView)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Register(estudiantesView));
        }
    }
}
