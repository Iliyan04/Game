using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Arena
    {
        public Hero HeroA { get; private set; }
        public Hero HeroB { get; private set; }
        public Alchemist AlchemistC { get; private set; }
        public Inquisitor InquisitorD { get; private set; }

        public GameEventListener EventListener { get; set; }

        public Arena(Hero a, Hero b)
        {
            HeroA = a;
            HeroB = b;
        }

        public Arena(Hero a, Hero b, Alchemist alchemist, Inquisitor inquisitor) : this(a, b)
        {
            AlchemistC = alchemist;
            InquisitorD = inquisitor;
        }

        public Hero Battle()
        {
            Hero[] heroes = { HeroA, HeroB, AlchemistC, InquisitorD };
            int currentAttackerIndex = 0;
            int currentDefenderIndex = 1;

            while (true)
            {
                Hero attacker = heroes[currentAttackerIndex];
                Hero defender = heroes[currentDefenderIndex];

                int damage = attacker.Attack();
                defender.TakeDamage(damage);

                if (EventListener != null)
                {
                    EventListener.GameRound(attacker, defender, damage);
                }

                if (defender.IsDead)
                {
                    return attacker;
                }

                // Превключване на атакуващия и защитаващия герой за следващия рунд
                currentAttackerIndex = (currentAttackerIndex + 1) % heroes.Length;
                currentDefenderIndex = (currentDefenderIndex + 1) % heroes.Length;
            }
        }

    }

}
