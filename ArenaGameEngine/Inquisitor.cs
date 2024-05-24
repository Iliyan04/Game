using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Inquisitor : Hero
    {
        // Допълнителни характеристики за инквизитора
        public bool DivineProtection { get; private set; }

        // Конструктор за инквизитора
        public Inquisitor(string name) : base(name)
        {
            DivineProtection = false;
        }

        // Презаписване на метода за атака
        public override int Attack()
        {
            // В инквизитора атаката може да активира допълнителен ефект, ако е включена божествена защита
            if (DivineProtection)
            {
                // Логика за божествена защита
                return base.Attack() + 20;
            }
            else
            {
                // Ако божествената защита не е активирана, атаката се извършва само с базовата си сила
                return base.Attack();
            }
        }

        // Презаписване на метода за получаване на щети
        public override void TakeDamage(int incomingDamage)
        {
            // В инквизитора може да се добави способност за активиране на божествена защита при определени условия
            if (incomingDamage > 200)
            {
                DivineProtection = true;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
