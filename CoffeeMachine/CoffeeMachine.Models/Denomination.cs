using System.Collections.Generic;

namespace CoffeeMachine.Service
{
    public class Denomination
    {
        public static readonly Denomination Nickel = new Denomination("Nickel", .05m);
        public static readonly Denomination Dime = new Denomination("Dime", .1m);
        public static readonly Denomination Quarter = new Denomination("Quarter", .25m);
        public static readonly Denomination Dollar = new Denomination("Dollar", 1);
        public static readonly Denomination Five = new Denomination("Five", 5);
        public static readonly Denomination Ten = new Denomination("Ten", 10);
        public static readonly Denomination Twenty = new Denomination("Twenty", 20);

        public static IReadOnlyList<Denomination> GetAll() => new List<Denomination>()
        {
            Nickel,
            Dime,
            Quarter,
            Dollar,
            Five,
            Ten,
            Twenty
        };

        private Denomination(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public decimal Value { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
