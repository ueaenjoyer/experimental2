using System;
using System.Collections.Generic;

class Navegador
{
    public string Nombre { get; private set; }
    public string Version { get; private set; }
    public PaginaWeb PaginaActual { get; private set; }
    private Stack<PaginaWeb> historialAtras;
    private Stack<PaginaWeb> historialAdelante;

    public Navegador(string nombre, string version, string urlInicial = "about:blank")
    {
        Nombre = nombre;
        Version = version;
        PaginaActual = new PaginaWeb(urlInicial, "Página de inicio");
        historialAtras = new Stack<PaginaWeb>();
        historialAdelante = new Stack<PaginaWeb>();
    }

    public void Navegar(string url, string titulo = null)
    {
        if (PaginaActual != null)
        {
            historialAtras.Push(PaginaActual);
        }
        
        PaginaActual = new PaginaWeb(url, titulo ?? url);
        historialAdelante.Clear();
        
        Console.WriteLine($"\nNavegando a: {PaginaActual.Titulo}");
        MostrarEstado();
    }

    public void IrAtras()
    {
        if (historialAtras.Count > 0)
        {
            historialAdelante.Push(PaginaActual);
            PaginaActual = historialAtras.Pop();
            Console.WriteLine("\nRetrocediendo...");
            MostrarEstado();
        }
        else
        {
            Console.WriteLine("\nNo hay páginas anteriores en el historial.");
        }
    }

    public void IrAdelante()
    {
        if (historialAdelante.Count > 0)
        {
            historialAtras.Push(PaginaActual);
            PaginaActual = historialAdelante.Pop();
            Console.WriteLine("\nAvanzando...");
            MostrarEstado();
        }
        else
        {
            Console.WriteLine("\nNo hay páginas siguientes en el historial.");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine("\n=== Estado del Navegador ===");
        Console.WriteLine($"Navegador: {Nombre} {Version}");
        Console.WriteLine($"Página actual: {PaginaActual}");
        Console.WriteLine($"Páginas atrás: {historialAtras.Count}");
        Console.WriteLine($"Páginas adelante: {historialAdelante.Count}");
        
        if (historialAtras.Count > 0)
        {
            Console.WriteLine("\nHistorial reciente:");
            int contador = 1;
            foreach (var pagina in historialAtras)
            {
                Console.WriteLine($"{contador++}. {pagina.Titulo} ({pagina.Url})");
            }
        }
        
        Console.WriteLine("==========================");
    }

    public void MostrarMenu()
    {
        Console.WriteLine("\n=== Menú del Navegador ===");
        Console.WriteLine("1. Navegar a una URL");
        Console.WriteLine("2. Ir Atrás");
        Console.WriteLine("3. Ir Adelante");
        Console.WriteLine("4. Mostrar estado actual");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");
    }
}