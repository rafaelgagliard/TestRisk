using Risk.Core.Specifications;
using Risk.Interfaces;

namespace Risk.Core
{
    public static class SpecificationsList
    {
        public static List<ISpecification<ITrade>> GetAllSpecifications() =>
            [
            new ExpiredSpecification(),
            new HighRiskSpecification(),
            new MediumRiskSpecification()
            ];
    }
}
