using System;
using POO10Ejercicio02.Entidades.Emuns;

namespace POO10Ejercicio02.Entidades
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public string Localidad { get; set; }
        public string dni { get; set; }

        public override string ToString()
        {
            return $"{Apellido.ToUpper()}, {Nombres} ";
        }

        public int Edad => (int) Math.
            Truncate(DateTime.Today.
                         Subtract(FechaNacimiento)
                         .TotalDays / 365.25);
    }
}
