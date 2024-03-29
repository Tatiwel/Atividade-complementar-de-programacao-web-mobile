using System.ComponentModel.DataAnnotations;
namespace DestinoCerto.Models
{
    public class Vehicle
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Tipo de Transporte")]
        public string TipoTransporte { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Capacidade de Passageiros")]
        public int CapacidadePassageiros { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF do Motorista")]
        public string CpfMotorista { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string tipoTransporte, string placa, string marca, string modelo, int ano, int capacidadePassageiros, string cpfMotorista)
        {
            TipoTransporte = tipoTransporte;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            CapacidadePassageiros = capacidadePassageiros;
            CpfMotorista = cpfMotorista;
        }
    }
}
