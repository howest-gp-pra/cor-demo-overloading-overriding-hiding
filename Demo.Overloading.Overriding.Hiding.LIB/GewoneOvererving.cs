using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overloading.Overriding.Hiding.LIB
{
    // de afkoring GewOv staat voor gewone overerving
    public class GewOvA
    {
        public string Test()
        {
            return $"Ik ben de methode Test uit de klasse GewOvA\n";
        }
    }
    public class GewOvB : GewOvA
    {

    }
    public class GewOvC : GewOvB
    {

    }
}
