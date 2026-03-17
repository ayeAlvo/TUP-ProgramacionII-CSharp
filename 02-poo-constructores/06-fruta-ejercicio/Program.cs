Fruta manzana = new Fruta("Manzana", "Rojo", 150, true);

Fruta pera = new Fruta();

pera.SetNombre("Pera");
pera.SetColor("Verde");
pera.SetPeso(250);
pera.SetEsEstacional(true);


System.Console.WriteLine("Frutas:");
Console.WriteLine("\nNombre: " + manzana.GetNombre());
Console.WriteLine("Color: " + manzana.GetColor());
Console.WriteLine("Peso: " + manzana.GetPeso());
Console.WriteLine("Es comestible? " + manzana.EsComestible() + "\n");

Console.WriteLine("Nombre: " + pera.GetNombre());
Console.WriteLine("Color: " + pera.GetColor());
Console.WriteLine("Peso: " + pera.GetPeso());
Console.WriteLine("Es comestible? " + pera.EsComestible() + "\n");