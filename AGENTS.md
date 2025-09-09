# Repository Guidelines

## Project Structure & Module Organization
- `Program.cs`: Console entry point and current business logic.
- `energy_consumption_calculator.csproj`: .NET 8 project configuration.
- `bin/` and `obj/`: Build outputs (not meant for version control).
- `README.md`: Assignment and functional requirements.
- `shell.nix`, `.envrc`: Development environment via Nix/direnv.

## Build, Test, and Development Commands
- Environment: `direnv allow` to auto-load the Nix shell, or `nix-shell`.
- Restore deps: `dotnet restore` — ensures NuGet packages are ready.
- Build: `dotnet build` — compiles the project to `bin/`.
- Run: `dotnet run` — runs the console app from this project.
- Clean: `dotnet clean` — removes build outputs.
- Test: `dotnet test` — once a test project exists (see below).

## Coding Style & Naming Conventions
- Indentation: 4 spaces; trim trailing whitespace.
- Braces: Allman style (opening brace on a new line) to match current code.
- C# naming: PascalCase for types/methods/constants; camelCase for locals/parameters; `_camelCase` for private fields.
- Files: Prefer one public type per file; name files after the type (e.g., `EnergyCalculator.cs`).
- Formatting: Run `dotnet format` before commits (if installed) to keep consistent style.

## Testing Guidelines
- Framework: xUnit recommended.
- Layout: `tests/EnergyConsumptionCalculator.Tests` as a separate test project.
- Create: `dotnet new xunit -n EnergyConsumptionCalculator.Tests -o tests/EnergyConsumptionCalculator.Tests` then `dotnet add tests/EnergyConsumptionCalculator.Tests/EnergyConsumptionCalculator.Tests.csproj reference energy_consumption_calculator.csproj`.
- Naming: `MethodName_Scenario_ExpectedResult` and `Fact`/`Theory` attributes as appropriate.
- Run: `dotnet test` from the repo root.

## Commit & Pull Request Guidelines
- Commits: Imperative mood, concise summary (<72 chars). Optional scoped prefix, e.g., `Program: calculate daily kWh`.
- PRs: Include a clear description, rationale, test plan (commands + output), and sample console output/screenshots when UI changes.
- Requirements: All builds green, tests passing, no unrelated changes in the diff. Link issues when applicable.

## Security & Configuration Tips
- Do not commit secrets; this app uses no credentials by default.
- Nix shell disables .NET telemetry; respect repository tooling and environment files.
