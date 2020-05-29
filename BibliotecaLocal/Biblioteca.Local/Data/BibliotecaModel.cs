using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biblioteca.Local.Data.Entidades;

namespace Biblioteca.Local.Data
{
    public static class BibliotecaModel
    {
        public static List<Libro> Libros;

        public static void Inicializar()
        {
            Libros = new List<Libro>();
            Libros.Add(new Libro(1, "La Voz de los Muertos", "Scott Card", "Ciencia Ficcion"));
            Libros.Add(new Libro(2, "Harry Potter", "JK Rowling", "Fantasia"));
            Libros.Add(new Libro(3, "El Señor de los Anillos", "Tolkien", "Fantasia"));
        }

        public static Libro GetLibro(int ID)
        {
            return Libros.Find(x => x.LibroID == ID);
        }

        public static List<Libro> GetListLibros()
        {
            return Libros;
        }

        public static int GetID()
        {
            return Libros.ElementAt(Libros.Count() - 1).LibroID + 1;
        }

        public static void Create(Libro libroNuevo)
        {
            Libros.Add(libroNuevo);
        }
    }
}