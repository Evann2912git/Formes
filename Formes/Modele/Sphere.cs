using System;

namespace Formes
{
    public class Sphere : IForme
    {
        private readonly double rayon;

        public Sphere(double rayon)
        {
            this.rayon = rayon;
        }

        public double perimetre()
        {
            throw new NotImplementedException();
        }

        public double aire()
        {
            return 4 * Math.PI * Math.Pow(rayon, 2);
        }

        public double volume()
        {
            return (4 * Math.PI * Math.Pow(rayon, 3)) / 3;
        }
    }
}
