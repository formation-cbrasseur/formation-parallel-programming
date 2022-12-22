using FastEndpoints;

namespace WebApi.Controller
{
    public class TwitterEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Get("Twitter");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await Task.Delay(1000);
            await SendAsync(new
            {
                followers = 10000
            }, cancellation: ct);
        }
    }
}
