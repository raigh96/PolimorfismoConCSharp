using System;

namespace EjercicioPolimorfismo
{

    public class Lienzo
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Radius { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public virtual void Dibujar()
        {
            Console.WriteLine("Figura dibujada");
        }

    }
}
        
