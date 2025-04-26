using System;

namespace Formes
{
    public class Cercle : IForme
    {
        private readonly double rayon;

        public Cercle(double rayon)
        {
            this.rayon = rayon;
        }

        public double perimetre()
        {
            return 2 * Math.PI * rayon;
        }

        public double aire()
        {
            return Math.PI * Math.Pow(rayon, 2);
        }

        public double volume()
        {
            throw new NotImplementedException();
        }
    }
}
