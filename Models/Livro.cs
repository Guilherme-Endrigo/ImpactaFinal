﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaImpacta.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "A editora é obrigatório")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "O Ano de publicação é obrigatório")]
        public int Ano { get; set; }
        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}