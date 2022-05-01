using System;

namespace Privat_RPG
{
    class Program
    {
        static public bool yourMama = true;
        static public bool fat = true;
        static Type[] enemies = new Type[] { typeof(Avast), typeof(Blobfish), typeof(Amogus) };
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
            Random random = new Random();

            Type enemyRace = enemies[random.Next(0, enemies.Length)];
            Enemy enemy = (Enemy) Activator.CreateInstance(enemyRace);
            startFight(enemy);
        }


        private static void startFight(Enemy asshole)
        {
            fight = true;
            Console.WriteLine(string.Format("Du bist einem {0,0} begegnet!", asshole.Name));
            while (fight)
            {
                Console.WriteLine(string.Format("{0, 0} HP: {1, 1}   Lvl: {2,1}\n\n{3,0}   HP: {4,1}    Lvl: {5,1}", asshole.Name, asshole.Hp, asshole.Lvl, player.Name, player.Hp, player.Lvl));

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
                    Console.WriteLine("\n" + asshole.DeathOutput + "\n");
                    player.addExp(asshole);
                    break;
                }

                asshole.update();
                asshole.attack(asshole.selectAttack(), player);

                Console.ReadLine();

            }
        }
        
        public static void recievePlayerInput(Enemy asshole)
        {

            // try funktion
            string input = Console.ReadLine();

            player.attack(Int32.Parse(input), asshole);
        }
    }
}
