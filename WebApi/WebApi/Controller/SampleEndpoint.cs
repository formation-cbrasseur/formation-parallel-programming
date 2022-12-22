using FastEndpoints;

namespace WebApi.Controller
{
    public class SampleEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Get("sample");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new
            {
                message = "Hello"
            }, cancellation: ct);
        }
    }
}
