using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overloading.Overriding.Hiding.LIB
{    
    // de afkoring HID staat voor hiding
    // hiding is eerder OVERLADEN (in tegenstelling tot OVERRIDING)
    // het NEW keyword laat wel toe om een nieuwe versie van een methode te maken 
    // met hetzelfde signatuur (in ons geval een methode zonder argumenten)


    public class HIDA
    {
        public string Test()
        {
            return $"Ik ben de methode Test uit de klasse HIDA\n";
        }
    }
    public class HIDB: HIDA
    {
        // het keyword NEW hieronder zorgt er voor dat de methode Test uit de basisklasse (HIDA) verborgen wordt
        // je maakt dus eigenlijk een EXTRA versie aan van de methode Test()
        // welke versie zal uitgevoerd worden is afhankelijk van het type dat je kiest
        // maak je een variabele van het type HIDA, dan wordt de versie HIDA.Test() uitgevoerd (los van de instantiering : t.t.z. de ruimte die voorzien wordt op de Heap)
        // maak je een variabele van het type HIDB, dan wordt de versie HIDB.Test() uitgevoerd (los van de instantiering : t.t.z. de ruimte die voorzien wordt op de Heap)
        // hiding wordt early binding genoemd
        // dus : HIDA a = new HIDA()   =>  de versie HIDA.Test()
        //       HIDB b = new HIDB()   =>  de versie HIDB.Text()
        //       a = new HIDB()        =>  verassend, maar hier blijft de versie HIDA.Text() uitgevoerd worden
        // bovenstaand instructie is uiteraard alleen maar mogelijk omdat HIDB overerft van HIDA


        public new string Test()
        {
            return $"Ik ben de methode Test uit de klasse HIDB\n";
        }
    }
    public class HIDC : HIDB
    {
        public new string Test()
        {
            return $"Ik ben de methode Test uit de klasse HIDC\n";
        }
    }
}
