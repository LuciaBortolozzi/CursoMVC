using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Web.Models
{
    public class LibroIndexModel
    {
        public List<Libro> ListLibro { get; set; }

        public LibroIndexModel()
        {
            this.ListLibro = new List<Libro>();
        }

        public void Fill()
        {
            this.ListLibro = LibroRepository.GetList();
        }
    }
}