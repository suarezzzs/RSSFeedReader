using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionService _subscriptionService;

    public SubscriptionsController(SubscriptionService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    [HttpGet]
    public ActionResult<IReadOnlyList<Subscription>> Get() => Ok(_subscriptionService.GetSubscriptions());

    [HttpPost]
    public ActionResult<Subscription> Post(CreateSubscriptionRequest request)
    {
        if (request is null || string.IsNullOrWhiteSpace(request.Url))
        {
            return BadRequest();
        }

        var subscription = _subscriptionService.AddSubscription(request.Url);
        if (subscription is null)
        {
            return Conflict();
        }

        return CreatedAtAction(nameof(Get), new { id = subscription.Id }, subscription);
    }
}
