# BlogApi

This is an API designed for a Blog website, providing the necessary endpoints for managing blog posts. The project is structured to make it easy to extend and maintain.

## Project Overview

The BlogApi allows you to manage blog posts with attributes such as title, content, author, and an associated image. You are supposed to provides a functionality(endpoints) for creating, reading, updating, and deleting blog posts.

## Model Structure

The **Blog** model includes the following fields:

| Field   | Type   | Description                        |
|---------|--------|------------------------------------|
| `id`    | Guid   | Unique identifier for the blog post |
| `title` | string | Title of the blog post            |
| `content`| string| Content of the blog post          |
| `author`| string | Author of the blog post           |
| `image` | string | URL or path of the blog's image   |
| `date`  | string | Date when the blog was created    |
| `time`  | string | Time when the blog was created    |

## Getting Started

Follow these steps to set up and build the API:

### Prerequisites

- Ensure you have [Git](https://git-scm.com/) installed.
- Install [.NET](https://dotnet.microsoft.com/) (if applicable to your API structure).
- A GitHub account is required to clone the repository.

### Installation

1. Clone this repository:
   ```bash/cmd
   git clone <repository_url>
   ```
   Replace `<repository_url>` with the actual GitHub repository URL.

2. Navigate to the project directory:
   ```bash/cmd
   cd BlogApi
   ```

3. Build the project:
   ```bash/cmd
   dotnet build
   ```

4. Run the application:
   ```bash/cmd
   dotnet run
   ```

### Usage
- Use a tool like swagger, [Postman](https://www.postman.com/) or [cURL](https://curl.se/) to test the endpoints.

## Contributing


Happy coding! 🚀
