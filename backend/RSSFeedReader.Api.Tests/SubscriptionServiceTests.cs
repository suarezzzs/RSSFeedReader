using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Tests;

public class SubscriptionServiceTests
{
    [Fact]
    public void AddSubscription_AddsUniqueSubscription()
    {
        var service = new SubscriptionService();

        var result = service.AddSubscription("https://example.com/feed");

        Assert.NotNull(result);
        Assert.Equal("https://example.com/feed", result!.Url);
        Assert.Single(service.GetSubscriptions());
    }

    [Fact]
    public void AddSubscription_IgnoresDuplicateUrl()
    {
        var service = new SubscriptionService();

        service.AddSubscription("https://example.com/feed");
        var duplicate = service.AddSubscription("https://example.com/feed");

        Assert.Null(duplicate);
        Assert.Single(service.GetSubscriptions());
    }
}
