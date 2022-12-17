using FastEndpoints;

namespace WebApi.Controller
{
    public class InstagramEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("Instagram");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await Task.Delay(1000);
            await SendAsync(new
            {
                followers = 15000
            }, cancellation: ct);
        }
    }
}
