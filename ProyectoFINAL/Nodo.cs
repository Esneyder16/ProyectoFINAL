using System;

public class Nodo
{
    public string Descripcion { get; set; }
    public string Dialogo { get; set; }
    public Nodo Izquierda { get; set; }  // Rama izquierda del árbol binario
    public Nodo Derecha { get; set; }    // Rama derecha del árbol binario

    public Nodo(string descripcion, string dialogo)
    {
        Descripcion = descripcion;
        Dialogo = dialogo;
    }

    public void MostrarDecision()
    {
        Console.WriteLine(Dialogo);
        Console.WriteLine(Descripcion);
        if (Izquierda != null && Derecha != null)
        {
            Console.WriteLine("1. Opción misteriosa"); // Opción 1 sin revelar
            Console.WriteLine("2. Opción misteriosa"); // Opción 2 sin revelar
        }
    }

    public Nodo ElegirOpcion(int opcion)
    {
        // Selección de la rama en el árbol binario según la opción elegida
        if (opcion == 1)
        {
            return Izquierda; // Avanza por la rama izquierda
        }
        else if (opcion == 2)
        {
            return Derecha;   // Avanza por la rama derecha
        }
        else
        {
            Console.WriteLine("Opción inválida.");
            return null;
        }
    }
}

