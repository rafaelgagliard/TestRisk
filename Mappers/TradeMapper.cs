using Risk.Models;
using System.Globalization;

namespace Risk.Mappers
{
    public static class TradeMapper
    {
        public static Trade ConvertToTrade(this string trade)
        {
            string[] input = trade.Split(' ');

            return new Trade(
                double.Parse(input[0], CultureInfo.InvariantCulture),
                input[1],
                input[2].ConvertToDateTime());
        }
    }
}
