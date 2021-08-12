using System;
using System.Collections.Generic;
using System.Text;

namespace atv1
{
    class Retangulo : FiguraGeometrica
    {
        public double Altura { get; set; }
        public double Base { get; set; }


        public override string QuemSouEu => "sou um retângulo";
        

        public override double CalcularArea()
        {
            return (this.Base * this.Altura);
        }

    }
}
