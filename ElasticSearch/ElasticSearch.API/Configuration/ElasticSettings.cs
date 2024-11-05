namespace ElasticSearch.API.Configuration
{
    public class ElasticSettings
    {
        public required string Url { get; set; }
        public required string DefaultIndex { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
