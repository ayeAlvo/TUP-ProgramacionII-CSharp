using SoporteTecnico.Dominio;

Soporte nivel1 = new SoporteNivel1();
Soporte nivel2 = new SoporteNivel2();
Soporte nivel3 = new SoporteNivel3();

nivel1.SetSiguiente(nivel2);
nivel2.SetSiguiente(nivel3);

MesaDeEntrada mesaDeEntrada = new MesaDeEntrada(nivel1);

// aca le paso la solicitud, el tipo de problema y su complejidad,
// el sistema se encarga de derivar al nivel correspondiente.
Solicitud solicitud1 = new Solicitud("Cuenta", 2);
Solicitud solicitud2 = new Solicitud("Software", 4);
Solicitud solicitud3 = new Solicitud("Infraestructura", 5);
Solicitud solicitud4 = new Solicitud("Software", 5);

Console.WriteLine("Problemas de cuenta: nivel 2");
mesaDeEntrada.Atender(solicitud1);

Console.WriteLine("EStado: " + solicitud1.GetEstado());

Console.WriteLine("Problemas de software: nivel 4");
mesaDeEntrada.Atender(solicitud2);
Console.WriteLine("EStado: " + solicitud2.GetEstado());

Console.WriteLine("Problemas de infraestructura: nivel 5");
mesaDeEntrada.Atender(solicitud3);
Console.WriteLine("EStado: " + solicitud3.GetEstado());

Console.WriteLine("Problemas de software: nivel 5");
mesaDeEntrada.Atender(solicitud4);
Console.WriteLine("EStado: " + solicitud4.GetEstado());