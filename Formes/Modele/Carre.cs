using System;

namespace Formes
{
    public class Carre : IForme
    {
        private readonly double cote;

        public Carre(double cote)
        {
            this.cote = cote;
        }

        public double perimetre()
        {
            return cote * 4;
        }

        public double aire()
        {
            return cote * cote;
        }

        public double volume()
        {
            throw new NotImplementedException();
        }
    }
}
