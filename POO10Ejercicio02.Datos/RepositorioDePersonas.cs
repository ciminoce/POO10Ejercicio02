using System;
using System.Collections.Generic;
using POO10Ejercicio02.Entidades;

namespace POO10Ejercicio02.Datos
{
    public class RepositorioDePersonas
    {
        public List<Persona> ListaPersonas { get; set; }=new List<Persona>();
        private readonly string _archivo = Environment.CurrentDirectory + "\\Personas.txt";

        public RepositorioDePersonas()
        {
            
        }

        public void Agregar(Persona persona)
        {
            ListaPersonas.Add(persona);
        }

        public void Borrar(Persona persona)
        {
            ListaPersonas.Remove(persona);
        }

        public void Modificar(Persona persona)
        {
            
        }

        public int GetCantidad()
        {
            return ListaPersonas.Count;
        }

        public List<Persona> GetLista()
        {
            return ListaPersonas;
        }
    }
}
