using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class SalamePiccanteCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new SalamePiccante();
        }

        public string GetInfo()
        {
            return "Salame Piccante ";
        }

        public double GetPrice()
        {
            return 2.00;
        }
    }
}
