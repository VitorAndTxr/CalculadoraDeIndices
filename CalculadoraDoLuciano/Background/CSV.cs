using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDoLuciano.Background
{
    class CSV
    {
        private List<string[]> table = new List<string[]>();

        public CSV(string filePath, char csvDelimiter)
        {
            string line;
            int currentLine = 0;
            using (System.IO.StreamReader file = new System.IO.StreamReader(filePath))
            {
                while((line = file.ReadLine()) != null)
                {
                    string[] strAr = line.Split(csvDelimiter);
                    table.Add(strAr);
                }
            }
        }
        public string[] GetLineValues(int line)
        {
            return table[line];
        }

    }
}
