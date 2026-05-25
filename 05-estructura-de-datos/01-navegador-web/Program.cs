using Navegador.Dominio;

Browser browser = new Browser("https://www.google.com");
Console.WriteLine("Visitando 1ro: " + browser.GetCurrentUrl());

browser.Visit("https://www.facebook.com");
Console.WriteLine("Visitando 2do: " + browser.GetCurrentUrl());
browser.Visit("https://www.twitter.com");
Console.WriteLine("Visitando 3ro: " + browser.GetCurrentUrl());

Console.WriteLine("\nHistorial:");
browser.ShowHistory();      

Console.WriteLine("\nVolviendo atrás...");
Console.WriteLine("Pop a la ultima página: " + browser.GetCurrentUrl() + " agregada a la pila.");
browser.Back();

Console.WriteLine("\nHistorial:");
browser.ShowHistory();    
