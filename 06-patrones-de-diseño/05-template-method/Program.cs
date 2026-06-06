using TemplateMethod.Dominio;

Console.WriteLine("Preparando té:");

Bebida te = new Te();

te.Preparar();

Console.WriteLine();

Console.WriteLine("Preparando café:");

Bebida cafe = new Cafe();

cafe.Preparar();