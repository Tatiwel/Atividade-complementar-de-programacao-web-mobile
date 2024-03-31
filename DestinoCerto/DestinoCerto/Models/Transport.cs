using System.Web.Services.Description;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DestinoCerto.Models
{
    public class Transport
    {

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Placa do Veículo")]
        public string PlacaVeiculo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF do Passageiro")]
        public string CpfPassageiro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data do Transporte")]
        public string DataTransporte { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Hora do Transporte")]
        public string HoraTransporte { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Quantidade de KM do Trajeto")]
        public int KmTrajeto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Valor Cobrado")]
        public double ValorCobrado { get; set; }

        public Transport()
        {
        }

        public Transport(string placaVeiculo, string cpfPassageiro, string dataTransporte, string horaTransporte, int kmTrajeto, double valorCobrado)
        {
            PlacaVeiculo = placaVeiculo;
            CpfPassageiro = cpfPassageiro;
            DataTransporte = dataTransporte;
            HoraTransporte = horaTransporte;
            KmTrajeto = kmTrajeto;
            ValorCobrado = valorCobrado;
        }
    }
}
