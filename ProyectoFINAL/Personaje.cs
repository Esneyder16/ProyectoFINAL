using System;
using System.Collections.Generic;

public class Personaje
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Tipo { get; set; }
    public List<string> Dialogos { get; set; } = new List<string>();

    public Personaje(string nombre, string descripcion, string tipo)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Tipo = tipo;
    }

    public void MostrarDialogo(int index)
    {
        if (index >= 0 && index < Dialogos.Count)
        {
            Console.WriteLine($"{Nombre}: {Dialogos[index]}");
        }
    }
}
