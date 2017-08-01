using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPolimorfismo
{
    class Cuadrado : Lienzo
    {
        public override void Dibujar()
        {
            Console.WriteLine("Creando cuadrado");
            base.Dibujar();
        }

    }


}
