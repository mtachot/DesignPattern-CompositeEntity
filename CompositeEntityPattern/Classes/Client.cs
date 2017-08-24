using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern.Classes
{
    public class Client
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public void PrintData()
        {
            for (int i = 0; i < compositeEntity.GetData().Count; i++)
            {
                Console.WriteLine(String.Format("Data: {0}", compositeEntity.GetData()[i]));
            }
        }

        public void SetData(string data1, string data2)
        {
            compositeEntity.SetData(data1, data2);
        }
    }
}
