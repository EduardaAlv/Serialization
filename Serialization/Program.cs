using Serialization.Models;
using Newtonsoft.Json;

Objeto objeto = new Objeto(1, "Objeto 1", 25.00M);


string serializado = JsonConvert.SerializeObject(objeto, Formatting.Indented);

Console.WriteLine(serializado);