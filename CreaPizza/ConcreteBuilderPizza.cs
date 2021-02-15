using System;
using System.Collections.Generic;
using System.Text;
using MenuInterattivo.Model;

namespace MenuInterattivo.CreaPizza
{
    class ConcreteBuilderPizza:IBuilderPizza
    {
        private Pizza pizza;
        private ICondimentoCreator[] condimentiCreatorArray = new ICondimentoCreator[9];
        public ConcreteBuilderPizza()
        {
            this.Reset();
            condimentiCreatorArray[0] = new SalsaPomodoroCreator();
            condimentiCreatorArray[1] = new MozzarellaCreator();
            condimentiCreatorArray[2] = new PeperoneCreator();
            condimentiCreatorArray[3] = new SalsicciaCreator();
            condimentiCreatorArray[4] = new OlivaCreator();
            condimentiCreatorArray[5] = new SalamePiccanteCreator();
            condimentiCreatorArray[6] = new FungoCreator();
            condimentiCreatorArray[7] = new WustelCreator();
            condimentiCreatorArray[8] = new PatatinaCreator();
        }
        private void Reset()
        {
            this.pizza = new Pizza();
        }
        public void CreaSalsaPomodoro()
        {
            this.pizza.Add(condimentiCreatorArray[0].FactoryMethod());
        }
        public void CreaMozzarella()
        {
            this.pizza.Add(condimentiCreatorArray[1].FactoryMethod());
        }
        public void CreaPeperone()
        {
            this.pizza.Add(condimentiCreatorArray[2].FactoryMethod());
        }
        public void CreaSalsiccia()
        {
            this.pizza.Add(condimentiCreatorArray[3].FactoryMethod());
        }
        public void CreaOliva()
        {
            this.pizza.Add(condimentiCreatorArray[4].FactoryMethod());
        }
        public void CreaSalamePiccante()
        {
            this.pizza.Add(condimentiCreatorArray[5].FactoryMethod());
        }
        public void CreaFungo()
        {
            this.pizza.Add(condimentiCreatorArray[6].FactoryMethod());
        }
        public void CreaWustel()
        {
            this.pizza.Add(condimentiCreatorArray[7].FactoryMethod());
        }
        public void CreaPatatina()
        {
            this.pizza.Add(condimentiCreatorArray[8].FactoryMethod());
        }
        public Pizza GetPizza()
        {
            Pizza pizzaFinale = this.pizza;
            this.Reset();
            return pizzaFinale;
        }
    }
}