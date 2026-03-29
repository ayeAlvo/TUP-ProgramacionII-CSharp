public class Iphone : CelularBase
{
    public override void Consumir(double duracionMin)
    {
        var consumo = duracionMin * 0.001; // 0.1% = 0.001
        Bateria -= consumo;
        if (Bateria < 0) Bateria = 0;
    }
}