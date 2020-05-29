using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Web.Models
{
    public class LibroEditModel
    {
        public int LibroID { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int GeneroID { get; set; }

        public List<Genero> Generos { get; set; }

        public LibroEditModel() { }

        public LibroEditModel(int id)
        {
            this.Fill(id);
            this.FillGeneros();
        }

        public void Fill(int id)
        {
            var libro = LibroRepository.Get(id);
            this.LibroID = libro.LibroID;
            this.Titulo = libro.Titulo;
            this.Autor = libro.Autor;
            this.GeneroID = libro.Genero.GeneroID;
        }

        public void FillGeneros()
        {
            this.Generos = GeneroRepository.GetList();
        }

        public bool Edit()
        {
            var libro = LibroRepository.Get(this.LibroID);
            libro.Titulo = this.Titulo;
            libro.Autor = this.Autor;
            libro.Genero = GeneroRepository.Get(this.GeneroID);

            return LibroRepository.Edit(libro);
        }



        
    }
}