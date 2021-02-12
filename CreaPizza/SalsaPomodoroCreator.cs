using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class SalsaPomodoroCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new SalsaPomodoro();
        }

        public string GetInfo()
        {
            return "Salsa di pomodoro";
        }

        public double GetPrice()
        {
            return 1.00;
        }
    }
}
