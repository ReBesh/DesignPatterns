using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.C_AbstractFactory
{
    public interface ISandwichFactory
    {
        ISandwich CreateSandwich(IList<string> ingredients);
    }
    public abstract class SandwichFactory : ISandwichFactory
    {
        public abstract ISandwich CreateSandwich(IList<string> ingredients);
    }

    public class SmallSandwichFactory : SandwichFactory
    {
        public override ISandwich CreateSandwich(IList<string> ingredients)
        {
            return new SmallSandwich(ingredients);
        }
    }
    public class MediumSandwichFactory : SandwichFactory
    {
        public override ISandwich CreateSandwich(IList<string> ingredients)
        {
            return new MadiumSandwich(ingredients);
        }
    }
    public class BigSandwichFactory : SandwichFactory
    {
        public override ISandwich CreateSandwich(IList<string> ingredients)
        {
            return new BigSandwich(ingredients);
        }
    }
}
