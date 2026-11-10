using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        public override Size Size
        {
            get { return baseBeverage.Size; }
            set { baseBeverage.Size = value; }
        }

        public abstract override string GetDescription();

    }
}
