using Serialization.Models;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http;


//Serealização
DateTime data = DateTime.Now;

Objeto objeto = new Objeto(1, "Objeto 1", 25.00M, data);
Objeto objeto2 = new Objeto(1, "Objeto 2", 25.00M, data);


List<Objeto> list = new List<Objeto>();

list.Add(objeto);
list.Add(objeto2);

string serializado = JsonConvert.SerializeObject(list, Formatting.Indented);

//File.WriteAllText(Path.GetFullPath(@"..\..\..\") + "\\Arquivos\\objetos.json", serializado);

//Deserealização
string conteudoArquivo = File.ReadAllText(Path.GetFullPath(@"..\..\..\") + "\\Arquivos\\objetos.json");

List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(conteudoArquivo);

foreach (Objeto obj in lista)
{
    Console.Write("\n" + obj.Nome);

}
