using FastEndpoints;
using WebApi.Model;

namespace WebApi.Controller
{
    public class WeatherEndpoint : EndpointWithoutRequest
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public override void Configure()
        {
            Get("Weather");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new
            {
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }, cancellation: ct);
        }
    }
}
