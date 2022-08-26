using BookStore.API.Contracts.Responses;
using Newtonsoft.Json;
using System;
using System.Net;

namespace BookStore.Client;

public class BookStoreClient : IBookStoreClient
{
    private readonly HttpClient _client;

    public BookStoreClient(HttpClient client)
    {
        _client = client;
    }

    /// <inheritdoc cref="IBookStoreClient.GetAllBooksAsync" />
    public async Task<PagedResponse<BookResponse>?> GetAllBooksAsync(string? filterQuery)
    {
        var responseMessage = await _client.GetAsync($"/api/Books/{filterQuery}");

        if (!responseMessage.IsSuccessStatusCode)
        {
            var errorMessage = await responseMessage.Content.ReadAsStringAsync();
            throw new HttpRequestException($"{responseMessage.ReasonPhrase}, {errorMessage}", null,
                responseMessage.StatusCode);
        }

        var serializer = new JsonSerializer();
        using var reader = new JsonTextReader(new StreamReader(await responseMessage.Content.ReadAsStreamAsync()));

        var response = serializer.Deserialize<PagedResponse<BookResponse>>(reader);

        return response;
    }

    /// <inheritdoc cref="IBookStoreClient.GetByUriAsync" />
    public async Task<PagedResponse<BookResponse>?> GetByUriAsync(string? uri)
    {
        var responseMessage = await _client.GetAsync($"{uri}");

        if (!responseMessage.IsSuccessStatusCode)
        {
            var errorMessage = await responseMessage.Content.ReadAsStringAsync();
            throw new HttpRequestException($"{responseMessage.ReasonPhrase}, {errorMessage}", null,
                responseMessage.StatusCode);
        }

        var serializer = new JsonSerializer();
        using var reader = new JsonTextReader(new StreamReader(await responseMessage.Content.ReadAsStreamAsync()));

        var response = serializer.Deserialize<PagedResponse<BookResponse>>(reader);

        return response;
    }

    /// <inheritdoc cref="IBookStoreClient.BuyAsync" />
    /// <exception cref="HttpRequestException">Condition.</exception>
    public async Task<string> BuyAsync(int id)
    {
        var responseMessage = await _client.PostAsync($"/api/Books/{id}", null);

        var message = await responseMessage.Content.ReadAsStringAsync();

        if (!responseMessage.IsSuccessStatusCode)
            throw new HttpRequestException(
                $"{responseMessage.ReasonPhrase}, {message}",
                null,
                responseMessage.StatusCode);

        return message;
    }
}