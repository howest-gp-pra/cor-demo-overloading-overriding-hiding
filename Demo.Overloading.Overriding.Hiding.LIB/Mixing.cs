using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overloading.Overriding.Hiding.LIB
{

    public class MixA
    {
         public string Test()
        {
            return $"Ik ben de methode Test uit de klasse MixA\n";
        }
    }

    public class MixB : MixA
    {
        public new virtual string Test()
        {
            return $"Ik ben de methode Test uit de klasse MixB\n";
        }
    }
    public class MixC : MixB
    {
        public override string Test()
        {
            return $"Ik ben de methode Test uit de klasse MixC\n";
        }
    }
}
