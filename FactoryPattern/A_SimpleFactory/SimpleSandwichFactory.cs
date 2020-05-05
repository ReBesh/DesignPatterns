using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public enum Sandwich
    {
        SmallS,
        MediumS,
        BigS
    }
    public static class SimpleSandwichFactory
    {
        public static ISandwich CreateSandwich(Sandwich type, IList<string> ingredients)
        {
            switch (type)
            {
                case Sandwich.SmallS:
                    return new SmallSandwich(ingredients);
                case Sandwich.MediumS:
                    return new MadiumSandwich(ingredients);
                case Sandwich.BigS:
                    return new BigSandwich(ingredients);
                default:
                    return null;
            }
        }
    }
}
