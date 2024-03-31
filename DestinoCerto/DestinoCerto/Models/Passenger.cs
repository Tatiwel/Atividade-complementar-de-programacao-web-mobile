using System;
using System.ComponentModel.DataAnnotations;

namespace DestinoCerto.Models
{
    public class Passenger
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        // Endereco foi comentado pois não está sendo utilizado e pode gerar erro na view
        // public Endereco endereco { get; set; }

        public Passenger()
        {
        }

        public Passenger(string nome, string email, DateTime dtNascimento, string cpf, string telefone)
        {
            Nome = nome;
            Email = email;
            DtNascimento = dtNascimento;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
