using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mage : IHero
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Mage(string name = "Jaina", string description = "One of the most powerful mage in Azeroth")
        {
            Name = name;
            Description = description;
        }

        public void showEquipment()
        {
            Console.WriteLine($"Name: {Name}\nAbout: {Description}\nWeapon of mage: ");
        }

    }
}
