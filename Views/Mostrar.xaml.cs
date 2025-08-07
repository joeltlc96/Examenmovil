using Examen.ViewsModels;
using System.Threading.Tasks;

namespace Examen.Views;

public partial class Mostrar : ContentPage
{
	private readonly EstudiantesViewModel _viewModel;
	public Mostrar(EstudiantesViewModel viewModel)
	{
        InitializeComponent();
		_viewModel = viewModel;
		this.BindingContext= _viewModel;
	}
}