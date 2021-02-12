using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class GassosaCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new Gassosa();
        }

        public string GetInfo()
        {
            return "Gassosa ";
        }
        public double GetPrice()
        {
            return 2.50;
        }
    }
}
