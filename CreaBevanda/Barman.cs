using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class Barman
    {
        private IBuilderBevanda builder;
        public IBuilderBevanda Builder { set { builder = value; } }
        public void Acqua()
        {
            this.builder.CreaAcqua();
            this.builder.CreaGhiaccio();
        }
        public void Vino()
        {
            this.builder.CreaVino();
        }
        public void Birra()
        {
            this.builder.CreaBirra();
        }
        public void CocaCola()
        {
            this.builder.CreaCocaCola();
            this.builder.CreaGhiaccio();
            this.builder.CreaLimone();
        }
        public void Fanta()
        {
            this.builder.CreaFanta();
            this.builder.CreaGhiaccio();
            this.builder.CreaLimone();
        }
        public void Sprite()
        {
            this.builder.CreaGassosa();
            this.builder.CreaGhiaccio();
            this.builder.CreaLimone();
        }
    }
}
