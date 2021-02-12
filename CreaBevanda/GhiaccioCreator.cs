using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class GhiaccioCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new Ghiaccio();
        }
        public string GetInfo()
        {
            return "Ghiaccio ";
        }

        public double GetPrice()
        {
            return 0.50;
        }
    }
}
