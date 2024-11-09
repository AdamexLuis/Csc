using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        CalcularSalario();
    }

    /// <summary>
    /// Calcular el salario de un empleado
    /// </summary>

    private static void CalcularSalario()
    {
        // Declarar sus variables de entrada // 
        int num1 = 0;
        int num2 = 0;
        int suma = 0;
        int producto = 0;

        //pedir numeros por teclado//
        Console.WriteLine("Ingrese el vlaor de Num 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de Num 2");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Calcular la suma y el producto.
        suma = (num1 + num2);
        producto = (num1 * num2);

        // Imprimir valores.

        Console.WriteLine($"La suma es: {suma} y el produucto es: {producto}");
    }

}