using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Declarar variables
        int cantidadNotas = 0;
        int sumaNotas = 0;
        int nota = 0;
        double promedio = 0;

        // Pedir la cantidad de notas
        Console.WriteLine("¿Cuántas notas deseas ingresar?");
        cantidadNotas = int.Parse(Console.ReadLine());

        // Bucle para pedir cada nota
        for (int i = 1; i <= cantidadNotas; i++)
        {
            Console.WriteLine("Introduce la nota #" + i);
            nota = int.Parse(Console.ReadLine());
            sumaNotas += nota;  // Sumar las notas ingresadas
        }

        // Calcular promedio
        promedio = (double)sumaNotas / cantidadNotas;

        // Determinar el mensaje a mostrar según el promedio
        if (promedio >= 7)
        {
            Console.WriteLine("Promovido");
        }
        else if (promedio >= 4 && promedio < 7)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }

        // Mostrar el promedio
        Console.WriteLine("El promedio es: " + promedio);
    }
}
