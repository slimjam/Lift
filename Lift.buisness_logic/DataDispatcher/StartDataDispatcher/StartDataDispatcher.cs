using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic.DataDispatcher
{
    public class StartDataDispatcher
    {
        private decimal floorsCount;
        private decimal peopleCount;
        private bool toScreen;
        private bool toExcel;
        public StartDataDispatcher(decimal _floorsCount, decimal _peopleCount, bool _toScreen, bool _toExcel)
        {
            floorsCount = _floorsCount;
            peopleCount = _peopleCount;
            toScreen = _toScreen;
            toExcel = _toExcel;

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

        private void WriteToFile()
        {
            var text = ToString();
            var path = System.IO.Path.GetFullPath(@".").Replace("Lift\\bin\\Debug", "Lift.Data\\Data\\config.txt");
            System.IO.File.WriteAllText(path, text);
        }
    }
}
