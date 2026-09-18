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

        protected double SizeSurcharge()
        {
            switch (Size)
            {
                case Size.GRANDE:
                    return 0.05;
                case Size.VENDI:
                    return 0.10;
                default:
                    return 0.0;
            }
        }

        public abstract override string GetDescription();

    }
}
