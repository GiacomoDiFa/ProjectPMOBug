using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class MaioneseCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new Maionese();
        }
        public string GetInfo()
        {
            return "Maionese ";
        }
        public double GetPrice()
        {
            return 0.50;
        }
    }
}
