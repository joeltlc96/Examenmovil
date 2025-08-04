using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Entitys
{
    public class Estudiantes
    {
        public string  Cedula {  get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public DateTime  FechaNacimiento { get; set; } = DateTime.Now;
        public string Sexo { get; set; } = string.Empty;
        public bool Trabaja { get; set; } = false;
        public int ObtenerEdad()
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad))
                edad--;
            return edad;
        }

        //  Verifica si es mayor o igual a 18
        public bool EsMayorDeEdad()
        {
            return ObtenerEdad() >= 18;
        }

        public string nombreCompleto
        {
            get
            {
                return $"{Nombre}";
            }
        }

        public string Avatar
        {
            get
            {
                return Sexo.Equals("Hombre") ? "hombre.jpg" : "mujer.jpg";
            }
        }
    }
}
