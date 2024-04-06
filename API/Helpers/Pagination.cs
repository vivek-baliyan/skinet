namespace API.Helpers
{
    public class Pagination<T>(int pageIndex, int pageSize, int pageCount, IReadOnlyList<T> data) where T : class
    {
        public int PageIndex { get; set; } = pageIndex;
        public int PageSize { get; set; } = pageSize;
        public int PageCount { get; set; } = pageCount;
        public IReadOnlyList<T> Data { get; set; } = data;
    }
}