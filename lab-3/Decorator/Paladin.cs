using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Paladin: IHero
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Paladin(string name = "Artas", string description = "Glorious hero, with dark future")
        {
            Name = name;
            Description = description;
        }

        public void showEquipment()
        {
            Console.WriteLine($"Name: {Name}\nAbout: {Description}\nInventory of paladin: ");
        }

    }
}
