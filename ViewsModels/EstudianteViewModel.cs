using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Examen.Services;
using Examen.Entitys;
using Examen.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ViewsModels
{
    public partial class EstudiantesViewModel : ObservableObject
    {
        private readonly IMessageService _notiServ;
        private readonly IPageNavigation _naviServ;

        [ObservableProperty]
        private Estudiantes _Estudiantes;

        public EstudiantesViewModel(IMessageService notiServ, IPageNavigation naviServ)
        {
            _notiServ = notiServ;
            _Estudiantes = new Estudiantes();
            _naviServ = naviServ;
        }

        [RelayCommand]
        private async Task Register()
        {
            if (await ValidarCedula() == false)
            {
                return;
            }
            else if (await ValidarNombre() == false)
            {
                return;
            }
            else if (await ValidarFechaNacimiento() == false)
            {
                return;
            }
            else if (await ValidarSexo() == false)
            {
                return;
            }

            IngresarImagen();

            _notiServ.showSnakBar("Estudiante registrado correctamente");
            await _naviServ.PushAsync(new Mostrar(this));
        }

        [RelayCommand]
        private async Task LimpiarCampos()
        {
            this.Estudiante = new Estudiantes();

            await _naviServ.PopAsync();
        }

        private async Task<bool> ValidarCedula()
        {
            try
            {
                if (string.IsNullOrEmpty(Estudiante.Cedula))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "La cédula no puede estar vacía", "Aceptar");
                    return false;
                }

                if (Estudiante.Cedula.Length != 10)
                {

                    await Application.Current.MainPage.DisplayAlert("Error", "La cédula debe tener 10 dígitos", "Aceptar");
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        private async Task<bool> ValidarNombre()
        {
            if (string.IsNullOrEmpty(Estudiante.Nombre))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "La Nombre no puede estar vacía", "Aceptar");
                return false;
            }
            return true;
        }
        private async Task<bool> ValidarFechaNacimiento()
        {
            if (Estudiante.FechaNacimiento == DateTime.Now)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Escoja la fecha de nacimiento", "Aceptar");
                _notiServ.showSnakBar("Escoja la fecha de nacimiento");
                return false;
            }
            if (Estudiante.FechaNacimiento > DateTime.Now)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "La fecha de nacimiento no puede ser mayor a la fecha actual", "Aceptar");
                _notiServ.showSnakBar("La fecha de nacimiento no puede ser mayor a la fecha actual");
                return false;
            }
            int edad = DateTime.Now.Year - Estudiante.FechaNacimiento.Year;
            if (edad < 18)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "El estudiante debe ser mayor de edad", "Aceptar");
                _notiServ.showSnakBar("El estudiante debe ser mayor de edad");
                return false;
            }
            return true;
        }
        private async Task<bool> ValidarSexo()
        {
            if (string.IsNullOrEmpty(Estudiante.Sexo))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "El sexo no puede estar vacío", "Aceptar");
                _notiServ.showSnakBar("El sexo no puede estar vacío");
                return false;
            }
            return true;
        }

        private void IngresarImagen()
        {
            if (Estudiante.Sexo == "Hombre")
            {
                Estudiantes.Img = "hombre.jpg";
            }
            else
            {
                Estudiantes.Img = "mujer.jpg";
            }
        }
    }
}
