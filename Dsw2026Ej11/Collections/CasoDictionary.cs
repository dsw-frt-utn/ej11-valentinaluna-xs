namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private static Dictionary<int, string> alumnos = new Dictionary<int, string>();
    public static void AgregarAlumno(int legajo, string nombre)
    {
        if (!alumnos.ContainsKey(legajo))
        {
            alumnos.Add(legajo, nombre);
        }
        else
        {
            Console.WriteLine("El legajo ya existe. No se puede agregar el alumno.");   
        }

    }
    public static string BuscarAlumno(int legajo)
    {
        if (alumnos.TryGetValue(legajo, out string nombre))
        {
            return nombre;
        }
        else
        {
            return "No existe";
        }
    }
    public static Dictionary<int, string> RetornarDiccionario()
    {
        return alumnos;
    }
    public static bool EliminarAlumno(int legajo)
    {
        return alumnos.Remove(legajo);
    }
}
