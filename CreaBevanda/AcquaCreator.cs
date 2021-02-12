using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class AcquaCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new Acqua();
        }
        public string GetInfo()
        {
            return "Acqua ";
        }
        public double GetPrice()
        {
            return 2.00;
        }
    }
}
