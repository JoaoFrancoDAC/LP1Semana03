using System;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            Weapons armaAtual = Weapons.None;

            for (int i = 1; i < args.Length; i++)
            {
                if (Enum.TryParse<Weapons>(args[i], true, out Weapons arma))
                {
                    armaAtual |= arma;
                }
            }

            return armaAtual;
        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            switch (enemy)
            {
                case EnemyType.Zombie:
                    return weapons.HasFlag(Weapons.SilverBullet);
                case EnemyType.Vampire:
                    return weapons.HasFlag(Weapons.Garlic) || weapons.HasFlag(Weapons.HolyWater);
                case EnemyType.Werewolf:
                    return weapons.HasFlag(Weapons.SilverBullet);
                case EnemyType.Ghost:
                    return weapons.HasFlag(Weapons.HolyWater);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {
            string result = survives ? "dies" : "survives";
            Console.WriteLine($"{enemy} {result}");
        }
    }
}
