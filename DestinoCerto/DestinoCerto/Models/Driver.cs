using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DestinoCerto.Models
{
    public class Driver
    {

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(10)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        //[Required(ErrorMessage = "Campo obrigatório")]
        //[Display(Name = "Endereço")]
        //public Endereco endereco{ get; set; 

        public Driver(string nome, DateTime dtNascimento, string cpf)
        {
            Nome = nome;
            DtNascimento = dtNascimento;
            Cpf = cpf;
        }
    }
}
