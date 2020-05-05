using BuilderPattern;
using FactoryPattern;
using FactoryPattern.B_FactoryMethod;
using FactoryPattern.C_AbstractFactory;
using PrototypePattern;
using Singleton;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbOne = MySingleton.Ins;
            dbOne.GetRecords();

            var dbTwo = SLazy.Instance;
            dbTwo.GetRecords();

            var op = SimpleSandwichFactory.CreateSandwich(Sandwich.SmallS, new List<string>()
            {"type1", "tupe 2", "type3"});

            var op1 = new MediumSandwichStore();
            op1.CreateSandwich(new List<string>()
            {"type1", "tupe 2", "type3"});

            var op2 = new BigSandwichFactory();
            op2.CreateSandwich(new List<string>()
            { "type1", "tupe 2", "type3"});

            var sandwichStoreWithAbstractFactory = new MediumSandwichStoreWithAbstractFactory();
            sandwichStoreWithAbstractFactory.OrderSandwich(new List<string>()
            {"type1", "tupe 2", "type3"});

            CallBuilder();

            var john = new Identification(new[] { "dd", "ll" },
                new Identity("gg", 000));

            var jane = john.DeepCopy();
            jane.Name[0] = "hh";
            jane.Surname.Password = 567;

            Console.WriteLine(gg);
            Console.WriteLine(hh);}
        static void CallBuilder()
        {
            var builder = new BuildDetails("y");
            builder.AddChild("k", "u");
            builder.AddChild("k", "u");
            Console.WriteLine(builder.ToString());

        }
    }
}