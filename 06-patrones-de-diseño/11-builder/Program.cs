using Dominio.Builder;

IBuilderComputadora builder =
    new ConstructorPCGamer();

Director director = new Director();

director.Construir(builder);

Computadora pc =
    builder.ObtenerComputadora();

Console.WriteLine("PC Gamer");
Console.WriteLine($"CPU: {pc.CPU}");
Console.WriteLine($"Memoria RAM: {pc.MemoriaRAM} GB");
Console.WriteLine($"Almacenamiento: {pc.Almacenamiento} GB");
Console.WriteLine($"Tarjeta Gráfica: {pc.TarjetaGrafica}"); 

Console.WriteLine($"Detalle: {pc.Detalle()}");

IBuilderComputadora builderOficina =
    new ConstructorPCOficina();

director.Construir(builderOficina);

Computadora pcOficina =
    builderOficina.ObtenerComputadora();

Console.WriteLine("PC Oficina");
Console.WriteLine($"CPU: {pcOficina.CPU}");
Console.WriteLine($"Memoria RAM: {pcOficina.MemoriaRAM} GB");
Console.WriteLine($"Almacenamiento: {pcOficina.Almacenamiento} GB");
Console.WriteLine($"Tarjeta Gráfica: {pcOficina.TarjetaGrafica}"); 

Console.WriteLine($"Detalle: {pcOficina.Detalle()}");