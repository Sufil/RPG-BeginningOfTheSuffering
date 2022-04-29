using System;

namespace Privat_RPG
{
    class Program
    {
        static public bool yourMama = true;
        static public bool fat = true;
        static Type[] enemies = new Type[] { typeof(Avast) };
        static public Player player;
        static public bool fight;

        static void Main(string[] args)
        {
            while (yourMama == fat)
            {
                if (player == null)
                {
                    Console.WriteLine("Bitte gib deinen Namen ein:");
                    string name= Console.ReadLine();
                    player = new Player(name);
                }

                checkForEnemy();

                Console.ReadLine();
            }

        }

        private static void checkForEnemy()
        {
            startFight(new Avast());

            /*Random random = new Random();

            foreach (Type enemy in enemies)
            {

                //int prob = enemy.ProbabilityOfAppearing;
                if (random.Next(0,101) <= prob)
                {
                    startFight(enemy);
                }
            }*/

        }


        private static void startFight(Enemy asshole)
        {
            fight = true;
            Console.WriteLine(string.Format("Du bist einem {0,0} begegnet!", asshole.Name));
            while (fight)
            {
                Console.WriteLine(string.Format("Gegner HP: {0, 1}  Gegner Lvl: {1,1}\n\n {2,0}   HP: {3,1}    Lvl: {4,1}", asshole.Hp, asshole.Lvl, player.Name, player.Hp, player.Lvl));

                Console.WriteLine("Was wirst du tun?\n");

                string attackString = "";

                foreach (Attack attack in player.Attacks)
                {
                    int i = Array.IndexOf(player.Attacks, attack);
                    attackString += string.Format("{0,0}: {1,0}\n", i, attack.Name);
                }

                Console.WriteLine(attackString);

                recievePlayerInput(asshole);
                Console.ReadLine();

                if (asshole.checkDeath())
                {
                    Console.WriteLine("Enemy defeated\n");
                    break;
                }

                asshole.attack(player);

                Console.ReadLine();

            }
        }
        
        public static void recievePlayerInput(Enemy asshole)
        {
            // try funktion
            string input = Console.ReadLine();

            Attack attack = player.Attacks[Int32.Parse(input)];

            asshole.takeDamage(attack.Dmg);
            Console.WriteLine(string.Format("{0,0} setzt {1,0} ein. {2,0} nimmt {3,0} Schaden", player.Name, attack.Name, asshole.Name, attack.Dmg));
        }
    }
}
