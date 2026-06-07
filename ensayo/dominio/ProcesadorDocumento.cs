namespace DocumentoStrategy.Dominio;

public class ProcesadorDocumento
{
    private IProcesamiento procesamiento;

    public ProcesadorDocumento(IProcesamiento procesamiento)
    {
        if (procesamiento == null)
        {
            throw new Exception("La estrategia no puede ser nula.");
        }

        this.procesamiento = procesamiento;
    }

    public void Procesar(Documento documento)
    {
        if (documento == null)
        {
            throw new Exception("El documento no puede ser nulo.");
        }

        this.procesamiento.Procesar(documento);
    }

    public void Procesar(Documento documento, IProcesamiento procesamiento)
    {
        if (documento == null)
        {
            throw new Exception("El documento no puede ser nulo.");
        }

        if (procesamiento == null)
        {
            throw new Exception("La estrategia no puede ser nula.");
        }

        procesamiento.Procesar(documento);
    }

    public void CambiarProcesamiento(IProcesamiento procesamiento)
    {
        if (procesamiento == null)
        {
            throw new Exception("La estrategia no puede ser nula.");
        }

        this.procesamiento = procesamiento;
    }
}