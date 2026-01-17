# CLAUDE.MD

## Project Overview
This is a personal portfolio website for dawoodali.co.nz built with ASP.NET Core 8.0 and Razor Pages.

## Tech Stack
- **Framework**: ASP.NET Core 8.0
- **UI**: Razor Pages
- **Language**: C#
- **Container**: Docker (Linux-based)
- **Dependencies**:
  - Newtonsoft.Json 13.0.3
  - Microsoft.VisualStudio.Azure.Containers.Tools.Targets 1.21.0

## Project Structure
```
.
├── Pages/              # Razor Pages (About, Blogs, Contact, Education, etc.)
├── wwwroot/           # Static files (CSS, JS, images)
├── Properties/        # Project properties
├── .config/           # Configuration files
├── Program.cs         # Application entry point
├── Dockerfile         # Container configuration
└── appsettings.json   # Application settings
```

## Development

### Prerequisites
- .NET 8.0 SDK
- Docker (optional, for containerized deployment)

### Running Locally
```bash
dotnet run
```

### Building
```bash
dotnet build
```

### Docker
```bash
docker build -t dawoodali-website .
docker run -p 8080:80 dawoodali-website
```

## Configuration
- Development settings: `appsettings.Development.json`
- Production settings: `appsettings.json`
- User secrets ID: `18587587-d504-4c58-a2e8-2d770df8b5a8`

## Key Features
- HTTPS redirection (disabled in development)
- Static file serving
- HSTS (HTTP Strict Transport Security) in production
- Exception handling with error page

## Working with Claude
When working on this project with Claude Code:

### Common Tasks
- **Adding new pages**: Create `.cshtml` and `.cshtml.cs` files in `Pages/` directory
- **Styling**: Add/modify CSS in `wwwroot/css/`
- **Static assets**: Place in `wwwroot/` directory
- **Configuration**: Update `appsettings.json` for app-wide settings

### Branch Information
- Main branch: `main`
- Current worktree: `agitated-montalcini`

### Notes
- Project uses nullable reference types
- Implicit usings are enabled
- Docker target OS is Linux
