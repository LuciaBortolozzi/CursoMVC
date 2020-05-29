using Biblioteca.Local.Data;
using Biblioteca.Local.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Local.Models
{
    public class LibroEditViewModel
    {
        public int LibroID { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }

        public LibroEditViewModel(int ID)
        {
            this.Fill(ID);
        }

        public void Fill(int ID)
        {
            Libro libroAEditar = BibliotecaModel.GetLibro(ID);
            this.LibroID = libroAEditar.LibroID;
            this.Titulo = libroAEditar.Titulo;
            this.Autor = libroAEditar.Autor;
            this.Genero = libroAEditar.Genero;
        }

        public void Edit(Libro libroeditado)
        {

        }
    }
}