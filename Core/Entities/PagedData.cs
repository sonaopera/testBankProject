namespace Core.Entities
{
    public class PagedData<TData>
    {
        public List<TData> Data { get; set; }
        public int TotalCount { get; set; }
    }
}
