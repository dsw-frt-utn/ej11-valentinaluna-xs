namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private static List<string> alumnos = new List<string>();

    public static void AgregarAlumno(string nombre)
    {
        alumnos.Add(nombre);
    }

    public static List<string> RetornarLista()
    {
        return alumnos;
    }

    public static string BuscarAlumno(string nombre)
    {
        if (alumnos.Contains(nombre))
        {
            return nombre;
        }
        else
        {
            return "No existe";
        }
    }

    public static bool EliminarAlumno(string nombre)
    {
        return alumnos.Remove(nombre);
    }

    public static void EliminarAlumnoPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }
    }
}
