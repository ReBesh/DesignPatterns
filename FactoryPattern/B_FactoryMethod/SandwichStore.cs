using System.Collections.Generic;

namespace FactoryPattern.B_FactoryMethod
{
    public abstract class SandwichStore
    {
        public ISandwich OrderSandwich(IList<string> ingredients)
        {
            ISandwich pizza = CreateSandwich(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        public abstract ISandwich CreateSandwich(IList<string> ingredients);
    }

    public class SmallSandwichStore : SandwichStore
    {
        public override ISandwich CreateSandwich(IList<string> ingredients)
        {
            return new SmallSandwich(ingredients);
        }
    }
    public class MediumSandwichStore : SandwichStore
    {
        public override ISandwich CreateSandwich(IList<string> ingredients)
        {
            return new MadiumSandwich(ingredients);
        }
    }
    public class BigSandwichStore : SandwichStore
    {
        public override ISandwich CreateSandwich(IList<string> ingredients)
        {
            return new BigSandwich(ingredients);
        }
    }

}
