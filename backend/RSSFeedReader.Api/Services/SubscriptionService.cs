using RSSFeedReader.Api.Models;

namespace RSSFeedReader.Api.Services;

public class SubscriptionService
{
    private readonly List<Subscription> _subscriptions = new();

    public IReadOnlyList<Subscription> GetSubscriptions() => _subscriptions.AsReadOnly();

    public Subscription? AddSubscription(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return null;
        }

        var normalizedUrl = url.Trim();
        if (_subscriptions.Any(s => string.Equals(s.Url, normalizedUrl, StringComparison.OrdinalIgnoreCase)))
        {
            return null;
        }

        var subscription = new Subscription { Url = normalizedUrl };
        _subscriptions.Add(subscription);
        return subscription;
    }
}
