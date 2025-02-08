using Risk.Interfaces;

namespace Risk.Core.Specifications
{
    public class HighRiskSpecification : ISpecification<ITrade>
    {
        public string Category => "HIGHRISK";

        public bool IsSatisfiedBy(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Private";
        }
    }
}
