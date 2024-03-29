using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;
using System.Web.UI.WebControls.WebParts;
using System.Web.WebPages;
namespace DestinoCerto.Models
{
    /*
    O cadastro deverá contar com os seguintes campos: tipo de transporte(carro, ônibus, VAN), placa, marca, modelo, ano, capacidade de passageiros, CPF do motorista; o O sistema deverá validar se já existe um cadastro para a mesma placa;
    o O sistema deverá validar se o CPF do motorista informado é válido(se existe no cadastro de motorista);

    */
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
