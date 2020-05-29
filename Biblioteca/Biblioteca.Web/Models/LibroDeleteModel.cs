using Biblioteca.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Web.Models
{
    public class LibroDeleteModel
    {
        public int LibroID { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }
        
        public void Fill(int id)
        {
            var libro = LibroRepository.Get(id);
            this.LibroID = libro.LibroID;
            this.Titulo = libro.Titulo;
            this.Autor = libro.Autor;
            this.Genero = libro.Genero.Descripcion;
        }

        public bool Delete()
        {
            var libro = LibroRepository.Get(this.LibroID);

            return LibroRepository.Delete(libro);
        }
    }
}