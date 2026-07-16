<!-- Sync Impact Report
- Version change: 0.0.0 → 1.0.0
- Modified principles: Added four project-specific principles for security, maintainability, verifiability, and MVP-first delivery
- Added sections: Additional Constraints, Development Workflow
- Removed sections: None
- Templates requiring updates: .specify/templates/plan-template.md ✅ aligned, .specify/templates/spec-template.md ✅ aligned, .specify/templates/tasks-template.md ✅ aligned
- Follow-up TODOs: None
-->

# RSS Feed Reader Constitution

## Core Principles

### I. Security by Default
All new features and integrations MUST treat feed URLs, user input, and external content as untrusted data. Input must be validated at the boundary, configuration must avoid hardcoded secrets, and network-facing code must fail safely with clear errors. When feed content is eventually rendered, it MUST be handled in a way that prevents script execution or unsafe HTML behavior.

### II. Maintainability by Design
The codebase MUST remain easy to understand and evolve. Backend and frontend responsibilities must stay separated, naming must be explicit, and new abstractions must be introduced only when they reduce complexity. Changes should favor simple structures over clever shortcuts, especially while the project is still in MVP development.

### III. Testable and Verifiable Quality
The project MUST verify core behavior with automated tests and local validation steps. For the MVP, tests MUST cover adding a subscription and confirming it appears in the UI; for later feed-processing work, tests MUST cover parsing and failure handling as they are introduced. A feature is not complete until it builds and the relevant tests or checks pass locally.

### IV. MVP-First Delivery Discipline
The project MUST deliver the smallest valuable slice first and defer non-MVP behavior until the core workflow is proven. The initial implementation will support adding and listing subscriptions only; feed fetching, persistence, background polling, and advanced UI behavior remain explicitly deferred until the MVP is verified.

## Additional Constraints

The implementation MUST remain consistent with the chosen ASP.NET Core Web API and Blazor WebAssembly architecture. Configuration values such as the API base URL, frontend port, and CORS origins MUST be kept consistent across local development settings to avoid broken integration.

The project MUST also preserve a clean startup experience. Template demo pages and routing conflicts MUST be removed before feature work proceeds, and the application must be verified locally before moving to the next phase of implementation.

## Development Workflow

Every change MUST be tied to a clear requirement from the stakeholder documents and must leave the project in a verifiable state. Before implementation, the team MUST confirm the intended scope, identify the smallest acceptable delivery, and define how success will be checked.

During development, changes MUST be validated through build and runtime checks relevant to the feature. For UI work, this includes confirming the app starts without routing errors; for API or configuration changes, this includes confirming the expected endpoints and CORS behavior work as intended.

## Governance

This constitution supersedes informal preferences and shortcuts when requirements conflict. Any change to these principles or constraints MUST be documented, justified, and reflected in the relevant planning and implementation artifacts before the work proceeds.

Compliance is reviewed through the planning, implementation, and verification workflow. Each feature or change MUST show how it satisfies the applicable principles, and any exception MUST be explicitly documented rather than silently accepted.

**Version**: 1.0.0 | **Ratified**: 2026-07-15 | **Last Amended**: 2026-07-15
