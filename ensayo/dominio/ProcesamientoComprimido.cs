namespace DocumentoStrategy.Dominio;

public class ProcesamientoComprimido : IProcesamiento
{
    public void Procesar(Documento documento)
    {
        Console.WriteLine("Procesando documento...");
        Console.WriteLine("Contenido: " + documento.GetContenido());
        Console.WriteLine("Comprimido");
    }
}