using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class LimoneCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new Limone();
        }

        public string GetInfo()
        {
            return "Limone ";
        }

        public double GetPrice()
        {
            return 0.50;
        }
    }
}
