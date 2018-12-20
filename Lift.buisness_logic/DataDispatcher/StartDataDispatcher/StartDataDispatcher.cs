using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic.DataDispatcher
{
    public struct ConfigData
    {
        public decimal floorsCount;
        public decimal peopleCount;
        public bool toScreen;
        public bool toExcel;
        public ConfigData(decimal _floorsCount, decimal _peopleCount, bool _toScreen, bool _toExcel)
        {
            floorsCount = _floorsCount;
            peopleCount = _peopleCount;
            toScreen = _toScreen;
            toExcel = _toExcel;
        }
    }
    public class StartDataDispatcher
    {
        private decimal floorsCount;
        private decimal peopleCount;
        private bool toScreen;
        private bool toExcel;
        public StartDataDispatcher(ConfigData configData)
        {
            floorsCount = configData.floorsCount;
            peopleCount = configData.peopleCount;
            toScreen = configData.toScreen;
            toExcel = configData.toExcel;

            WriteToFile();
        }

        public void AddMan()
        {
            peopleCount += 1;
        }

        public override string ToString()
        {
            string floors = "floors: " + floorsCount.ToString();
            string people = "people: " + peopleCount.ToString();
            string screen = "to screen: " + toScreen.ToString();
            string excel = "to excel: " + toExcel.ToString();
            string[] values = new string[] { floors, people, excel, screen };

            String res = String.Join("; ", values);
            return res;
        }

        private string GetPathToDB()
        {
            return Path.GetFullPath(@".").Replace("Lift\\bin\\Debug", "Lift.Data\\Data\\config.txt");
        }

        private void WriteToFile()
        {
            File.WriteAllText(GetPathToDB(), ToString());
        }

        private ConfigData ParseDBData(string data)
        {
            return new ConfigData(1,1,true,true); // test sheet
        }

        private void SetData(ConfigData data)
        {
            // set data
        }

        private void ReadFromFile()
        {
            var dbData = File.ReadAllText(GetPathToDB());
            var parsedData = ParseDBData(dbData);

            SetData(parsedData);
        }
    }
}
