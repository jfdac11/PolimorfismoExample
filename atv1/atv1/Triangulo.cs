using System;
using System.Collections.Generic;
using System.Text;

namespace atv1
{
    class Triangulo : FiguraGeometrica
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public override string QuemSouEu => "sou um triangulo";

        public override double CalcularArea()
        {
            return (this.Base * this.Altura) / 2;
        }

    }
}
