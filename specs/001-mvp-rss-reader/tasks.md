# Tasks: MVP RSS Reader

**Input**: Design documents from `/specs/001-mvp-rss-reader/`

**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md

**Organization**: Tasks are grouped by user story to enable independent implementation and testing.

## Format: `[ID] [P?] [Story] Description`

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Create the minimal backend/frontend structure for the MVP.

- [ ] T001 Create backend and frontend project directories for the MVP implementation
- [ ] T002 Initialize the ASP.NET Core Web API backend with the minimal subscription API structure
- [ ] T003 Initialize the Blazor WebAssembly frontend with a simple subscriptions page
- [ ] T004 [P] Configure basic solution and project references for local development

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Create the shared infrastructure needed before user story work begins.

- [ ] T005 Create the subscription model and API request/response types in backend/src/Models/
- [ ] T006 Implement the in-memory subscription service in backend/src/Services/
- [ ] T007 Configure the backend API endpoints for add and list operations in backend/src/Api/
- [ ] T008 Configure the frontend HTTP client and service to call the backend API in frontend/src/Services/
- [ ] T009 Create the main subscriptions page and form in frontend/src/Pages/

**Checkpoint**: Foundation ready - the MVP flow can now be implemented end to end.

---

## Phase 3: User Story 1 - Add a feed subscription (Priority: P1) 🎯 MVP

**Goal**: Allow a user to add a subscription and see it appear in the list.

**Independent Test**: A user can enter a URL, submit it, and see the new subscription appear in the UI.

### Tests for User Story 1

- [ ] T010 [P] [US1] Add backend unit tests for adding a subscription in backend/tests/SubscriptionServiceTests.cs
- [ ] T011 [P] [US1] Add frontend smoke tests for the subscriptions form in frontend/tests/SubscriptionsPageTests.cs

### Implementation for User Story 1

- [ ] T012 [P] [US1] Add the subscription DTO and model definitions in backend/src/Models/Subscription.cs
- [ ] T013 [P] [US1] Implement add-subscription behavior in backend/src/Services/SubscriptionService.cs
- [ ] T014 [US1] Expose POST /api/subscriptions in backend/src/Api/SubscriptionsController.cs
- [ ] T015 [US1] Add UI form handling and submission logic in frontend/src/Pages/Subscriptions.razor
- [ ] T016 [US1] Connect the frontend page to the backend API service in frontend/src/Services/SubscriptionApiService.cs

**Checkpoint**: At this point, User Story 1 should be fully functional and testable independently.

---

## Phase 4: User Story 2 - View the current subscription list (Priority: P1)

**Goal**: Display the current list of subscriptions in the UI.

**Independent Test**: A user can open the app and see the current subscriptions after they have been added.

### Tests for User Story 2

- [ ] T017 [P] [US2] Add backend unit tests for retrieving the subscription list in backend/tests/SubscriptionServiceTests.cs
- [ ] T018 [P] [US2] Add frontend smoke tests for rendering the subscription list in frontend/tests/SubscriptionsPageTests.cs

### Implementation for User Story 2

- [ ] T019 [P] [US2] Implement list retrieval behavior in backend/src/Services/SubscriptionService.cs
- [ ] T020 [US2] Expose GET /api/subscriptions in backend/src/Api/SubscriptionsController.cs
- [ ] T021 [US2] Render the list and empty state in frontend/src/Pages/Subscriptions.razor
- [ ] T022 [US2] Refresh the list after successful add operations in frontend/src/Pages/Subscriptions.razor

**Checkpoint**: At this point, User Stories 1 and 2 should both work independently.

---

## Phase 5: User Story 3 - Use the app as a simple local demo (Priority: P2)

**Goal**: Ensure the app runs locally and supports the MVP flow without setup friction.

**Independent Test**: The app starts locally and allows the subscription workflow without runtime routing or startup errors.

### Tests for User Story 3

- [ ] T023 [P] [US3] Add a startup smoke test for the backend in backend/tests/StartupTests.cs
- [ ] T024 [P] [US3] Add a basic frontend startup smoke test in frontend/tests/StartupTests.cs

### Implementation for User Story 3

- [ ] T025 [US3] Verify and adjust backend startup configuration in backend/src/Program.cs
- [ ] T026 [US3] Verify and adjust frontend startup configuration in frontend/src/Program.cs
- [ ] T027 [US3] Remove template demo pages or routing conflicts if present in frontend/src/Pages/
- [ ] T028 [US3] Validate the local quickstart flow in specs/001-mvp-rss-reader/quickstart.md

**Checkpoint**: The MVP should now be independently functional and easy to demo locally.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Improve quality and make the implementation ready for review.

- [ ] T029 [P] Add documentation comments and finalize API naming in backend/src/
- [ ] T030 [P] Refactor shared UI logic for clarity in frontend/src/
- [ ] T031 [P] Run the relevant tests and local verification steps for the MVP flow
- [ ] T032 [P] Review the implementation against the constitution and feature requirements
