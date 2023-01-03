using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serialization.Models
{
    public class Objeto
    {

        public Objeto(int id, string nome, decimal preco, DateTime Data) {

            Id = id;
            Nome = nome;
            Preco = preco;
            DataObjeto = Data;
        }

        public int Id { get; set; }

        //Atributo: Serve para informar qual é o nome da propriedade que está no arquivo Json
        [JsonProperty("Nome_Objeto")]
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataObjeto { get; set; }
    }
}
