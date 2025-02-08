namespace Risk.Core
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity, DateTime referenceDate);
        string Category { get; }
    }
}
