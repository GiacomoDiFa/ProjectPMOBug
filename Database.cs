using MenuInterattivo.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MenuInterattivo
{
    class Database : IDatabase
    {
        private readonly string DBPath;
        private static Database instance;
        protected Database(string dataFile)
        {
            this.DBPath = dataFile;
        }
        public static Database GetInstance(string databaseFilePath)
        {
            if(instance == null)
            {
                instance = new Database(databaseFilePath);
            }
            return instance;
        }
        public List<Cibo> GetData()
        {
            List<Cibo> cibos = null;
            try
            { 
                JArray jsonArray = JArray.Parse(File.ReadAllText(DBPath));
                cibos = jsonArray.ToObject<List<Cibo>>();
            }
            catch (Exception)
            {
                cibos = new List<Cibo>();
            }
            return cibos;
        }
        public void SaveData(List<Cibo> cibos)
        {
            JArray cibosArray = new JArray(
                cibos.Select(i => new JObject
                {
                    {"Name",i.Name },
                    {"Description",i.Description },
                    {"Price",i.Price },
                })
            );
            File.WriteAllText(DBPath, cibosArray.ToString());
        }
    }
}