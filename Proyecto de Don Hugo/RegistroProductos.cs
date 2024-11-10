using System;

class RegistroProductos
{
    static void Main()
    {
        Console.WriteLine("Registro de Productos - Bodega DON HUGO");

        // Crear un arreglo para almacenar 10 productos
        string[] productos = new string[10];

        // Registrar 10 productos
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el nombre del producto {i + 1}: ");
            productos[i] = Console.ReadLine();
        }

        // Mostrar los productos registrados
        Console.WriteLine("\nProductos registrados:");
        for (int i = 0; i < productos.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i]}");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}