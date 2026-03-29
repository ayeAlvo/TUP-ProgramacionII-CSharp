public class MotorolaG5 : CelularBase
{
    public override void Consumir(double duracionMin)
    {
        Bateria -= 0.25;
        if (Bateria < 0) Bateria = 0;
    }
}