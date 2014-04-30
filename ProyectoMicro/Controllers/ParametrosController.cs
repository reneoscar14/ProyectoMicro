using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoMicro.Models;

namespace ProyectoMicro.Controllers
{
    public class ParametrosController : Controller
    {
        private ParametroDBContext db = new ParametroDBContext();

        public void GETParametros(string cultivo, string modo, float temperatura, float humedad, string calefaccion, string ventilacion1, string ventilacion2, string iluminacion, string riego, string condicionRiego, int temporizador)
        {
            Parametro parametro = new Parametro();
            int x = db.Parametros.Count();

            if (x == 5)
            {
                parametro = db.Parametros.Find(db.Parametros.First().ID);
                db.Parametros.Remove(parametro);
                db.SaveChanges();
                parametro = null;

            }
            else { parametro = null; }
            if (parametro == null)
            {
                Parametro param = new Parametro();
                if (cultivo == "A")
                {
                    param.Cultivo = "Aji";
                }
                else if(cultivo == "T")
                {
                    param.Cultivo = "Tomate";
                }
                else if(cultivo == "P"){
                    param.Cultivo = "Pepino";
                }else if(cultivo == "S"){
                    param.Cultivo = "Sin Cultivo";
                }
                if(modo == "M"){
                    param.Modo = "Manual";
                }else if(modo == "A"){
                    param.Modo = "Auto";
                }
               
                param.Temperatura = temperatura;
                param.Humedad = humedad;
               
                if (calefaccion == "O") {
                    param.Calefaccion = "ON";
                }else if(calefaccion == "F"){
                    param.Calefaccion = "OFF";
                }

                if(ventilacion1 == "O"){
                    param.Ventilador = "ON";
                }else if(ventilacion1 == "F"){
                    param.Ventilador = "OFF";
                }
                if(ventilacion2 == "O"){
                    param.Extractor = "ON";
                }else if(ventilacion2 == "F"){
                    param.Extractor = "OFF";
                }
                if(iluminacion == "O"){
                    param.Iluminacion = "ON";
                }else if(iluminacion == "F"){
                    param.Iluminacion = "OFF";
                }
                if(riego == "O"){
                    param.Riego = "ON";
                }else if(riego == "F"){
                    param.Riego = "OFF";
                }
                if(condicionRiego == "R"){
                    param.Condicion_Riego = "Riego";
                }else if(condicionRiego == "E"){
                    param.Condicion_Riego = "Espera";
                }else if(condicionRiego == "F"){
                    param.Condicion_Riego = "Fin";
                }
                param.Temporizador_Riego = temporizador;
                param.Actualizado = DateTime.Now;
                db.Parametros.Add(param);
                db.SaveChanges();
            }
        }
        // GET: /Parametros/
        public ActionResult Index()
        {
            return View(db.Parametros.ToList());
        }

        // GET: /Parametros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametro parametro = db.Parametros.Find(id);
            if (parametro == null)
            {
                return HttpNotFound();
            }
            return View(parametro);
        }

        // GET: /Parametros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Parametros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Cultivo,Modo,Temperatura,Humedad,Calefaccion,Ventilador,Extractor,Iluminacion,Riego,Condicion_Riego,Temporizador_Riego,Actualizado")] Parametro parametro)
        {
            if (ModelState.IsValid)
            {
                db.Parametros.Add(parametro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parametro);
        }

        // GET: /Parametros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametro parametro = db.Parametros.Find(id);
            if (parametro == null)
            {
                return HttpNotFound();
            }
            return View(parametro);
        }

        // POST: /Parametros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Cultivo,Modo,Temperatura,Humedad,Calefaccion,Ventilador,Extractor,Iluminacion,Riego,Condicion_Riego,Temporizador_Riego,Actualizado")] Parametro parametro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parametro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parametro);
        }

        // GET: /Parametros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametro parametro = db.Parametros.Find(id);
            if (parametro == null)
            {
                return HttpNotFound();
            }
            return View(parametro);
        }

        // POST: /Parametros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parametro parametro = db.Parametros.Find(id);
            db.Parametros.Remove(parametro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
