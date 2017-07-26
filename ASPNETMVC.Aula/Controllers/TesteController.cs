using ASPNETMVC.Aula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC.Aula.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index( FormCollection formCollection )
        //{
        //    string nome = formCollection[ "nome" ];
        //    //ViewBag so funciona na pagina que foi chamada.
        //    ViewBag.Mensagem = nome;
        //    return View( "Saudacao" );
        //}

        //[HttpPost]
        //public ActionResult Index( string nome )
        //{
        //    //ViewBag so funciona na pagina que foi chamada.
        //    ViewBag.Mensagem = nome;
        //    return View( "Saudacao" );
        //}
        [ValidateAntiForgeryToken]//Valida o Form para ataques de hackers
        [HttpPost]//////////////////Decoração para evita ataques de hackers
        public ActionResult Index( [Bind(Exclude ="Ativo")]Pessoa pessoa )
        {
            if( ModelState.IsValid )
            {
                pessoa.Ativo = true;

                return View( "Saudacao" , pessoa );
            }
            else
            {
                return View( pessoa );
            }
        }
    }
}