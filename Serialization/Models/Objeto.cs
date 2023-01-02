using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Models
{
    public class Objeto
    {

        public Objeto(int id, string nome, decimal preco) {

            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
