Persona persona = new Persona();
persona.SetNombre("Ricardo");
persona.SetApellido("Perez");

Visitante visitante = new Visitante();
visitante.SetNombre("Laura");
visitante.SetApellido("Burgos");

Guardia guardia = new Guardia();
guardia.SetNombre("Carlos");
guardia.SetApellido("Gomez");

Console.WriteLine("Persona: " + persona.GetNombre() + " " + persona.GetApellido());
Console.WriteLine("Visitante: " + visitante.GetNombre() + " " + visitante.GetApellido());
Console.WriteLine("Guardia: " + guardia.GetNombre() + " " + guardia.GetApellido());