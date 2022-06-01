using Projeto01MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto01MVC.ListaPedidos;
using System.IO;

namespace Projeto01MVC.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FazerPedido()
        {
            ViewBag.Produto = new SelectList(
                new FazerPedido().ListarProduto(),
                "Produto",
                "Produto",
                "ProdutoID"
                );
           return View();
        }

        [HttpPost]
        public ActionResult FazerPedido(FazerPedido fazerPedido)
        {
            ViewBag.Produto = new SelectList(
               new FazerPedido().ListarProduto(),
               "Produto",
               "Produto",
               "ProdutoID"
               );

            if (!ModelState.IsValid)
            {
                return View();
            }
            ListaPedi.DescarregaArquivo(fazerPedido);

            return View("MostrarPedido", fazerPedido);
        }
       public string ListaPedidos()
        {
            StreamReader Arq = new StreamReader(Server.MapPath("/pedidos.txt"));
            string conteudo = Arq.ReadToEnd();

            return conteudo;
        }


    }
}