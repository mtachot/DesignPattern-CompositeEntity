using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern.Classes
{
    public class CoarseGrainedObject
    {
        DependentObject1 do1 = new DependentObject1();
        DependentObject2 do2 = new DependentObject2();

        public void SetData(string data1, string data2)
        {
            do1.Data = data1;
            do2.Data = data2;
        }

        public List<string> GetData()
        {
            return new List<string> { do1.Data, do2.Data };
        }
    }
}
