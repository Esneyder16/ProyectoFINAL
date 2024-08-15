using System;

public class Program
{
    static void Main(string[] args)
    {
        // Crear personajes
        Personaje heroe = new Personaje("Héroe", "El valiente héroe del reino.", "Héroe");
        Personaje dragon = new Personaje("Dragón", "El dragón malvado que amenaza al reino.", "Villano");

        // Crear nodos de la historia
        Nodo nodoInicio = new Nodo(
            "El héroe acepta la misión.",
            heroe.Nombre + ": Debo salvar al reino, aunque me cueste la vida."
        );

        Nodo nodoEntrenamiento = new Nodo(
            "El héroe decide entrenar con el Mentor.",
            heroe.Nombre + ": Debo prepararme para enfrentar al dragón."
        );

        Nodo nodoLucha = new Nodo(
            "El héroe lucha contra el dragón.",
            dragon.Nombre + ": ¡No tienes ninguna oportunidad contra mí!"
        );

        Nodo nodoIgnoraEntrenamiento = new Nodo(
            "El héroe ignora el entrenamiento.",
            heroe.Nombre + ": No tengo tiempo para entrenar, debo enfrentar al dragón ahora"
        );

        Nodo nodoVictoria = new Nodo(
            "El héroe derrota al dragón y salva el reino.",
            heroe.Nombre + ": ¡He vencido al dragón y el reino está a salvo!"
        );

        Nodo nodoDerrota = new Nodo(
            "El héroe es derrotado por el dragón.",
            dragon.Nombre + ": ¡Ja, ja, ja! Ahora el reino es mío."
        );

        Nodo nodoCamino = new Nodo(
            "El héroe encuentra dos caminos que llevan al dragon",
            heroe.Nombre + ": Que camino deberia elegir?..."
            );

        Nodo nodoCueva = new Nodo(
            "El héroe se adentra en una cueva y encuentra la espada en la piedra",
            heroe.Nombre + ": La Espada legendaria!"
            );

        Nodo nodoConEspada = new Nodo(
            "El héroe obtiene la espada en la piedra y se dirige directo al dragon",
            heroe.Nombre + ": Con la Espada legendaria no perderé"
            );
        Nodo nodoSinEspada = new Nodo(
            "El heroe decide no tomar la espada y dirigirse directo al dragon",
            heroe.Nombre + ": No necesito de artefactos para derrotar al dragon");

        // Establecer las opciones de los nodos
        nodoInicio.Izquierda = nodoEntrenamiento;
        nodoInicio.Derecha = nodoIgnoraEntrenamiento;
        nodoEntrenamiento.Izquierda = nodoVictoria;
        nodoEntrenamiento.Derecha = nodoDerrota;
        nodoIgnoraEntrenamiento.Izquierda = nodoCamino;
        nodoIgnoraEntrenamiento.Derecha = nodoLucha;
        nodoCamino.Izquierda = nodoLucha;
        nodoCamino.Derecha = nodoCueva;
        nodoCueva.Izquierda = nodoConEspada;
        nodoCueva.Derecha = nodoSinEspada;
        nodoConEspada.Izquierda = nodoVictoria;
        nodoConEspada.Derecha = nodoVictoria;
        nodoSinEspada.Izquierda = nodoDerrota;
        nodoSinEspada.Derecha = nodoDerrota;
        nodoLucha.Izquierda = nodoVictoria;
        nodoLucha.Derecha = nodoDerrota;

        // Crear historia
        Historia historia = new Historia(nodoInicio);

        // Iniciar historia
        historia.Iniciar();
    }
}
