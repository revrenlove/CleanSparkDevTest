using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CoffeeMachine.Models
{
    public class CoffeeMachineConfiguration
    {
        public CoffeeMachineConfiguration(string pathToJsonCOnfig)
        {
            if (string.IsNullOrWhiteSpace(pathToJsonCOnfig))
            {
                throw new ArgumentNullException(nameof(pathToJsonCOnfig));
            }

            var configJson = File.ReadAllText(pathToJsonCOnfig);
            JsonConvert.PopulateObject(configJson, this);
        }

        public IReadOnlyDictionary<CoffeeSize, decimal> SizePrices { get; set; }
        public IReadOnlyDictionary<Extra, ExtraConfig> Extras { get; set; }

        public struct ExtraConfig
        {
            public ExtraConfig(decimal price, int maxQty)
            {
                Price = price;
                MaxQty = maxQty;
            }

            public decimal Price { get; }
            public int MaxQty { get; }
        }
    }
}
