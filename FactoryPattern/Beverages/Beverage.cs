using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public virtual Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null!;


        public virtual string GetDescription()
        {
            return description;
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

        public abstract double cost();
    }
}
