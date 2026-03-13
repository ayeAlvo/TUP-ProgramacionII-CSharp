var art = new Articulo();

art.SetMarca("Samsung");
art.SetModelo("Galaxy S22");

// ❌ No se puede hacer esto:
// Console.WriteLine(art.Marca);
// Console.WriteLine(art.Modelo);

// Esto genera error porque los atributos son privados.