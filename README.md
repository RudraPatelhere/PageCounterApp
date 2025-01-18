# PageCounterApp

## Overview
PageCounterApp is a basic ASP.NET Core MVC web application that demonstrates:
- Tracking page visit counts dynamically.
- Implementing a service layer to manage business logic.
- Using Razor views for rendering dynamic content.
- Navigation between pages with updated visit counts.

## Features
- **Page Visit Tracking**: Keeps a count of how many times each page has been visited during the application's runtime.
- **Service Layer**: Uses `IPageCounterService` and `PageCounterService` to handle counting logic independently of the controller.
- **Dynamic Views**: Displays the visit count dynamically on each page.
- **Navigation**: Simple navigation between the Home and Other pages.

## Technologies Used
- ASP.NET Core MVC
- Razor Views
- Dependency Injection
- C#

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/PageCounterApp.git
