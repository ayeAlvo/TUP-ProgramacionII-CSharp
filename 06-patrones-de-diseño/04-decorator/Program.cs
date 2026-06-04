using Decorator.Dominio;

ICafe cafe = new Cafe();

Console.WriteLine(cafe.Descripcion());
Console.WriteLine("Costo: $" + cafe.Costo());

cafe = new LecheDecorator(cafe);
cafe = new ChocolateDecorator(cafe);
cafe = new CanelaDecorator(cafe);

Console.WriteLine(cafe.Descripcion());
Console.WriteLine("Costo: $" + cafe.Costo());