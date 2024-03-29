using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DestinoCerto.Models
{
    public class User
    {
        // [Key] se for usar ID no DB 
        // public int? Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public User()
        {
        }

        public User(string nome, string email, string senha, DateTime dtNascimento, string cpf, string telefone, string endereco)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DtNascimento = dtNascimento;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
