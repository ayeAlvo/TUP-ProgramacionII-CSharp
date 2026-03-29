class Program
{
    static void Main()
    {
        Empleado g = new Gerente();
        Empleado a = new Administrativo();
        Empleado o = new Operador();
        Empleado c = new Cadete();

        Console.WriteLine("Gerente sin faltas, bono A, objetivo 100%:");
        Console.WriteLine("$" +g.Sueldo(0, 'A', "100"));

        Console.WriteLine("Administrativo, 1 falta, bono A, 80% objetivo:");
        Console.WriteLine("$" +a.Sueldo(1, 'A', "80"));

        Console.WriteLine("Operador, 2 faltas, bono B, sin objetivo:");
        Console.WriteLine("$" +o.Sueldo(2, 'B', "0"));

        Console.WriteLine("Cadete, 0 faltas, bono B, objetivo 100%:");
        Console.WriteLine("$" +c.Sueldo(0, 'B', "100"));
    }
}