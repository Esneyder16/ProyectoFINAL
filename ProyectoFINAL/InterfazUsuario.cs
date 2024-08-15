using System;
using System.Collections.Generic;

public class InterfazUsuario
{
    public List<string> OpcionesMenu { get; set; }

    public InterfazUsuario()
    {
        OpcionesMenu = new List<string> { "Iniciar Juego", "Cargar Juego", "Salir" };
    }

    public void MostrarMenu()
    {
        Console.WriteLine("Menú Principal:");
        for (int i = 0; i < OpcionesMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {OpcionesMenu[i]}");
        }
    }

    public int RecibirEntrada()
    {
        Console.Write("Selecciona una opción: ");
        return int.Parse(Console.ReadLine());
    }
}
