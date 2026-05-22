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
        CasoList.AgregarAlumno("Valentina Luna");
        CasoList.AgregarAlumno("Javier Paz");
        CasoList.AgregarAlumno("Ana Maria");
        Console.WriteLine("Alumnos:");
        foreach (string alumno in CasoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("Alumno que existe");
        string resultado1 = CasoList.BuscarAlumno("Valentina Luna");
        
        Console.WriteLine(resultado1);
        Console.WriteLine(" Alumno que NO existe");
        string resultado2 = CasoList.BuscarAlumno("Lucas Roldán");
        Console.WriteLine(resultado2);

        Console.WriteLine("Eliminar a Javier Paz");
        CasoList.EliminarAlumno("Javier Paz");
        foreach (string alumno in CasoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("Eliminando el primer elemento");
        CasoList.EliminarAlumnoPorPosicion(0);
        foreach (string alumno in CasoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        
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
        List<Libro> list = new List<Libro>() {
        new Libro { Id = 1, Titulo = "El principito", Precio = 20000},
        new Libro { Id = 2, Titulo = "Don Quijote", Precio = 35000},
        new Libro { Id = 3, Titulo = "Cien años de soledad", Precio = 15000}

        };
        Console.WriteLine("Primer libro:");
        Console.WriteLine(CasoLinq.GetPrimero(list).Titulo);

        Console.WriteLine("Ultimo libro:");
        Console.WriteLine(CasoLinq.GetUltimo(list).Titulo);

        Console.WriteLine("Total precios:");
        Console.WriteLine(CasoLinq.GetTotalPrecios(list));

        Console.WriteLine("Promedio precios:");
        Console.WriteLine(CasoLinq.GetPromedioPrecios(list));

        Console.WriteLine("Libros ordenados por Id:");
        foreach (Libro libro in CasoLinq.GetListById(list))
        {
            Console.WriteLine(libro.Titulo);
        }

        Console.WriteLine("Titulos de los libros:");
        foreach (string libro in CasoLinq.GetLibros(list))
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("Libro con mayor precio:");
        Console.WriteLine(CasoLinq.GetMayorPrecio(list).Titulo);

        Console.WriteLine("Libro con menor precio:");
        Console.WriteLine(CasoLinq.GetMenorPrecio(list).Titulo);

        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (Libro libro in CasoLinq.GetMayorPromedio(list))
        {
            Console.WriteLine(libro.Titulo);
        }

        Console.WriteLine("Libros ordenados por precio:");
        foreach (Libro libro in CasoLinq.GetLibrosOrdenados(list))
        {
            Console.WriteLine(libro.Titulo);
        }

    }
    

}
