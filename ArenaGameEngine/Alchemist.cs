using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Alchemist : Hero
    {
        // Допълнителни характеристики за алхимика
        public int Mana { get; private set; }

        // Конструктор за алхимика
        public Alchemist(string name) : base(name)
        {
            Mana = 200;
        }

        // Презаписване на метода за атака
        public override int Attack()
        {
            int baseAttack = base.Attack();
            if (Mana >= 50)
            {
                Mana -= 50;
                // В алхимичния атака може да се добави допълнителен ефект
                return baseAttack + 50;
            }
            else
            {
                // Ако алхимикът няма достатъчно мана, атаката се извършва само с базовата си сила
                return baseAttack;
            }
        }

        // Презаписване на метода за получаване на щети
        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
        }
    }
}
