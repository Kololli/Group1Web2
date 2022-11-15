using Group1Web2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group1Web2.Controllers
{
    public class ProfesorController : Controller
    {
        public IActionResult Index()
        {
            Profesori prof1 = new Profesori(emri:"Leron", mbiemri:"Berisha");
            Profesori prof2 = new Profesori(emri: "Ledion", mbiemri: "Kololli");
            Profesori prof3 = new Profesori(emri: "Hasan", mbiemri: "Hasani");
            List<Profesori> profesoret = new List<Profesori>();
                profesoret.Add(prof1);
                profesoret.Add(prof2);
                profesoret.Add(prof3);
            return View(profesoret);

        }

        public IActionResult MesoHtml()
        {
            return View();

        }
    }
}
