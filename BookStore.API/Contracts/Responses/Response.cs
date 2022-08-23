namespace BookStore.API.Contracts.Responses
{
    public class Response<T> where T : class
    {
        public Response(T response)
        {
            Data = response;
        }

        public T Data { get; set; }
    }
}
