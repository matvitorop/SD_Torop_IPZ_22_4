using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class HeroBaseDecorator : IHero
    {
        IHero _hero;

        public HeroBaseDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual void showEquipment()
        {
            _hero.showEquipment();
        }
    }
}
