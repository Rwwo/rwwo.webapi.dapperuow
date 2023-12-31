namespace rwwo.webapi.dapperuow.Interfaces
{
    public interface IGenericRepository<T , Q , R> 
    {
        Task<IEnumerable<T>> Get();
        Task<T> Find(Guid uid);
        Task<T> Add(Q model);
        Task<T> Update(R model);
        Task<int> Remove(T model);
    }
}
