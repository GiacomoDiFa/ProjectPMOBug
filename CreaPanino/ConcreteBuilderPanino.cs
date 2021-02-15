using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class ConcreteBuilderPanino : IBuilderPanino
    {
        private Panino panino;
        private IIngredienteCreator[] ingredientiCreatorArray = new IIngredienteCreator[9];
        public ConcreteBuilderPanino()
        {
            this.Reset();
            ingredientiCreatorArray[0] = new HamburgerCreator();
            ingredientiCreatorArray[1] = new HotDogCreator();
            ingredientiCreatorArray[2] = new InsalataCreator();
            ingredientiCreatorArray[3] = new KetchupCreator();
            ingredientiCreatorArray[4] = new MaioneseCreator();
            ingredientiCreatorArray[5] = new PolloCreator();
            ingredientiCreatorArray[6] = new PomodoroCreator();
            ingredientiCreatorArray[7] = new ProsciuttoCottoCreator();
            ingredientiCreatorArray[8] = new SottilettaCreator();
        }
        private void Reset()
        {
            this.panino = new Panino();
        }
        public void CreaHamgurger()
        {
            this.panino.Add(ingredientiCreatorArray[0].FactoryMethod());
        }
        public void CreaHotDog()
        {
            this.panino.Add(ingredientiCreatorArray[1].FactoryMethod());
        }
        public void CreaInsalata()
        {
            this.panino.Add(ingredientiCreatorArray[2].FactoryMethod());
        }
        public void CreaKetchup()
        {
            this.panino.Add(ingredientiCreatorArray[3].FactoryMethod());
        }
        public void CreaMaionese()
        {
            this.panino.Add(ingredientiCreatorArray[4].FactoryMethod());
        }
        public void CreaPollo()
        {
            this.panino.Add(ingredientiCreatorArray[5].FactoryMethod());
        }
        public void CreaPomodoro()
        {
            this.panino.Add(ingredientiCreatorArray[6].FactoryMethod());
        }
        public void CreaProsciuttoCotto()
        {
            this.panino.Add(ingredientiCreatorArray[7].FactoryMethod());
        }
        public void CreaSottiletta()
        {
            this.panino.Add(ingredientiCreatorArray[8].FactoryMethod());
        }
        public Panino GetPanino()
        {
            Panino paninoFinale = this.panino;
            this.Reset();
            return paninoFinale;
        }
    }
}