using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Ruta del archivo PDF a crear
        string pdfPath = "InformeNivel2.pdf";

        // Crear un documento nuevo
        Document document = new Document();
        PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

        // Abrir el documento
        document.Open();

        // Encabezado
        document.Add(new Paragraph("INFORME RESUMIDO"));
        document.Add(new Paragraph("Nombre de la Asignatura: Programador C# - ID: 12345"));
        document.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy")));
        document.Add(new Paragraph("Asunto: Resumen de las Lecciones 1 y 2 del Nivel 2"));
        document.Add(new Paragraph("\nDescripción del Informe:"));
        document.Add(new Paragraph("Este informe proporciona un resumen de los contenidos clave cubiertos en las Lecciones 1 y 2 del Nivel 2, junto con los resultados de las actividades prácticas realizadas."));

        // Espacio en blanco
        document.Add(new Paragraph("\n"));

        // Resumen de contenidos
        document.Add(new Paragraph("Resumen de Contenido:"));
        document.Add(new Paragraph("La Lección 1 del Nivel 2 se centra en la manipulación de cadenas de texto en C#. Se exploran métodos comunes como 'Substring', 'IndexOf', 'Replace', entre otros. También se ve cómo concatenar cadenas y realizar operaciones con ellas para trabajar con datos dinámicos en los programas."));
        document.Add(new Paragraph("En la Lección 2, se introducen los arreglos (arrays), que permiten almacenar múltiples valores en una sola variable. Se discuten las operaciones básicas con arreglos, como la declaración, inicialización, acceso y modificación de elementos. Además, se explican métodos importantes para recorrer arreglos y realizar cálculos con ellos."));
        
        // Espacio en blanco
        document.Add(new Paragraph("\n"));

        // Resultados de las actividades
        document.Add(new Paragraph("Resultados de las Actividades Prácticas:"));
        document.Add(new Paragraph("En la actividad práctica de la Lección 1, se desarrolló un programa para buscar una subcadena dentro de una cadena ingresada por el usuario. El fragmento de código utilizado es el siguiente:"));

        // Fragmento de código para la actividad de cadenas
        string codeSnippet1 = @"
        string texto, subcadena;
        Console.WriteLine(""Ingrese un texto:"");
        texto = Console.ReadLine();
        Console.WriteLine(""Ingrese la subcadena a buscar:"");
        subcadena = Console.ReadLine();

        if (texto.Contains(subcadena))
        {
            Console.WriteLine(""La subcadena existe en el texto."");
        }
        else
        {
            Console.WriteLine(""La subcadena no existe en el texto."");
        }";

        // Añadir fragmento de código al PDF
        document.Add(new Paragraph(codeSnippet1));

        // Espacio en blanco
        document.Add(new Paragraph("\n"));

        document.Add(new Paragraph("En la actividad práctica de la Lección 2, se creó un programa que utiliza un arreglo para almacenar números enteros e imprime la suma de todos los elementos. El fragmento de código utilizado es el siguiente:"));

        // Fragmento de código para la actividad de arreglos
        string codeSnippet2 = @"
        int[] numeros = {1, 2, 3, 4, 5};
        int suma = 0;

        foreach (int numero in numeros)
        {
            suma += numero;
        }

        Console.WriteLine(""La suma de los números es: "" + suma);";

        // Añadir fragmento de código al PDF
        document.Add(new Paragraph(codeSnippet2));

        // Cierre del documento
        document.Close();

        Console.WriteLine("Informe generado exitosamente en " + pdfPath);
    }
}
