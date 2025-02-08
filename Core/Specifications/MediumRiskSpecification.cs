using Risk.Interfaces;

namespace Risk.Core.Specifications
{
    public class MediumRiskSpecification : ISpecification<ITrade>
    {
        public string Category => "MEDIUMRISK";

        public bool IsSatisfiedBy(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Public";
        }
    }
}
