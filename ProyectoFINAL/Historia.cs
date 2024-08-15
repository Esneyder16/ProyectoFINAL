using System;

public class Historia
{
    private Nodo raiz;

    public Historia(Nodo nodoRaiz)
    {
        raiz = nodoRaiz;  // Raíz del árbol binario
    }

    public void Iniciar()
    {
        Nodo nodoActual = raiz;

        while (nodoActual != null)
        {
            Console.WriteLine("\nLa historia continúa...");
            nodoActual.MostrarDecision();

            if (nodoActual.Izquierda != null && nodoActual.Derecha != null)
            {
                Console.WriteLine("Elige una opción (1 o 2):");
                string eleccion = Console.ReadLine();

                if (int.TryParse(eleccion, out int opcion))
                {
                    // Avanza por el árbol binario según la opción seleccionada
                    nodoActual = nodoActual.ElegirOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                Console.WriteLine("Fin de la historia.");
                nodoActual = null;  // Finaliza la historia cuando no hay más ramas en el árbol
            }
        }
    }
}
