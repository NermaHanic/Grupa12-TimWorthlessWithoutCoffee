using DearWalletWebNovi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DearWalletWebNovi.Controllers
{
    public class OdjevniPredmetController : Controller
    {
        // GET: OdjevniPredmet
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(OdjevniPredmet op)
        {
            string filename = Path.GetFileNameWithoutExtension(op.ImageFile.FileName);
            string extension = Path.GetExtension(op.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            op.PSlika = "~/Image/" + filename;
            filename = Path.Combine(Server.MapPath("~/Image/"), filename);
            op.ImageFile.SaveAs(filename);
            using (DressMeUpContext db = new DressMeUpContext())
            {
                db.OdjevniPredmet.Add(op);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View();
        }
        /*
        public ActionResult View(int id)
        {
            OdjevniPredmet op = new OdjevniPredmet();
            using (DressMeUpContext db = new DressMeUpContext())
            {
                op = db.OdjevniPredmet.Where(x => x.Id == id).FirstOrDefault();
            }
            return View();
        }
        */


    }
}