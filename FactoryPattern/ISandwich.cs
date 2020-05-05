using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public enum DoughType
    { None, Thin, Pan, DeepDish }
    public interface ISandwich
    {
        IList<string> Filling { get; }
        DoughType Dough { get; set; }
        string Bread { get; set; }
        string Cheese { get; set; }
        void Bake();
        void Cut();
        void Box();
    }

    public abstract class Sandw : ISandwich
    {
        protected Sandw(IList<string> ingredients)
        {
            Filling = ingredients;
        }
        public IList<string> Filling { get; set; }
        public DoughType Dough { get; set; }
        public string Bread { get; set; }
        public string Cheese { get; set; }
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }

    public class SmallSandwich : Sandw
    {
        public SmallSandwich(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Thin;
        }

        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }
    public class MadiumSandwich : Sandw
    {
        public MadiumSandwich(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Pan;
        }
        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }
    public class BigSandwich : Sandw
    {
        public BigSandwich(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.None;
        }
        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }
}
