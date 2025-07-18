# Simulador de Navegador Web

Este proyecto implementa un simulador de navegador web con funcionalidad de historial de navegación, incluyendo los botones de atrás y adelante, utilizando programación orientada a objetos en C#.

## Características

- Navegación a URLs personalizadas
- Historial de navegación con funcionalidad de atrás/adelante
- Nombres de navegadores basados en embarcaciones famosas
- Interfaz de consola interactiva
- Manejo de errores

## Estructura del Proyecto

- `Program.cs`: Punto de entrada de la aplicación y lógica del menú interactivo.
- `Navegador.cs`: Clase principal que maneja la lógica del navegador.
- `PaginaWeb.cs`: Clase que representa una página web individual.

## Estructuras de Datos Utilizadas

### 1. Stack (Pila)
**Uso en el proyecto**:
- `Stack<PaginaWeb> historialAtras`: Almacena las páginas visitadas para la función "Atrás".
- `Stack<PaginaWeb> historialAdelante`: Almacena las páginas para la función "Adelante".

#### Ventajas:
- **Eficiencia**: Operaciones O(1) para push y pop.
- **Simplicidad**: Fácil implementación para el patrón LIFO.
- **Uso de memoria**: Solo almacena referencias, no duplica datos.

#### Desventajas:
- **Acceso limitado**: Solo se puede acceder al elemento superior.
- **No permite búsqueda**: No es eficiente para buscar elementos específicos.

## Análisis de Tiempo de Ejecución

| Operación | Complejidad | Descripción |
|-----------|-------------|-------------|
| Navegar() | O(1) | Agrega la página actual al historial y limpia el historial adelante |
| IrAtras() | O(1) | Extrae la página del historialAtras y la coloca en historialAdelante |
| IrAdelante() | O(1) | Extrae la página del historialAdelante y la coloca en historialAtras |
| MostrarEstado() | O(n) | Donde n es el número de páginas en el historial atrás |

## Reportería

El sistema incluye las siguientes funcionalidades de reporte:

1. **Estado Actual del Navegador**
   - Nombre y versión del navegador
   - Página actual mostrando título, URL y fecha de visita
   - Contador de páginas disponibles en el historial atrás/adelante
   - Lista del historial reciente

2. **Visualización de Datos**
   - Formato claro y legible en la consola
   - Información detallada de cada página visitada
   - Feedback inmediato de las acciones realizadas

## Agente de IA Utilizado

- **Nombre del Agente**: Cascade
- **Porcentaje de Código Generado**: 50%
- **Descripción**: El agente Cascade fue utilizado para generar código del proyecto, incluyendo la estructura de clases y la interfaz de usuario.También se encargó de la documentación y el análisis de complejidad algorítmica.

## Requisitos del Sistema

- .NET 5.0 o superior
- Sistema operativo Windows, macOS o Linux
- Terminal o consola para ejecutar la aplicación

## Instrucciones de Uso

1. Clonar el repositorio
2. Navegar al directorio del proyecto
3. Ejecutar `dotnet run`
4. Seguir las instrucciones en pantalla

## Ejemplo de Uso

```
=== Simulador de Navegador Web ===
Bienvenido al Navegador Titanic
Configuración inicial:
Nombre del navegador (presione Enter para usar 'Titanic'): 

Iniciando Titanic v7.2...

=== Menú del Navegador ===
1. Navegar a una URL
2. Ir Atrás
3. Ir Adelante
4. Mostrar estado actual
5. Salir
Seleccione una opción: 
```

## Limitaciones

- Los datos no persisten después de cerrar la aplicación
- Interfaz de consola básica
- No incluye funcionalidad de búsqueda en el historial

## Mejoras Futuras

- Implementar persistencia de datos
- Agregar funcionalidad de búsqueda en el historial
- Mejorar la interfaz de usuario
- Añadir marcadores/favoritos
- Implementar pestañas de navegación
#
