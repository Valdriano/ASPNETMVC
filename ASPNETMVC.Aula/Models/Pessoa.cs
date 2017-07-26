using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVC.Aula.Models
{
    public class Pessoa
    {
        [Required( ErrorMessage = "O Nome e Obrigatório" )]
        [DisplayName( "Seu Nome:" )]
        [MaxLength( 50 , ErrorMessage = "O máximo de caractere e 50" )]
        [MinLength( 5 , ErrorMessage = "O minimo de caractere e 5" )]
        public string Nome { get; set; }

        [Required( ErrorMessage = "A Idade é Obrigatório" )]
        [DisplayName( "Sua Idade:" )]
        public int Idade { get; set; }

        [Required( ErrorMessage = "O Endereço é Obrigatório" )]
        [DisplayName( "Seu Endereço:" )]
        [MaxLength( 60 , ErrorMessage = "O máximo de caractere e 60" )]
        public string Endereco { get; set; }

        [Required( ErrorMessage = "O E-mail é Obrigatório" )]
        [DisplayName( "Seu E-mail:" )]
        [MaxLength( 100 , ErrorMessage = "O máximo de caractere e 100" )]
        [DataType( DataType.EmailAddress , ErrorMessage = "E-mail inválido" )]
        public string Email { get; set; }

        public bool Ativo { get; set; }
    }
}