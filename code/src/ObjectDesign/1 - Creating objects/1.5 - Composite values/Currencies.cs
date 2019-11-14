using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ObjectDesign.CreatingObjects.CompositeValues
{
    public sealed class Currencies
    {
        private static readonly Lazy<Currencies> lazy =
            new Lazy<Currencies>(() => new Currencies());

        private static Dictionary<string, string> map;

        private Currencies()
        {
            map = CultureInfo
                .GetCultures(CultureTypes.SpecificCultures)
                .Where(c => !c.IsNeutralCulture)
                .Select(culture => new RegionInfo(culture.Name))
                .Where(ri => ri != null)
                .GroupBy(ri => ri.ISOCurrencySymbol)
                .ToDictionary(x => x.Key, x => x.First().CurrencySymbol);
        }

        public static Currencies Instance => lazy.Value;

        public bool IsValid(string symbol)
        {
            return map.ContainsKey(symbol);
        }
    }
}
