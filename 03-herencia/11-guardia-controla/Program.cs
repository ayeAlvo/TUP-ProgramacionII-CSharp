Persona persona = new Persona();
        persona.Nombre = "Luis";
        persona.Apellido = "Pérez";

        Visitante visitante = new Visitante();
        visitante.Nombre = "Ana";
        visitante.Apellido = "Gómez";
        visitante.Dni = 12345678;

        Guardia guardia = new Guardia();
        guardia.Nombre = "Carlos";
        guardia.Apellido = "Ramírez";

        Console.WriteLine("=== Persona ===");
        Console.WriteLine(persona.Presentarse());

        Console.WriteLine("\n=== Visitante ===");
        Console.WriteLine(visitante.Presentarse());
        Console.WriteLine($"DNI: {visitante.Dni}");

        Console.WriteLine("\n=== Guardia ===");
        Console.WriteLine(guardia.Presentarse());
        Console.WriteLine(guardia.ControlarDocumento(visitante.Dni));