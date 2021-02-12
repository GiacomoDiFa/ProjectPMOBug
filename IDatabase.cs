using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo
{
    public interface IDatabase
    {
        List<Cibo> GetData();
        void SaveData(List<Cibo> cibos);
    }
}
