// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

public enum Genero { ACCION, COMEDIA, DRAMA, SUSPENSO } //enum: enumera un tipo de valor que representa un conjunto de constantes con nombre

public class PELICULA
{
    public string Nombre { get; } //get: recupera el valor de una propiedad.
    public int Duracion { get; }
    public Genero Genero { get; }
    public int Año { get; }
    public double Clasificacion { get; set; } //set: establece el valor de una propiedad.

    public PELICULA(string nombre, int duracion, Genero genero, int año)
    {
        Nombre = nombre;
        Duracion = duracion;
        Genero = genero;
        Año = año;
    }

    public void ImprimirInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Duración: {Duracion} min");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Año: {Año}");
        Console.WriteLine($"Clasificación: {Clasificacion}");
    }

    public bool esPeliculaEpica()
    {
        return Duracion >= 180; // 180 min = 3 h
    }

    public static string Valoracion(double valoracion)
    {
        if (valoracion >= 0 && valoracion <= 2)
        {
            return "Muy mala";
        }
        else if (valoracion > 2 && valoracion <= 2.5)
        {
            return "Mala";
        }
        else if (valoracion > 2.5 && valoracion <= 5.7)
        {
            return "Regular";
        }
        else if (valoracion > 5.7 && valoracion <= 7.8)
        {
            return "Buena";
        }
        else if (valoracion > 7.8 && valoracion <= 10)
        {
            return "Excelente";
        }
        else
        {
            return "Error";
        }

        public bool esSimiliar(PELICULA otrasPelicula)
        {
            if (this.Genero == otrasPelicula.Genero && this.Clasificacion == otrasPelicula.Clasificacion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            PELICULA laPelicula = new PELICULA("El Padrino", 175, global::Genero.DRAMA, 1972);
            laPelicula.Clasificacion = 9.2;

            laPelicula.ImprimirInfo();

            if (laPelicula.esPeliculaEpica())
            {
                Console.WriteLine("Esta Pelicula es epica");
            }
            else
            {
                Console.WriteLine("Esta Pelicula no es epica");
            }

            double valor = 7.5;
            string categoria = Valoracion(valor);
            Console.WriteLine("La valoracion de la categoria es: " + categoria);

            
            PELICULA laPelicula2 = new PELICULA("The Shawshank Redemption", 142, global::Genero.DRAMA, 1994);

            if (laPelicula.esSimilar(laPelicula2))
            {
                Console.WriteLine("Las pelicula son similares");
            }
            else
            {
                Console.WriteLine("Las peliculas no son similares");
            }
        }
    }
}

