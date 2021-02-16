using MenuInterattivo.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuInterattivo
{
    class Database : IDatabase
    {
        private readonly string DBPath;
        private readonly string DBPathtxt;
        private static Database instance;
        protected Database(string dataFile)
        {
            this.DBPath = dataFile;
            this.DBPathtxt = dbPath();
        }
        private string dbPath()
        {
            string databasePath = this.DBPath + "\\" + "Database.txt";
            if(!File.Exists(databasePath))
            {
                try
                {
                    FileStream fs = File.Create(databasePath);
                    fs.Close();//altrimenti rimane aperto e non può essere acceduto da altri processi
                }
                catch (Exception e)
                {
                    MessageBox.Show("FATAL ERROR \nImpossible create users' register file: " + databasePath + "\n" + e, "Fatal Error", MessageBoxButtons.OK);
                }
            }
            return databasePath;
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
                JArray jsonArray = JArray.Parse(File.ReadAllText(DBPathtxt));
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
            File.WriteAllText(DBPathtxt, cibosArray.ToString());
        }
    }
}