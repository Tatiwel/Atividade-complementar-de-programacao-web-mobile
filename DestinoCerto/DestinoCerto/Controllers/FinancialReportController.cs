using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class FinancialReportController : Controller
    {

        // GET: FinancialReport/RelatorioFinanceiro
        public ActionResult RelatorioFinanceiro(DateTime? dataInicio, DateTime? dataFim)
        {
            if (dataInicio == null || dataFim == null)
            {
                // Se as datas não forem fornecidas, retorna a lista completa de transportes
                return View(TransportController.transportList);
            }

            // Converte as strings de data de início e fim para DateTime
            DateTime dataInicioValue = dataInicio.Value;
            DateTime dataFimValue = dataFim.Value;

            // Filtra os transportes pelo período informado
            var transportesFiltrados = TransportController.transportList.Where(t =>
                DateTime.Parse(t.DataTransporte) >= dataInicioValue && DateTime.Parse(t.DataTransporte) <= dataFimValue);

            return View(transportesFiltrados);
        }
    }
}
