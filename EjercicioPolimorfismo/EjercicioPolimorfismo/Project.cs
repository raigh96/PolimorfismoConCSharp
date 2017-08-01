using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lienzo cuadrado = new Cuadrado();
            Lienzo circulo = new Circulo();

            cuadrado.Dibujar();
            circulo.Dibujar();

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
