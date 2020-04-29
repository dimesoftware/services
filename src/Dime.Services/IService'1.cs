namespace Dime
{
    /// <summary>
    /// Represents a read and write service
    /// </summary>
    /// <typeparam name="T">Represents the entity of the underlying data storage medium</typeparam>
    public interface IService<T> : ICommandService<T>, IQueryService<T>
    {
    }
}