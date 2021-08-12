using System;
using System.Collections.Generic;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<FiguraGeometrica> figs = new List<FiguraGeometrica>();
           

            Triangulo tri1 = new Triangulo
            {
                Base = 2,
                Altura = 3
            };
            figs.Add(tri1);
            Triangulo tri2 = new Triangulo
            {
                Base = 2,
                Altura = 7
            };
            figs.Add(tri2);
            Triangulo tri3 = new Triangulo
            {
                Base = 4,
                Altura = 8
            };
            figs.Add(tri3);
            Retangulo ret1 = new Retangulo
            {
                Base = 2,
                Altura = 4
            };
            figs.Add(ret1);
            Retangulo ret2 = new Retangulo
            {
                Base = 8,
                Altura = 2
            };
            figs.Add(ret2);
            Retangulo ret3 = new Retangulo
            {
                Base = 6,
                Altura = 32
            };
            figs.Add(ret3);
            Circulo circ1 = new Circulo
            {
                Raio = 2
            };
            figs.Add(circ1);
            Circulo circ2 = new Circulo
            {
                Raio = 6
            };
            figs.Add(circ2);
            Circulo circ3 = new Circulo
            {
                Raio = 7
            };
            figs.Add(circ3);

            figs.ForEach(x => Console.WriteLine(x.QuemSouEu));

            figs.ForEach(z => Console.WriteLine(z.CalcularArea()));

        }
    }

}
