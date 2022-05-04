using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Blobfish:Enemy
    {
        public override void update()
        {
            foreach (Attack attack in Attacks)
            {
                attack.update();
            }
        }

        public override string appears()
        {
            string[] text = new string[] {"Du trittst aus Versehen auf einen wilden Blobfisch!", "Ein Blobfisch berührt mit seiner Depression deine Aura. Zum Angriff!", "Ein Blobfisch will, dass du sein Leiden beendest!", "\"Biiiitte töte mich!\" Das würde dieser Blobfisch sagen, wenn er sprechen könnte. Erfülle seinen letzten Wunsch!"};
            Random random = new Random();
            return text[random.Next(0, text.Length)];
        }

        public Blobfish()
        {
            Hp = 30;
            Lvl = 2;
            Name = "Blobfisch";
            Exp = 5;
            DeathOutput = "Der Blobfish versinkt in Hass, Trauer und Angst. Er ist tot.";

            Attacks = new Attack[] { new ExistentialDread(), new Cry() };
            AmountAttacks = Attacks.Length;
            ProbabilityOfAppearing = 10;
        }
    }
}
