using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ArmorDecorator: HeroBaseDecorator
    {
        string Armor { get; set; }
        double Reduction { get; set; }
        public ArmorDecorator(IHero hero, string armor = "Plate mail", double reduction = 30) : base(hero)
        {
            Armor = armor;
            Reduction = reduction;
        }

        public override void showEquipment()
        {
            base.showEquipment();
            Console.WriteLine($"Armor: {Armor} with {Reduction} reduction");
        }
    }
}
