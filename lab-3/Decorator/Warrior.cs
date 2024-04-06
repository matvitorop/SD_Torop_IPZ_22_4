using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Warrior : IHero
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Warrior(string name = "Illidan", string description = "Legendary demon hunter")
        {
            Name = name;
            Description = description;
        }

        public void showEquipment()
        {
            Console.WriteLine($"Name: {Name}\nAbout: {Description}\nWeapon of warrior: ");
        }

    }
}
