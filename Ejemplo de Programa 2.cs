using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creación de una lista de calificaciones
        List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };

        // Añadir una nueva calificación
        calificaciones.Add(95);

        // Modificar una calificación existente
        calificaciones[2] = 80;

        // Eliminar una calificación
        calificaciones.Remove(88);

        // Mostrar las calificaciones actualizadas
        Console.WriteLine("Calificaciones actualizadas:");
        foreach (int calificacion in calificaciones)
        {
            Console.WriteLine(calificacion);
        }

        // Calcular el promedio de las calificaciones
        int suma = 0;
        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }
        
        double promedio = suma / (double)calificaciones.Count;

        // Mostrar el promedio
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}
