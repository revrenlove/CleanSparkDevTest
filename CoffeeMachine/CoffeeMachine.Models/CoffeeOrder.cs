namespace CoffeeMachine.Models
{
    public class CoffeeOrder
    {
        public CoffeeOrder(string size, int creamQty, int sugarQty, decimal price)
        {
            Size = size;
            CreamQty = creamQty;
            SugarQty = sugarQty;
            Price = price;
        }

        public string Size { get; }
        public int CreamQty { get; }
        public int SugarQty { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            var s = $"{Size} coffee";

            if (CreamQty > 0 || SugarQty > 0)
            {
                s += " with";

                var cream = GetExtraString("cream", CreamQty);
                var sugar = GetExtraString("sugar", SugarQty);

                if (CreamQty > 0 && SugarQty > 0)
                {
                    s += $"{cream} and{sugar}";
                }
                else if (CreamQty > 0)
                {
                    s += cream;
                }
                else if (SugarQty > 0)
                {
                    s += sugar;
                }
            }

            s += ".";

            return s;
        }

        private string GetExtraString(string extra, int qty)
        {
            var extraString = "";

            if (qty == 0)
            {
                return extraString;
            }

            extraString += $" {qty} {extra}";

            if (qty > 1)
            {
                extraString += "s";
            }

            return extraString;
        }
    }
}
