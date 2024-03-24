using System.Xml.Linq;

namespace Prototypes
{
    public interface IVirus
    {
        IVirus Clone();
    }

    public class Virus : IVirus
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public List<IVirus> Family { get; set; }

        public Virus(string name, double weight, int age, string type)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Type = type;
            Family = new List<IVirus>(); // Ініціалізація порожнього списку
        }

        public Virus(Virus virus)
        {
            Name = virus.Name;
            Weight = virus.Weight;
            Age = virus.Age;
            Type = virus.Type;
            Family = new List<IVirus>(); // Ініціалізація порожнього списку
            foreach (var child in virus.Family)
            {
                Family.Add(child.Clone()); // Клонування дітей
            }
        }

        public virtual IVirus Clone()
        {
            return new Virus(this);
        }
    }
}
