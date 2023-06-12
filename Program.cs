using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponINC
{
    internal class Program
    {
        public class Weapon
        {
            private int _damage;
            private int _bullets;

            public void Fire(Player player)
            {
                player.TakeDamage(_damage);
                _bullets -= 1;
            }
        }

        public class Player
        {
            private int _health;

            public void TakeDamage(int damage)
            {
                if (damage > 0)
                    _health -= damage;
            }
        }

        public class Bot
        {
            private Weapon _weapon;

            public void OnSeePlayer(Player player)
            {
                _weapon.Fire(player);
            }
        }
    }
}
