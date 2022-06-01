using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto01MVC.Models
{
    public class FazerPedido
    {
        //listagem dos produtos
        public int ProdutoID { get; set; }

        [Required]
        [Display(Name = "Numero Pedido")]
        public int ID { get; set; }
        [Required]
        [Display(Name ="Data do Pedido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage ="Data em formato invalido")]
        public DateTime PedidoData { get; set; } 

        [Required]
        [Display(Name ="Nome Produto")]
        public string Produto { get; set; }
        [Required]
        [Display(Name ="Quantido deseja")]
        public int Quantidade { get; set; }
      
        public List<FazerPedido> ListarProduto()
        {
            return new List<FazerPedido>
            {
                new FazerPedido{ProdutoID = 1, Produto ="Controle"},
                new FazerPedido{ProdutoID = 2, Produto ="PS5"},
                new FazerPedido{ProdutoID = 3, Produto ="PS4"},
                new FazerPedido{ProdutoID = 4, Produto ="XBox Serie S"},
                new FazerPedido{ProdutoID =5, Produto ="Call of Duty Black Ops 2"},
                new FazerPedido{ProdutoID =6, Produto ="God of war3"}
            };
        }
    
    }
}