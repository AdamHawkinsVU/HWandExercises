using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp
{
    public class Weapon
    {
        ///name, min dmg, max dmg, 2handed bool, bonus chance
        
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        public int maxDamage
            { 
            get { return _maxDamage; } 
            set { _maxDamage = value; } 
            }

        public int minDamage 
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= _maxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            } 
        }

    }
}
