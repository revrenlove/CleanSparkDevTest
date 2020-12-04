using System;

namespace CoffeeMachine.Service
{
    public class InsufficientFundsException : InvalidOperationException
    {
        public InsufficientFundsException() : base()
        {
        }

        public InsufficientFundsException(decimal availableFunds, decimal balance)
            : this($"Insufficient Funds... Available: {availableFunds:C}. Balance: {balance:C}.")
        {            
        }

        public InsufficientFundsException(string message) : base(message)
        {
        }

        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
