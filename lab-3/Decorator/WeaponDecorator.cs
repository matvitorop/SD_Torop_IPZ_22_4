using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WeaponDecorator : HeroBaseDecorator
    {
        string Weapon {  get; set; }
        double Damage { get; set; }
        public WeaponDecorator(IHero hero, string weapon = "Paladin Hammer", double damage = 30): base(hero) 
        {
            Damage = damage;
            Weapon = weapon;
        }

        public override void showEquipment()
        {
            base.showEquipment();
            Console.WriteLine($"Weapon: {Weapon} with {Damage} damage");
        }
    }
}
