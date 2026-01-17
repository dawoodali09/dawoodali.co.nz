# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build and Run Commands

```bash
# Run locally (hot reload enabled in development)
dotnet run

# Build only
dotnet build

# Docker build and run
docker build -t dawoodali-website .
docker run -p 8080:80 dawoodali-website
```

## Architecture Overview

This is a static portfolio website built with ASP.NET Core 8.0 Razor Pages. There is no database - all content is hardcoded in the Razor views.

### Page Structure

**Root-level pages** (`Pages/*.cshtml`) are the main site pages:
- `Index.cshtml` - Homepage with video background (desktop) and static content (mobile)
- `About.cshtml`, `WorkHistory.cshtml`, `Education.cshtml`, `Skills.cshtml` - Portfolio sections
- `Contact.cshtml` - Contact form with reCAPTCHA
- `_Layout.cshtml` in `Pages/Shared/` - Master layout with navbar, sidebar menu, and footer

**Home subdirectory** (`Pages/Home/*.cshtml`) contains older/alternative versions of pages - the root-level pages are the active ones.

### Styling Architecture

CSS files in `wwwroot/css/`:
- `bootstrap.css` - Bootstrap 3 framework
- `basic.css` - Base layout styles (sidebar, navbar, page wrapper)
- `custom.css` - Primary custom styles for all pages
- `improvements.css` - Recent style fixes and enhancements
- `font-awesome2.min.css` - Font Awesome 5.15.3 icons

The site uses Font Awesome 5 classes (`fas`, `fab`, `far`) for icons. Do not mix with Font Awesome 4 syntax.

### Layout System

The layout uses a fixed sidebar navigation pattern:
- `#wrapper` - Main container
- `.navbar-cls-top` - Top header bar (hidden on mobile)
- `.navbar-side` - Left sidebar with navigation links
- `#page-wrapper` > `#page-inner` - Main content area
- `#footer-sec` - Fixed footer

Pages set their title via `ViewBag.Title` which displays in the sidebar caption.

### Static Assets

- `wwwroot/assets/img/` - Images (logos, profile photos)
- `wwwroot/assets/Files/` - Downloadable files (PDF resume, documents)
- `wwwroot/assets/js/` - JavaScript libraries (jQuery, Bootstrap, metisMenu)

### Performance Features

The app uses memory caching, response compression, output caching, and 7-day static file caching (configured in `Program.cs`).
