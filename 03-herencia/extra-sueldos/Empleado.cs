public abstract class Empleado
{
    public abstract double Neto { get; }

    public double CalcularBonoPresentismo(int faltas, char tipo)
    {
        if (tipo == 'A' || tipo == 'a')
        {
            if (faltas == 0) return 1000;
            if (faltas == 1) return 450;
            return 0;
        }
        return 500;
    }

    public double CalcularBonoResultado(string resultado)
    {
        return resultado switch
        {
            "100" => Neto * 0.10,
            "80"  => 800,
            _     => 0
        };
    }

    public double Sueldo(int faltas, char tipoBono, string resultado)
    {
        return Neto
             + CalcularBonoPresentismo(faltas, tipoBono)
             + CalcularBonoResultado(resultado);
    }
}