# RSI Template — Festify API

A **.NET 8** Web API starter focused on clear, teachable patterns: one controller class per route/action (“vertical slice” style), **Entity Framework Core** with **SQL Server**, **FluentValidation**, **Swagger**, and a **custom session-style token** stored in the database (not JWT for the main auth flow).

Use it as a backend template for courses, prototypes, or apps that need CRUD over reference data (countries, cities, genders, categories) plus username/password login.

---

## Features

- **Swagger UI** at `/swagger` with an **`my-auth-token` header** parameter so you can try protected endpoints after login.
- **Custom authentication**: random token persisted in `MyAuthenticationTokens`; validated per request via `IMyAuthService` (easy to reason about and revoke).
- **Role checks** via `[MyAuthorizationAttribute]` (admin / user flags on the authenticated principal).
- **CORS** configured to allow any origin (suitable for local dev with a separate frontend).
- **SignalR** registered in DI (hub mapping is commented out—ready to extend).
- **EF Core migrations** included; optional **data seeding** in `OnModelCreating`.

---

## Tech stack

| Area | Choice |
|------|--------|
| Runtime | .NET 8 |
| Web | ASP.NET Core |
| ORM | EF Core 6 (SQL Server provider) |
| Validation | FluentValidation |
| API docs | Swashbuckle (Swagger) |
| Images (seed helper) | SkiaSharp |

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server) (LocalDB, Express, or full instance) reachable from your machine

---

## Getting started

### 1. Clone and open the solution

```bash
cd "path/to/RSI Template/backend"
dotnet restore Festify.sln
```

### 2. Configure the database connection

Set the `ConnectionStrings:db1` value to point at your SQL Server instance. **Do not commit real passwords**—prefer [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets) or environment variables:

```bash
cd Festify
dotnet user-secrets set "ConnectionStrings:db1" "Server=.;Database=FestifyDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
```

Adjust server name, database name, and authentication to match your environment.

### 3. EF Core tools (optional local install)

The repo includes a tool manifest under `Festify/.config/dotnet-tools.json`. Restore tools from the project directory:

```bash
cd Festify
dotnet tool restore
```

### 4. Apply migrations

```bash
cd Festify
dotnet ef database update
```

If `dotnet ef` is not found, install the global tool once:  
`dotnet tool install --global dotnet-ef`

### 5. Run the API

```bash
cd Festify
dotnet run
```

Default dev URLs (see `Properties/launchSettings.json`):

- HTTP: `http://localhost:5174`
- HTTPS: `https://localhost:5175`
- Swagger: `http://localhost:5174/swagger` (or the HTTPS equivalent)

---

## Using the API

1. Open **Swagger**.
2. Call **`POST /auth/login`** with `username` and `password` (users must exist in the database; seed or insert as needed).
3. Copy the returned token and paste it into the **`my-auth-token`** header for subsequent requests (added globally in Swagger via `MyAuthorizationSwaggerHeader`).

Protected endpoints use `[MyAuthorizationAttribute(...)]` to require admin and/or user privileges.

---

## HTTP route map (high level)

| Prefix | Purpose |
|--------|---------|
| `/auth` | Login, logout, current user info |
| `/countries`, `/cities`, `/genders`, `/categories` | CRUD-style endpoints for each entity |
| `/users` | User listing (as implemented) |
| `/data-seed` | Development / seeding utilities |

Exact verbs and DTOs are defined on each endpoint class under `Endpoints/`.

---

## Project layout

```
backend/
├── Festify.sln
└── Festify/
    ├── Program.cs                 # App composition, Swagger, CORS, DB context
    ├── appsettings.json         # Configuration (override secrets locally)
    ├── Data/                    # DbContext, models, seeding
    ├── Endpoints/               # One class per API action (by feature folder)
    ├── Helper/                  # API base classes, Swagger filter, utilities
    ├── Services/                # Auth service, authorization filter attribute
    └── Migrations/              # EF Core migrations
```

Endpoint classes inherit from `MyEndpointBase` / `MyEndpointBaseAsync` in `Helper/Api/`, following a single-action controller style similar in spirit to [Ardalis.ApiEndpoints](https://github.com/ardalis/ApiEndpoints).

---

## Development notes

- **Environment-specific settings**: use `appsettings.Development.json` and User Secrets for local overrides.
- **Security**: replace permissive CORS and tighten headers/TLS before production.
- **Package versions**: some packages (e.g. EF Core tools manifest vs. referenced EF version) may differ; align versions if you hit tooling warnings.

---

## License

No license file is present in this template. Add one if you distribute the project.
