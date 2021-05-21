using System;

namespace Fight
{
    public class Player
    {
        public int Hp {get; set;} = 20;
        private int attackDamage = 2;
        
        public int GetAttackDamage(){
            return attackDamage;
        }
    }
}
