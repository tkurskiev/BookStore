namespace BookStore.API.Contracts.Responses
{
    public class PagedResponse<T>
    {
        public PagedResponse()
        {
            Data = Enumerable.Empty<T>();
        }

        public PagedResponse(IEnumerable<T> data)
        {
            Data = data;
        }

        public IEnumerable<T> Data { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }

        public string? NextPage { get; set; }

        public string? PreviousPage { get; set; }
    }
}
