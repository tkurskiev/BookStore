using BookStore.API.Contracts.Responses;

namespace BookStore.Client
{
    public interface IBookStoreClient
    {
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        /// <exception cref="InvalidOperationException">The request uri must be an absolute URI or <see cref="P:System.Net.Http.HttpClient.BaseAddress" /> must be set.</exception>
        public Task<PagedResponse<BookResponse>?> GetAllBooksAsync(string? uri);

        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        /// <exception cref="InvalidOperationException">The request uri must be an absolute URI or <see cref="P:System.Net.Http.HttpClient.BaseAddress" /> must be set.</exception>
        public Task<PagedResponse<BookResponse>?> GetByUriAsync(string? uri);

        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        /// <exception cref="InvalidOperationException">The request uri must be an absolute URI or <see cref="P:System.Net.Http.HttpClient.BaseAddress" /> must be set.</exception>
        public Task<string> BuyAsync(int id);
    }
}
