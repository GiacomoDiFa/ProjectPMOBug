using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class BirraCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new Birra();
        }

        public string GetInfo()
        {
            return "Birra ";
        }
        public double GetPrice()
        {
            return 3.00;
        }
    }
}
