using System;

namespace ObjectDesign.UsingObjects.RulesForCustomExceptions
{
    public class CouldNotCheckoutProcess : Exception
    {
        private CouldNotCheckoutProcess(string message) : base(message)
        {
        }

        public static CouldNotCheckoutProcess DueToProductHasAMinimumQuantityRequiredTOrder()
        {
            return new CouldNotCheckoutProcess($"Could not ...");
        }

        public static CouldNotCheckoutProcess DueToProductIsOnlyAvailableToPreRegistered()
        {
            return new CouldNotCheckoutProcess($"Could not ...");
        }
    }
}
