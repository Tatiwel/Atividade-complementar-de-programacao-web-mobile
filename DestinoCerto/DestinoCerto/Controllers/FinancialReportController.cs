using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class FinancialReportController : Controller
    {
        private static List<Transport> transportList = new List<Transport>();

        // GET: Relatorio/RelatorioFinanceiro
        public ActionResult RelatorioFinanceiro()
        {
            return View();
        }

        // POST: Relatorio/RelatorioFinanceiro
        [HttpPost]
        public ActionResult RelatorioFinanceiro(DateTime? dataInicio, DateTime? dataFim)
        {
            if (dataInicio == null || dataFim == null)
            {
                // Se as datas não forem fornecidas, retorna uma lista vazia
                return View(Enumerable.Empty<Transport>());
            }

            // Filtra os transportes pelo período informado
            var transportesFiltrados = transportList.Where(t =>
                DateTime.Parse(t.DataTransporte) >= dataInicio &&
                DateTime.Parse(t.DataTransporte) <= dataFim);

            return View(transportesFiltrados);
        }
    }
}
