Visitante v = new Visitante
{
    Nombre = "Juan",
    Apellido = "Pérez",
    Dni = 12345678
};

Guardia g = new Guardia
{
    Nombre = "Carlos",
    Apellido = "Gómez"
};

Console.WriteLine(g.ControlarDocumento(v));