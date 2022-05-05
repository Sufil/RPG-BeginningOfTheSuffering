using System;
using Pastel;

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
                    Console.WriteLine("Bitte gib deinen Namen ein:\n");
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


        private static void startFight(Enemy enemy)
        {
            fight = true;
            Console.WriteLine("\n" + enemy.appears());
            while (fight)
            {
                Console.WriteLine(string.Format("\n{0, 0} HP: {1, 1}   Lvl: {2,1}\n\n{3,0}   HP: {4,1}    Lvl: {5,1}", enemy.Name.Pastel("#ff5555"), enemy.Hp.ToString().Pastel("#ff5555"), enemy.Lvl.ToString().Pastel("#ff5555"), player.Name.Pastel("#9988ff"), player.Hp.ToString().Pastel("#9988ff"), player.Lvl.ToString().Pastel("#9988ff")));

                Console.WriteLine("\nWas wirst du tun?\n");

                string attackString = "";

                foreach (Attack attack in player.Attacks)
                {
                    int i = Array.IndexOf(player.Attacks, attack);
                    attackString += string.Format("{0,0}: {1,0}\n", i.ToString().Pastel("#55ff55"), attack.Name.Pastel("#55ffff"));
                }

                Console.WriteLine(attackString + "\n");

                receivePlayerInput(enemy);
                Console.ReadLine();

                if (enemy.checkDeath())
                {
                    Console.WriteLine("\n" + enemy.DeathOutput + "\n");
                    player.addExp(enemy);
                    break;
                }

                enemy.update();
                enemy.attack(enemy.selectAttack(), player);

                Console.ReadLine();

            }
        }
        
        public static void receivePlayerInput(Enemy enemy)
        {

            try
            {
                string input = Console.ReadLine();
                player.attack(Int32.Parse(input), enemy);
            }
            catch (Exception e) {
                receivePlayerInput(enemy);
            }
        }
    }
}
