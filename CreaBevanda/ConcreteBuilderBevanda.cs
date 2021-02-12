using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class ConcreteBuilderBevanda : IBuilderBevanda
    {
        private Bevanda bevanda;
        private IComponenteCreator[] componenteCreatorArray = new IComponenteCreator[8];
        public ConcreteBuilderBevanda()
        {
            this.Reset();
            componenteCreatorArray[0] = new AcquaCreator();
            componenteCreatorArray[1] = new BirraCreator();
            componenteCreatorArray[2] = new CocaColaCreator();
            componenteCreatorArray[3] = new FantaCreator();
            componenteCreatorArray[4] = new GassosaCreator();
            componenteCreatorArray[5] = new GhiaccioCreator();
            componenteCreatorArray[6] = new LimoneCreator();
            componenteCreatorArray[7] = new VinoCreator();
        }
        private void Reset()
        {
            this.bevanda = new Bevanda();
        }
        public void CreaAcqua()
        {
            this.bevanda.Add(componenteCreatorArray[0].FactoryMethod());
        }

        public void CreaBirra()
        {
            this.bevanda.Add(componenteCreatorArray[1].FactoryMethod());
        }

        public void CreaCocaCola()
        {
            this.bevanda.Add(componenteCreatorArray[2].FactoryMethod());
        }

        public void CreaFanta()
        {
            this.bevanda.Add(componenteCreatorArray[3].FactoryMethod());
        }

        public void CreaGassosa()
        {
            this.bevanda.Add(componenteCreatorArray[4].FactoryMethod());
        }

        public void CreaGhiaccio()
        {
            this.bevanda.Add(componenteCreatorArray[5].FactoryMethod());
        }

        public void CreaLimone()
        {
            this.bevanda.Add(componenteCreatorArray[6].FactoryMethod());
        }

        public void CreaVino()
        {
            this.bevanda.Add(componenteCreatorArray[7].FactoryMethod());
        }
        public Bevanda GetBevanda()
        {
            Bevanda bevandaFinale = this.bevanda;
            this.Reset();
            return bevandaFinale;
        }
    }
}
