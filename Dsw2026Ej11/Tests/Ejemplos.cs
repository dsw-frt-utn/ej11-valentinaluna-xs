using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary.AgregarAlumno(57892,"Valentina Luna");
        CasoDictionary.AgregarAlumno(57893,"Javier Paz");
        CasoDictionary.AgregarAlumno(57894,"Ana García");
        Console.WriteLine("Alumnos:");
        foreach (var alumno in CasoDictionary.RetornarDiccionario())
        {
            Console.WriteLine($"Legajo: {alumno.Key}, Nombre: {alumno.Value}");
        }       
        Console.WriteLine("\nBuscar alumno por legajo 57893:");
        foreach (var alumno in CasoDictionary.RetornarDiccionario())
        {
            if (alumno.Key == 57893)
            {
                Console.WriteLine($"Legajo: {alumno.Key}, Nombre: {alumno.Value}");
            }
        }
        Console.WriteLine("\nBuscar alumno por legajo 57895:");
        foreach (var alumno in CasoDictionary.RetornarDiccionario())
        {
            if (alumno.Key == 57895)
            {
                Console.WriteLine($"Legajo: {alumno.Key}, Nombre: {alumno.Value}");
            }
            else
            {
                Console.WriteLine("No existe");
                break;
            }
        }
        Console.WriteLine("\nEliminar alumno por legajo 57892:");
        CasoDictionary.EliminarAlumno(57892);
        Console.WriteLine("Alumnos:");
        foreach (var alumno in CasoDictionary.RetornarDiccionario())
        {
            Console.WriteLine($"Legajo: {alumno.Key}, Nombre: {alumno.Value}");
        }



    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
