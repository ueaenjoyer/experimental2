using System;

class PaginaWeb
{
    public string Url { get; private set; }
    public string Titulo { get; private set; }
    public DateTime FechaVisita { get; private set; }

    public PaginaWeb(string url, string titulo = null)
    {
        if (string.IsNullOrWhiteSpace(url))
            throw new ArgumentException("La URL no puede estar vacía", nameof(url));

        Url = url;
        Titulo = titulo ?? "Sin título";
        FechaVisita = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Titulo} ({Url}) - Visitada: {FechaVisita:g}";
    }

    public override bool Equals(object obj)
    {
        return obj is PaginaWeb pagina &&
               Url == pagina.Url;
    }

    public override int GetHashCode()
    {
        return Url.GetHashCode();
    }
}