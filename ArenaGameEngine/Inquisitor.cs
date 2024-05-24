using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Inquisitor : Hero
    {
        
        public bool DivineProtection { get; private set; }

       
        public Inquisitor(string name) : base(name)
        {
            DivineProtection = false;
        }

     
        public override int Attack()
        {
            
            if (DivineProtection)
            {
                
                return base.Attack() + 20;
            }
            else
            {
              
                return base.Attack();
            }
        }

   
        public override void TakeDamage(int incomingDamage)
        {
          
            if (incomingDamage > 200)
            {
                DivineProtection = true;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
