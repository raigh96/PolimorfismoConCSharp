using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPolimorfismo
{
    class Circulo : Lienzo
    {

        public override void Dibujar()
        {
            Console.WriteLine("Creando circulo");
            base.Dibujar();
        }
    }
}
