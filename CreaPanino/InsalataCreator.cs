using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class InsalataCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new Insalata();
        }
        public string GetInfo()
        {
            return "Insalata ";
        }
        public double GetPrice()
        {
            return 0.50;
        }
    }
}
