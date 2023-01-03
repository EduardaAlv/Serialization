using Serialization.Models;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http;

Objeto objeto = new Objeto(1, "Objeto 1", 25.00M);
Objeto objeto2 = new Objeto(1, "Objeto 2", 25.00M);

List<Objeto> list = new List<Objeto>();

list.Add(objeto);
list.Add(objeto2);

string serializado = JsonConvert.SerializeObject(list, Formatting.Indented);

File.WriteAllText(Path.GetFullPath(@"..\..\..\") + "\\Arquivos\\objetos.json", serializado);

//Console.WriteLine(serializado);
//Console.WriteLine(objeto);
