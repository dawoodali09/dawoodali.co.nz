# dawoodali.co.nz

Personal portfolio website built with ASP.NET Core 8.0 and Razor Pages.

## Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Docker (optional, for containerized deployment)

### Running the Application

#### Local Development
```bash
dotnet restore
dotnet run
```

The application will be available at `https://localhost:5001` (or the port shown in the console).

#### Using Docker
```bash
docker build -t dawoodali-website .
docker run -p 8080:80 dawoodali-website
```

## Project Structure

- `Pages/` - Razor Pages (About, Blogs, Contact, Education, etc.)
- `wwwroot/` - Static files (CSS, JavaScript, images)
- `Properties/` - Project configuration
- `Program.cs` - Application entry point and configuration

## Tech Stack

- **Framework**: ASP.NET Core 8.0
- **UI**: Razor Pages
- **Language**: C# with nullable reference types
- **Containerization**: Docker (Linux)

## Development

### Build
```bash
dotnet build
```

### Configuration
- Development settings: `appsettings.Development.json`
- Production settings: `appsettings.json`

## License

See [LICENSE.txt](LICENSE.txt) for details.