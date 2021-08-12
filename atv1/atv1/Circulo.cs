using System;
using System.Collections.Generic;
using System.Text;

namespace atv1
{
    class Circulo : FiguraGeometrica
    {
        public double Raio { get; set; }

        public override string QuemSouEu => "sou um circulo";
        

        public override double CalcularArea()
        {
            return (3.14159 * this.Raio * this.Raio);
        }

    }
}
