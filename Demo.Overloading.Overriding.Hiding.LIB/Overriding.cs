using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overloading.Overriding.Hiding.LIB
{
    // de afkoring Overr staat voor overriding
    // bij OVERRIDING wordt letterlijk de originele methode OVERSCHREVEN
    // hier is dus geen sprake van OVERLADEN
    public class OverrA
    {
        // het keyword VIRTUAL geeft expliciet aan dat deze methode mag overscheven worden
        // door afgeleide klassen
        public virtual string Test()
        {
            return $"Ik ben de methode Test uit de klasse OverrA\n";
        }
    }

    public class OverrB : OverrA
    {
        // het keyword override heieronde OVERSCHRIJFT de methode uit de basisklasse
        // je maakt dus eigenlijk een NIEUWE versie aan van de methode Test()
        // welke versie zal uitgevoerd worden is afhankelijk van de instantie die je maakt
        // maak je een instantie aan van de klasse OverrA, dan wordt de versie OverrA.Test() uitgevoerd
        // maak je een instantie aan van de klasse OverrB, dan wordt de versie OverrB.Test() uitgevoerd
        // overriding wordt late binding genoemd
        // dus : OverrA a = new OverrA()   =>  de versie OverrA.Test()
        //       OverrB b = new OverrB()   =>  de versie OverrB.Text()
        //       a = new OverrB()          =>  wat je waarschijnlijk verwacht, nu zal verise OverrB.Text() uitgevoerd worden.
        // bovenstaand instructie is uiteraard alleen maar mogelijk omdat OverrB overerft van OverrA

        // gebruik je het keyword OVERRIDE, dan is die impliciet eveneens VIRTUAL zodat een klasse die nu van deze 
        // afgeleid wordt eveneens kan "overriden" worden (zie OverrC)
        public override string Test()
        {
            return $"Ik ben de methode Test uit de klasse OverrB\n";
        }
    }
    public class OverrC : OverrB
    {
        // met het keyword override overschrijven we de methode uit de basisklasse
        // dus hier overschrijven we opnieuw de Test() methode uit OverrB
        public override string Test()
        {
            return $"Ik ben de methode Test uit de klasse OverrC\n";
        }

        // stel dat we bovenstaande niet doen, dan zal elke instantie van de klasse OverrC 
        // de versie OverrB uitvoeren (en NIET de versie OverrA)
    }




}
