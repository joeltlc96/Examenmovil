using Examen.Services;
using Examen.ViewsModels;
using System.Threading.Tasks;

namespace Examen.Views;

public partial class Register : ContentPage
{
	private readonly EstudiantesViewModel _viewModel;
	private IPageNavigation PageNavigation => Application.Current.MainPage.Pa;
	public Register(EstudiantesViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		this.BindingContext = _viewModel;
	}
}