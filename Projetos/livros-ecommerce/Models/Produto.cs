using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livros_ecommerce.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string Img { get; set; }
    }
}