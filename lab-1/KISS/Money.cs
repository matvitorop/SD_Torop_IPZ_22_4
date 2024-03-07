using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS
{
    public class Money
    {
        protected int mainPart;
        protected int fractionalPart;

        public Money(int mainPart, int fractionalPart)
        {
            this.mainPart = mainPart;
            this.fractionalPart = fractionalPart;
        }
        
        //СПРОЩЕНИЙ НЕПОТРІБНИЙ ФУНКЦІОНАЛ GET/SET ЗА ДОПОМОГОЮ YAGNI
        public int MainPart
        {
            get { return mainPart; }
            set { mainPart = value; }
        }
        //СПРОЩЕНИЙ НЕПОТРІБНИЙ ФУНКЦІОНАЛ GET/SET ЗА ДОПОМОГОЮ YAGNI
        public int FractionalPart
        {
            get { return fractionalPart; }
            set { fractionalPart = value; }
        }

        public void PrintAmount()
        {
            Console.WriteLine($"Total summ = {MainPart}.{FractionalPart}");
        }

    }
}
