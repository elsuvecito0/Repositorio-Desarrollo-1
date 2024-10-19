using System;

class Program
{
    static void Main()
    {
        // Declaración e inicialización del array
        int[] calificaciones = { 85, 90, 78, 92, 88 };

        // Cálculo del promedio
        int suma = 0;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            suma += calificaciones[i];
        }

        double promedio = suma / (double)calificaciones.Length;

        // Mostrar el promedio
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}
