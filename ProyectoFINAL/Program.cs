using System;

public class Program
{
    static void Main(string[] args)
    {
        // Crear personajes
        Personaje heroe = new Personaje("Héroe", "El valiente héroe del reino.", "Héroe");
        Personaje dragon = new Personaje("Dragón", "El dragón malvado que amenaza al reino.", "Villano");
        Personaje mentor = new Personaje("Mentor", "El sabio mentor que ofrece entrenamiento al héroe.", "Guía");
        Personaje aldeano = new Personaje("Aldeano", "Un aldeano que ofrece pistas sobre el dragón.", "Informante");

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
            heroe.Nombre + ": No tengo tiempo para entrenar, debo enfrentar al dragón ahora."
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
            "El héroe encuentra dos caminos que llevan al dragón.",
            heroe.Nombre + ": ¿Qué camino debería elegir?..."
        );

        Nodo nodoCueva = new Nodo(
            "El héroe se adentra en una cueva y encuentra la espada en la piedra.",
            heroe.Nombre + ": ¡La espada legendaria!"
        );

        Nodo nodoConEspada = new Nodo(
            "El héroe obtiene la espada en la piedra y se dirige directo al dragón.",
            heroe.Nombre + ": Con la espada legendaria no perderé."
        );

        Nodo nodoSinEspada = new Nodo(
            "El héroe decide no tomar la espada y dirigirse directo al dragón.",
            heroe.Nombre + ": No necesito artefactos para derrotar al dragón."
        );

        // Nuevos nodos
        Nodo nodoAldeano = new Nodo(
            "El héroe se encuentra con un aldeano que le ofrece información sobre el dragón.",
            aldeano.Nombre + ": El dragón tiene un punto débil en su estómago. ¡Apunta allí!"
        );

        Nodo nodoBosque = new Nodo(
            "El héroe entra en un bosque oscuro lleno de trampas.",
            heroe.Nombre + ": Este lugar parece peligroso. Debo tener cuidado."
        );

        Nodo nodoTrampa = new Nodo(
            "El héroe cae en una trampa, pero logra escapar.",
            heroe.Nombre + ": ¡Eso fue demasiado cerca! Ahora debo seguir con más cautela."
        );

        Nodo nodoCuevaConTrampa = new Nodo(
            "El héroe entra en la cueva y encuentra una trampa que debe evitar.",
            heroe.Nombre + ": ¡Casi caigo en una trampa! Pero ahora encuentro la espada."
        );

        Nodo nodoEncuentro = new Nodo(
            "El héroe se encuentra con el Mentor nuevamente.",
            mentor.Nombre + ": Parece que has encontrado la espada. Ahora ve y derrota al dragón."
        );

        Nodo nodoFuerza = new Nodo(
            "El héroe decide entrenar más para ganar más fuerza.",
            heroe.Nombre + ": Necesito más entrenamiento para tener una oportunidad contra el dragón."
        );

        // Establecer las opciones de los nodos
        nodoInicio.Izquierda = nodoEntrenamiento;
        nodoInicio.Derecha = nodoIgnoraEntrenamiento;
        nodoEntrenamiento.Izquierda = nodoFuerza;
        nodoEntrenamiento.Derecha = nodoCamino;
        nodoFuerza.Izquierda = nodoVictoria;
        nodoFuerza.Derecha = nodoDerrota;
        nodoIgnoraEntrenamiento.Izquierda = nodoCamino;
        nodoIgnoraEntrenamiento.Derecha = nodoLucha;
        nodoCamino.Izquierda = nodoBosque;
        nodoCamino.Derecha = nodoCueva;
        nodoBosque.Izquierda = nodoTrampa;
        nodoBosque.Derecha = nodoCueva;
        nodoTrampa.Izquierda = nodoCueva;
        nodoCueva.Izquierda = nodoCuevaConTrampa;
        nodoCueva.Derecha = nodoSinEspada;
        nodoCuevaConTrampa.Izquierda = nodoConEspada;
        nodoCuevaConTrampa.Derecha = nodoDerrota;
        nodoConEspada.Izquierda = nodoEncuentro;
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