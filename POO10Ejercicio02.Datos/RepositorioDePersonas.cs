using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using POO10Ejercicio02.Entidades;
using POO10Ejercicio02.Entidades.Emuns;

namespace POO10Ejercicio02.Datos
{
    public class RepositorioDePersonas
    {
        public List<Persona> ListaPersonas { get; set; }=new List<Persona>();
        private readonly string _archivo = Environment.CurrentDirectory + "\\Personas.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + "\\Personas.bak";

        public RepositorioDePersonas()
        {
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            StreamReader lector=new StreamReader(_archivo);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Persona persona = ConstruirPersona(linea);
                ListaPersonas.Add(persona);
            }
            lector.Close();
        }

        public CategoriaSocio GetCategoriaSocio(Persona persona)
        {
            CategoriaSocio categoria;
            if (persona.Edad<=12)
            {
                categoria = CategoriaSocio.Menor;
            }else if (persona.Edad>12 && persona.Edad<=18)
            {
                categoria = CategoriaSocio.Juvenil;
            }else if (persona.Edad>18 && persona.Edad<=40)
            {
                categoria = CategoriaSocio.Mayor;
            }
            else
            {
                categoria = CategoriaSocio.Vitalicio;
            }

            return categoria;
        }
        private Persona ConstruirPersona(string linea)
        {
            var campos = linea.Split(';');
            Persona persona = new Persona
            {
                Nombres = campos[0],
                Apellido = campos[1],
                dni = campos[2],
                FechaNacimiento = DateTime.Parse(campos[3]),
                Localidad = campos[4],
                Sexo = (Sexo) int.Parse(campos[5])
            };
            return persona;
        }

        public void Agregar(Persona persona)
        {
            GuardarEnArchivo(persona);
            ListaPersonas.Add(persona);
        }

        private void GuardarEnArchivo(Persona persona)
        {
            StreamWriter escritor=new StreamWriter(_archivo,true);
            var linea = ConstruirLinea(persona);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Persona persona)
        {
            return $"{persona.Nombres};{persona.Apellido};" +
                   $"{persona.dni};{persona.FechaNacimiento.ToShortDateString()};" +
                   $"{persona.Localidad};{persona.Sexo.GetHashCode()}";
        }

        public void Borrar(Persona persona)
        {
            BorrarRegistroDelArchivo(persona);
            ListaPersonas.Remove(persona);
        }

        private void BorrarRegistroDelArchivo(Persona persona)
        {
            /*Abro el archivo de lectura*/
            StreamReader lector=new StreamReader(_archivo);
            /*Abro el archivo de escritura*/
            StreamWriter escritor=new StreamWriter(_archivoBak);
            /*Recorro todo el archivo que tengo que leer*/
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();//Leo una linea
                Persona personaEnArchivo = ConstruirPersona(linea);//La convierto a Persona
                if (personaEnArchivo.dni!=persona.dni)//Comparo los DNI
                {
                    /*Si son distintos guardo los datos de la persona
                     del archivo de lectura en el archivo de escritura
                    porque no es la persona que quiero borrar
                    En caso que los DNI sea iguales, se saltea la persona y
                    se continua con la lectura y grabación*/
                    escritor.WriteLine(linea);
                }

            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak,_archivo);

        }

        public void Modificar(Persona persona)
        {
            StreamReader lector=new StreamReader(_archivo);
            StreamWriter escritor=new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var personaEnArchivo = ConstruirPersona(linea);
                if (personaEnArchivo.dni!=persona.dni)
                {
                    
                    escritor.WriteLine(linea);
                }
                else
                {
                    linea = ConstruirLinea(persona);
                    escritor.WriteLine(linea);
                }
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak,_archivo);
        }

        public int GetCantidad()
        {
            return ListaPersonas.Count;
        }

        public List<Persona> GetLista()
        {
            return ListaPersonas;
        }

        public bool ExisteDni(string dniBuscado)
        {
            return ListaPersonas.Exists(p => p.dni == dniBuscado);
        }

        public List<Persona> FiltrarPorLocalidad(string localidadBuscar)
        {
            return ListaPersonas
                .Where(p => p.Localidad == localidadBuscar)
                .ToList();
        }
    }
}
