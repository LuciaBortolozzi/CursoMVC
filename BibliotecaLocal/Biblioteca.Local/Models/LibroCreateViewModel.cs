using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biblioteca.Local.Data;
using Biblioteca.Local.Data.Entidades;

namespace Biblioteca.Local.Models
{
    public class LibroCreateViewModel
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }

        public void Create()
        {
            Libro libroNuevo = new Libro();
            libroNuevo.LibroID = BibliotecaModel.GetID();
            libroNuevo.Titulo = this.Titulo;
            libroNuevo.Autor = this.Autor;
            libroNuevo.Genero = this.Genero;

            BibliotecaModel.Create(libroNuevo);
        }
    }
}