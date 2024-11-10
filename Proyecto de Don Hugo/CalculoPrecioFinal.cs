using System;

class CalculoPrecioFinal
{
    static void Main()
    {
        Console.WriteLine("Cálculo del Precio Final - Bodega DON HUGO");

        // Ingresar precio de costo del producto
        Console.Write("Ingrese el precio de costo del producto: ");
        double precioCosto = Convert.ToDouble(Console.ReadLine());

        // Ingresar porcentaje de ganancia deseado
        Console.Write("Ingrese el porcentaje de ganancia deseado: ");
        double porcentajeGanancia = Convert.ToDouble(Console.ReadLine());

        // Calcular monto de ganancia
        double montoGanancia = precioCosto * porcentajeGanancia / 100;

        // Calcular precio final
        double precioFinal = precioCosto + montoGanancia;

        // Mostrar precio final
        Console.WriteLine($"El precio final del producto es: {precioFinal:C2}");

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}