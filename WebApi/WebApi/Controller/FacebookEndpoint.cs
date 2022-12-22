using FastEndpoints;

namespace WebApi.Controller
{
    public class FacebookEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Get("Facebook");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await Task.Delay(1000);
            await SendAsync(new
            {
                followers = 12000
            }, cancellation: ct);
        }
    }
}
