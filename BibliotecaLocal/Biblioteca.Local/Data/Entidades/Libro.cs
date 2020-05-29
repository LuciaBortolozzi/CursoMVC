using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Local.Data.Entidades
{
    public class Libro
    {
        public int LibroID { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }

        public Libro() { }
        public Libro(int ID, string titulo, string autor, string genero)
        {
            this.LibroID = ID;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Genero = genero;
        }
    }
}