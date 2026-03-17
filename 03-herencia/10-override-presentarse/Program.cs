using System.IO.Pipes;

Persona persona = new Persona();
persona.SetNombre("Ricardo");
persona.SetApellido("Perez");

Visitante visitante = new Visitante();
visitante.SetNombre("Laura");
visitante.SetApellido("Burgos");

Guardia guardia = new Guardia();
guardia.SetNombre("Carlos");
guardia.SetApellido("Gomez");

Console.WriteLine(persona.Presentarse());
Console.WriteLine(visitante.Presentarse());
Console.WriteLine(guardia.Presentarse());