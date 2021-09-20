using System;

namespace FeaturesData
{
    public class Soldeir
    {
        private int _health = 100;

        public int _Health {get { return _health;  } }


        public void TakeDamage(int damage)
        {
            _health = Math.Max(0, _health - damage);
        }

      
    }
}
