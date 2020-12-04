using System;
using System.Collections.Generic;
using CoffeeMachine.Models;

namespace CoffeeMachine.Service
{
    public class CoffeeOrderHandler : ICoffeeOrderHandler
    {
        private readonly CoffeeMachineConfiguration _config;

        private Dictionary<Extra, int> _extraQtyByExtra;

        public CoffeeOrderHandler(CoffeeMachineConfiguration config)
        {
            _config = config;

            Reset();
        }

        public CoffeeSize Size { get; set; }

        public IReadOnlyDictionary<Extra, int> ExtraQtyByExtra => _extraQtyByExtra;

        public void AddExtra(Extra extra)
        {
            if (_extraQtyByExtra[extra] == _config.Extras[extra].MaxQty)
            {
                throw new InvalidOperationException($"Your order has the max amount of {extra}s.");
            }

            _extraQtyByExtra[extra]++;
        }

        public void RemoveExtra(Extra extra)
        {
            if (_extraQtyByExtra[extra] == 0)
            {
                throw new InvalidOperationException($"No {extra}s to remove.");
            }

            _extraQtyByExtra[extra]--;
        }

        public CoffeeOrder PlaceOrder()
        {
            var coffeeOrder = new CoffeeOrder(
                Size.ToString(),
                _extraQtyByExtra[Extra.Cream],
                _extraQtyByExtra[Extra.Sugar],
                GetPrice());

            Reset();

            return coffeeOrder;
        }

        private decimal GetPrice()
        {
            var price =
                _config.SizePrices[Size] +
                GetExtraCost(Extra.Cream) +
                GetExtraCost(Extra.Sugar);

            return price;
        }

        private decimal GetExtraCost(Extra extra)
        {
            return _config.Extras[extra].Price * _extraQtyByExtra[extra];
        }

        private void Reset()
        {
            Size = CoffeeSize.Small;

            _extraQtyByExtra = new Dictionary<Extra, int>();

            foreach (Extra extra in Enum.GetValues(typeof(Extra)))
            {
                _extraQtyByExtra[extra] = 0;
            }
        }
    }
}
