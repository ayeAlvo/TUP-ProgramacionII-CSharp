using DocumentoStrategy.Dominio;

Documento documento = new Documento("algo");

ProcesadorDocumento procesador = new ProcesadorDocumento(new ProcesamientoEncriptado());

Console.WriteLine("Primer procesamiento");
procesador.Procesar(documento);
// procesador.Procesar(null); // esto va a tirar una excepción porque el documento no puede ser nulo


Console.WriteLine();

Console.WriteLine("Segundo procesamiento");
Console.WriteLine("Cambio de estrategia"); // solo para este procesamiento puntual
procesador.Procesar(documento, new ProcesamientoComprimido());
// procesador.Procesar(documento, null); // esto va a tirar una excepción porque la estrategia no puede ser nula


Console.WriteLine();

Console.WriteLine("Tercer procesamiento"); // sigue le coportamiento por default
procesador.Procesar(documento);
Console.WriteLine();

Console.WriteLine("Cuarto procesamiento");
Console.WriteLine("Cambio de estrategia por default");
procesador.CambiarProcesamiento(new ProcesamientoComprimido());
// procesador.CambiarProcesamiento(null); // esto va a tirar una excepción porque la estrategia no puede ser nula
procesador.Procesar(documento); 

