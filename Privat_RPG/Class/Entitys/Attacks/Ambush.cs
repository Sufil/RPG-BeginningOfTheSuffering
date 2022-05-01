using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Ambush:Attack
    {
        public Ambush()
        {
            Dmg = 20;
            Acc = 30;
            Name = "Hinterhalt";
            Crit = 5;
            Description = "ENTITY nimmt TARGET auf ein tolles Date. Zu zweit vergeht die Zeit so langsam und doch so schnell. Am Ende des Abends fragt ENTITY TARGET, ob TARGET noch einen Drink nehmen wolle. TARGET willigt ein. Sie haben eine schöne Zeit zusammen. Doch auch die schönsten Zeiten haben ihr Ende. TARGET endet völlig betrunken auf einer nahestehenden Mülltonne. ENTITY bietet an, TARGET nach Hause zu bringen. Dabei bog ENTITY jedoch einmal falsch ab. TARGET fiel es auf, wieß darauf hin. ENTITY ignorierte TARGET, war TARGET in eine Seitengasse und sprach: >>Dein Verhalten kam mir von Anfang an suspekt vor. Es ist Zeit, dies zu beenden.<< ENTITY nahm eine Scherbe und stach damit mehrfach auf TARGET ein. Grinsend ging ENTITY davon.";
        }
    }
}
