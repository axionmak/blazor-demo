# Blazor Blueprint Demo

A .NET 10 Blazor Server application showcasing the [Blazor Blueprint](https://github.com/blazorblueprintui/ui) UI component library with a comprehensive form example.

## Features

This demo application showcases the following Blazor Blueprint components:

- **Card** - Container components with header, content, and footer sections
- **Input** - Text input fields with placeholder support
- **Label** - Form labels
- **Select** - Dropdown selection with multiple options
- **Textarea** - Multi-line text input
- **RadioGroup** - Radio button groups for single selection (both vertical and horizontal orientations)
- **Slider** - Range slider for numeric input
- **Switch** - Toggle switch for boolean values
- **Checkbox** - Checkbox for boolean selection
- **Button** - Buttons with different variants (default, outline, secondary)
- **Separator** - Visual separator between sections
- **Alert** - Alert messages for user feedback
- **Dialog** - Modal dialogs for displaying content
- **PortalHost** - Required for overlay components like dialogs

## Form Features

The showcase form includes:

- **Personal Information**: Name, email, and phone number fields
- **Preferences**: Country selection, bio textarea, experience level radio buttons, favorite color selection
- **Satisfaction Slider**: Interactive slider from 0-10
- **Newsletter Switch**: Toggle for newsletter subscription
- **Terms & Conditions**: Checkbox that must be accepted before submission
- **Form Submission**: Stores form data in memory
- **View Submissions**: Dialog to view all submitted forms stored in memory

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Running the Application

1. Navigate to the project directory:
   ```bash
   cd BlazorBlueprintDemo
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to `http://localhost:5232` (or the URL shown in the terminal)

### Building the Application

```bash
dotnet build
```

## Project Structure

```
BlazorBlueprintDemo/
├── Components/
│   ├── Layout/          # Layout components
│   └── Pages/           # Page components
│       └── Home.razor   # Main showcase form
├── Services/
│   └── FormDataService.cs  # In-memory data storage service
├── wwwroot/
│   └── styles/
│       └── theme.css    # Blazor Blueprint theme configuration
└── Program.cs           # Application entry point
```

## Technologies Used

- **.NET 10** - Latest .NET framework
- **Blazor Server** - Server-side Blazor hosting model
- **Blazor Blueprint Components** (v2.3.0) - Styled UI components
- **Blazor Blueprint Primitives** (v2.1.1) - Headless primitive components
- **Blazor Blueprint Icons (Lucide)** (v2.0.0) - Icon library

## About Blazor Blueprint

Blazor Blueprint is a comprehensive UI component library for Blazor that brings the elegant design system of shadcn/ui to Blazor applications. It offers:

- 65+ styled components
- 15 headless primitives
- Full shadcn/ui theme compatibility
- Accessibility-first approach (WCAG 2.1 AA compliant)
- Built-in dark mode support
- Zero build tool requirements

For more information, visit [blazorblueprintui.com](https://blazorblueprintui.com)

## License

This demo project is for educational purposes.
