using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    interface IBuilderBevanda
    {
        public void CreaAcqua();
        public void CreaBirra();
        public void CreaCocaCola();
        public void CreaFanta();
        public void CreaGassosa();
        public void CreaGhiaccio();
        public void CreaLimone();
        public void CreaVino();
    }
}
