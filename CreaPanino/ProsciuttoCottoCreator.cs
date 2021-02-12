using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class ProsciuttoCottoCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new ProsciuttoCotto();
        }

        public string GetInfo()
        {
            return "Prosciutto Cotto ";
        }

        public double GetPrice()
        {
            return 1.50;
        }
    }
}
