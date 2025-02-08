using Risk.Interfaces;

namespace Risk.Core.Specifications
{
    public class ExpiredSpecification : ISpecification<ITrade>
    {
        public string Category => "EXPIRED";

        public bool IsSatisfiedBy(ITrade trade, DateTime referenceDate)
        {
            return trade.NextPaymentDate < referenceDate.AddDays(-30);
        }
    }
}
