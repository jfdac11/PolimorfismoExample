using System;
using System.Collections.Generic;
using System.Text;

namespace atv1
{
    abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
        public virtual string QuemSouEu => "Sou uma Figura Geometrica";
  
    }

}
