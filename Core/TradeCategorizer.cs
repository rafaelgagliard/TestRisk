using Risk.Interfaces;

namespace Risk.Core
{
    public static class TradeCategorizer
    {
        public static string Categorize(this ITrade trade, DateTime referenceDate)
        {
            List<ISpecification<ITrade>> _specifications = SpecificationsList.GetAllSpecifications();

            foreach (var spec in _specifications)
            {
                if (spec.IsSatisfiedBy(trade, referenceDate))
                    return spec.Category;
            }
            return "UNCATEGORIZED"; // Caso não atenda nenhuma regra
        }
    }
}
