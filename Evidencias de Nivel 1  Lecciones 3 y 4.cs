using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Ruta del archivo PDF a crear
        string pdfPath = "InformeNivel1.pdf";

        // Crear un documento nuevo
        Document document = new Document();
        PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

        // Abrir el documento
        document.Open();

        // Encabezado
        document.Add(new Paragraph("INFORME RESUMIDO"));
        document.Add(new Paragraph("Nombre de la Asignatura: Programador C# - ID: 12345"));
        document.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy")));
        document.Add(new Paragraph("Asunto: Resumen de las Lecciones 3 y 4 del Nivel 1"));
        document.Add(new Paragraph("\nDescripción del Informe:"));
        document.Add(new Paragraph("Este informe proporciona un resumen de los contenidos clave cubiertos en las Lecciones 3 y 4 del Nivel 1, junto con los resultados de las actividades prácticas realizadas."));

        // Espacio en blanco
        document.Add(new Paragraph("\n"));

        // Resumen de contenidos
        document.Add(new Paragraph("Resumen de Contenido:"));
        document.Add(new Paragraph("Lección 3 cubre conceptos fundamentales de la programación en C#, como estructuras de control de flujo, incluyendo condicionales y bucles. Se explican los conceptos de 'if', 'else', 'switch', y las estructuras repetitivas como 'for' y 'while'. En la lección 4, se introduce la programación orientada a objetos, enfatizando la creación de clases, objetos, propiedades y métodos."));
        document.Add(new Paragraph("\nEn estas lecciones, se proporcionaron ejemplos prácticos de cómo utilizar las estructuras de control para tomar decisiones y repetir acciones en un programa. También se abordó la importancia de la encapsulación y cómo utilizar clases y objetos para modelar problemas del mundo real."));

        // Espacio en blanco
        document.Add(new Paragraph("\n"));

        // Resultados de las actividades
        document.Add(new Paragraph("Resultados de las Actividades Prácticas:"));
        document.Add(new Paragraph("En la actividad práctica de la Lección 3, se desarrolló un programa que pide al usuario ingresar un número y determina si es par o impar utilizando una estructura condicional. El fragmento de código utilizado es el siguiente:"));

        // Fragmento de código
        string codeSnippet = @"
        int numero;
        Console.WriteLine(""Ingrese un número:"");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine(""El número es par."");
        }
        else
        {
            Console.WriteLine(""El número es impar."");
        }";

        // Añadir fragmento de código al PDF
        document.Add(new Paragraph(codeSnippet));

        // Cierre del documento
        document.Close();

        Console.WriteLine("Informe generado exitosamente en " + pdfPath);
    }
}
