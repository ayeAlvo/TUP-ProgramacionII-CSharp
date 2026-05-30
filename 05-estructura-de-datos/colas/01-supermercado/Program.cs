using Supermercado.Dominio;

SistemaEspera sistema = new SistemaEspera();

sistema.AgregarCliente(new Cliente("Ana", false, false));
sistema.AgregarCliente(new Cliente("Bruno", false, true));
sistema.AgregarCliente(new Cliente("Carla", true, false));
sistema.AgregarCliente(new Cliente("Diego", false, false));
sistema.AgregarCliente(new Cliente("Elena", true, true));
sistema.AgregarCliente(new Cliente("Fernando", false, true));

Console.WriteLine("Estado inicial:");
sistema.MostrarEstado();

Console.WriteLine("\nAtendiendo clientes:");

while (sistema.HayClientes())
{
    Cliente cliente = sistema.AtenderCliente();
    Console.WriteLine("Atendido: " + cliente);
}