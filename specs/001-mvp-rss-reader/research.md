# Research: MVP RSS Reader

## Decision: Use a simple API-backed subscription flow

The MVP will implement a minimal subscription-management flow with:

- A backend API endpoint to create a subscription
- A backend API endpoint to retrieve the current list
- A Blazor page that collects user input and displays the list
- An in-memory collection that persists only for the current process

## Rationale

This approach matches the stakeholder goals for a simple proof of concept while keeping the architecture consistent with the ASP.NET Core + Blazor plan. It also keeps the implementation easy to test and easy to extend later with persistence or feed fetching.

## Alternatives considered

1. Single-page Blazor-only implementation with local state only
   - Rejected because it does not reflect the planned API/backend split and would make future integration harder.

2. Full feed-fetching implementation in the MVP
   - Rejected because the MVP explicitly requires only subscription creation and list display.

## Implementation decisions

- Empty submissions will be ignored.
- Duplicate subscriptions will be prevented using a case-insensitive comparison.
- The UI will show a simple empty state when no subscriptions exist.
- Feed URLs will be treated as untrusted input but accepted as plain strings for the MVP flow.
