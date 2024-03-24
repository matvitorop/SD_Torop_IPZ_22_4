using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : IBuilder
    {
        private Person person = new Person();
        private void reset()
        {
            this.person = new Person();
        }
        IBuilder IBuilder.BuildName()
        {
            this.person.Name = "Jonkler";
            return this;
        }
        IBuilder IBuilder.BuildAge()
        {
            this.person.Age = 99;
            return this;
        }
        IBuilder IBuilder.BuildStructure()
        {
            this.person.Structure = "Thin";
            return this;
        }
        IBuilder IBuilder.BuildHairColor()
        {
            this.person.HairColor = "Green";
            return this;
        }
        IBuilder IBuilder.BuildClothes()
        {
            this.person.Clothes = "Old suit";
            return this;
        }
        IBuilder IBuilder.BuildInventory()
        {
            this.person.Inventory = "Hammer, Fabric jaw";
            return this;
        }
        public Person GetPerson()
        {
            Person person = this.person;
            reset();
            return person;
        }
    }
}
