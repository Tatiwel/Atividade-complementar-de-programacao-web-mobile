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
                return View(TransportController.transportList);
            }

            DateTime dataInicioValue = dataInicio.Value;
            DateTime dataFimValue = dataFim.Value;

            var transportesFiltrados = TransportController.transportList.Where(t =>
                DateTime.Parse(t.DataTransporte) >= dataInicioValue && DateTime.Parse(t.DataTransporte) <= dataFimValue);

            return View(transportesFiltrados);
        }
    }
}
