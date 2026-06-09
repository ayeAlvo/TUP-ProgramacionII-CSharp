using AfterOffice.Dominio;

try
{
    Cerveza rubiaNacional = new RubiaNacional();
    Cerveza negraNacional = new NegraNacional();

    Vaso vasoMedio = new VasoMedioLitro();
    Vaso jarra = new Jarra();

    Barril barrilRubia = new Barril(rubiaNacional, 20);
    Barril barrilNegra = new Barril(negraNacional, 10);

    AfterOfficeLocal local = new AfterOfficeLocal();

    local.AgregarBarril(barrilRubia);
    local.AgregarBarril(barrilNegra);

    Venta venta1 = local.RealizarVenta(barrilRubia, vasoMedio);
    Console.WriteLine("Venta 1:");
    Console.WriteLine(venta1.Detalle());

    Console.WriteLine();

    Venta venta2 = local.RealizarVenta(barrilNegra, jarra);
    Console.WriteLine("Venta 2:");
    Console.WriteLine(venta2.Detalle());
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}