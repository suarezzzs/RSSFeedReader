namespace RSSFeedReader.Api.Models;

public class Subscription
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Url { get; set; } = string.Empty;
}

public class CreateSubscriptionRequest
{
    public string Url { get; set; } = string.Empty;
}
