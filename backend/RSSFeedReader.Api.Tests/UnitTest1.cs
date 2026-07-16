using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Tests;

public class UnitTest1
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
}
