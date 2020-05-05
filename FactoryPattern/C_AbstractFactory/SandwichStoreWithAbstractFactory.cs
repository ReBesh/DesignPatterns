using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.C_AbstractFactory
{
    public abstract class SandwichStoreWithAbstractFactory
    {
        private readonly ISandwichFactory _factory;

        protected SandwichStoreWithAbstractFactory(ISandwichFactory factory)
        {
            _factory = factory;
        }

        public ISandwich OrderSandwich(IList<string> ingredients)
        {
            ISandwich sandwich = _factory.CreateSandwich(ingredients);
            sandwich.Bake();
            sandwich.Cut();
            sandwich.Box();
            return sandwich;
        }
    }

    public class SmallSandwichStoreWithAbstractFactory :
        SandwichStoreWithAbstractFactory
    {
        public SmallSandwichStoreWithAbstractFactory() :
            this(new SmallSandwichFactory())
        { }
        public SmallSandwichStoreWithAbstractFactory(
            ISandwichFactory sandwichFactory) :
            base(sandwichFactory)
        { }

    }
    public class MediumSandwichStoreWithAbstractFactory : SandwichStoreWithAbstractFactory
    {
        public MediumSandwichStoreWithAbstractFactory() :
            this(new MediumSandwichFactory())
        { }
        public MediumSandwichStoreWithAbstractFactory(ISandwichFactory sandwichFactory)
            : base(sandwichFactory) { }
    }
    public class BigSandwichStoreWithAbstractFactory : SandwichStoreWithAbstractFactory
    {
        public BigSandwichStoreWithAbstractFactory() :
            this(new BigSandwichFactory())
        { }
        public BigSandwichStoreWithAbstractFactory(ISandwichFactory sandwichFactory)
            : base(sandwichFactory) { }
    }
}
