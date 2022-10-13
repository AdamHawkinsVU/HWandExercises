using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp
{
    public class Character
    {
        ///name, hit chance, max health, health, block, equipped weapon

        private string _name;
        private int _hitChance;
        private int _health;
        
        private int _block;
        private Weapon _weapon;

        public int maxHealth { get; set; }
        public int health
        {
            get { return _health; }
            set 
            { 
                if (value <= maxHealth)
                {
                    _health = value;
                }
                else
                {
                    _health = 1;
                }
            }
        }
    }
}
