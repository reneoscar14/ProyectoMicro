using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMicro.Controllers
{
    
    
    public class HelloWorldController : Controller
    {
        
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Consulta(float temperatura = 0, float humedad=0, int riego=0, int iluminacion =0)
        {
            return View();
        }
	}
}