using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biblioteca.Local.Data.Entidades;
using Biblioteca.Local.Data;

namespace Biblioteca.Local.Models
{
    public class LibrosIndexViewModel
    {
        public List<Libro> Libros { get; set; }

        public LibrosIndexViewModel()
        {
            this.Libros = BibliotecaModel.GetListLibros();
        }

    }
}