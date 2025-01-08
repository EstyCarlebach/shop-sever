namespace IBll
{
    public interface IBLL<T>
    {
        Task<List<T>> Get();
    }
}
