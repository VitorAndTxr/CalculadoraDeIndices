using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDoLuciano.Background
{
    class IndexTable
    {
        public List<string> cities { get; set; }
        public List<string> index { get; set; }
        public List<float[]> citiesIndex { get; set; }


        public IndexTable(CSV table)
        {
            int i;
            var buffer = table.GetLineValues(0);

            for(i = 1 ; i < buffer.Length;i++)
            {
                index.Add(buffer[i]);
            }

            i=1;
            while(table.GetLineValues(i)!=null)
            {
              buffer = table.GetLineValues(i);
              cities.Add(buffer[0]);

              for(int j=1;i<buffer.Length;j++)
              {
                  float[] aux = new float[buffer.Length-1];
                  aux[j-1] = float.Parse(buffer[j]); 
              }
            }
        }
    }
}
