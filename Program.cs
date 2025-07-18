using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Simulador de Navegador Web ===");
        
        // Nombres de embarcaciones famosas
        string[] embarcacionesFamosas = 
        {
            "Santa María", "Mayflower", "Titanic", "Queen Mary", "Cutty Sark",
            "Endeavour", "Bismarck", "Yamato", "Kon-Tiki", "Golden Hind"
        };
        
        // Seleccionar una embarcación al azar
        Random rnd = new Random();
        string nombreEmbarcacion = embarcacionesFamosas[rnd.Next(embarcacionesFamosas.Length)];
        
        Console.WriteLine($"Bienvenido al Navegador {nombreEmbarcacion}");
        Console.WriteLine("Configuración inicial:");
        
        Console.Write($"Nombre del navegador (presione Enter para usar '{nombreEmbarcacion}'): ");
        string nombre = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(nombre))
        {
            nombre = nombreEmbarcacion;
        }
        
        // Generar versión aleatoria (1.0 a 10.0)
        double versionNumero = Math.Round(1 + rnd.NextDouble() * 9, 1);
        string version = versionNumero.ToString("0.0");
        
        Console.WriteLine($"\nIniciando {nombre} v{version}...\n");
        
        var navegador = new Navegador(nombre, version);
        
        bool salir = false;
        while (!salir)
        {
            navegador.MostrarMenu();
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la URL a la que desea navegar: ");
                    string url = Console.ReadLine();
                    Console.Write("Ingrese un título para la página (opcional): ");
                    string titulo = Console.ReadLine();
                    
                    try
                    {
                        if (string.IsNullOrWhiteSpace(titulo))
                            navegador.Navegar(url);
                        else
                            navegador.Navegar(url, titulo);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"\nError: {ex.Message}");
                    }
                    break;
                    
                case "2":
                    navegador.IrAtras();
                    break;
                    
                case "3":
                    navegador.IrAdelante();
                    break;
                    
                case "4":
                    navegador.MostrarEstado();
                    break;
                    
                case "5":
                    salir = true;
                    Console.WriteLine("¡Gracias por usar el navegador!");
                    break;
                    
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
            
            if (!salir)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}