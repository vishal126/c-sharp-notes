namespace HttpClientApi
{
    public class JokeService(HttpClient httpClient)
    {
        public async Task<JokeResponse?> GetJokeAsync()
        {
            return await httpClient.GetFromJsonAsync<JokeResponse>($"random_joke");
        }
    }
}
