using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Projeto01MVC.Models;

namespace Projeto01MVC.ListaPedidos
{
    public class ListaPedi
    {
        public static string Listaritensarquivo
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/pedidos.txt");
            }
        }
        public static void DescarregaArquivo(FazerPedido item)
        {
            string dados = $"{item.ID} \n, {item.Produto}\n, {item.Quantidade}\n, {item.PedidoData}\n";
            using(var write = new StreamWriter(Listaritensarquivo, true, Encoding.UTF8))
            {
                write.WriteLine(dados);
            }
        }

          public static string ObterLista(FazerPedido item)
        {
            string texto = string.Empty;
            if (!File.Exists(Listaritensarquivo))
            {
                return texto;
            }
            using(var reader = new StreamReader(Listaritensarquivo))
            {
                texto = reader.ReadToEnd();
            }
            return texto;
        }
    }
}
