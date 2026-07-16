# Data Model: MVP RSS Reader

## Entity: Subscription

A subscription represents one feed URL the user has chosen to track in the MVP.

**Fields**:
- Id: unique identifier for the subscription
- Url: string containing the feed URL entered by the user

**Validation rules**:
- Url MUST be non-empty.
- Duplicate Url values MUST be ignored for the same session.

## Entity: SubscriptionList

A subscription list represents the current set of subscriptions visible to the user.

**Behavior**:
- The list is populated by the backend API.
- The list is updated after each successful add operation.

## Relationships

- One subscription list contains zero or more subscriptions.
- Each subscription belongs to exactly one active subscription list for the current session.
