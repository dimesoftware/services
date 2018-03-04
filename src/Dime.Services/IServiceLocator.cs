namespace Dime
{
    /// <summary>
    /// Defines the capabilities of a service locator
    /// </summary>
    public interface IServiceLocator
    {
        /// <summary>
        /// Creates a instance of the requested service
        /// </summary>
        /// <typeparam name="T">The type of the requested service</typeparam>
        /// <returns>An instantiated <see cref="IService"/> object</returns>
        T Create<T>() where T : class, IService;
    }
}