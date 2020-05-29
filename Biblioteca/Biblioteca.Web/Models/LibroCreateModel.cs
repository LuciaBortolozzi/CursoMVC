using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Web.Models
{
    public class LibroCreateModel
    {   
        [Required(ErrorMessage = "Este titulo es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int GeneroID { get; set; }

        public List<Genero> Generos { get; set; }

        public LibroCreateModel()
        {
            Generos = new List<Genero>();
        }

        public void FillGeneros()
        {
            this.Generos = GeneroRepository.GetList();
        }

        public bool Create()
        {
            var libro = new Libro();
            libro.Titulo = this.Titulo;
            libro.Autor = this.Autor;
            libro.Genero = GeneroRepository.Get(this.GeneroID);

            return LibroRepository.Create(libro);
        }
    }
}