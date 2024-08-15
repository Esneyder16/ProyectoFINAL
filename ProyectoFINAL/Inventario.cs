using System.Collections.Generic;

public class Inventario
{
    public List<string> Objetos { get; set; }

    public Inventario()
    {
        Objetos = new List<string>();
    }

    public void AgregarObjeto(string objeto)
    {
        Objetos.Add(objeto);
        Console.WriteLine($"{objeto} ha sido agregado al inventario.");
    }

    public void UsarObjeto(string objeto)
    {
        if (Objetos.Contains(objeto))
        {
            Objetos.Remove(objeto);
            Console.WriteLine($"{objeto} ha sido usado.");
        }
        else
        {
            Console.WriteLine($"{objeto} no se encuentra en el inventario.");
        }
    }
}
