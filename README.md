# Sitecore Pre-Interview Tasks

This repository contains the source code and unit tests for the Sitecore Pre-Interview Tasks.

## Project Structure

- **SitecorePreInterviewTasks**: Contains the core functionality of the application.
- **SitecorePreInterviewTasks.UnitTests**: Contains the unit tests for the core functionality.

## Table of Contents
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Building the Project](#building-the-project)
  - [Running Unit Tests](#running-unit-tests)
  - [Dependencies](#dependencies)

## Getting Started


### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/)

### Building the Project

To build the project using .NET CLI, navigate to the root directory and run:

```dotnet build```

To build the project using Visual Studio:
1. Open the solution file (`SitecorePreInterviewTasks.sln`) in Visual Studio.
2. Right-click on the solution in the Solution Explorer and select "Build Solution".

### Running Unit Tests

To run the unit tests using .NET CLI, navigate to the SitecorePreInterviewTasks.UnitTests directory and execute:

```dotnet test```

To run the unit tests using Visual Studio:
1. Open the Test Explorer window (`Test` > `Windows` > `Test Explorer`).
2. Click on the "Run All Tests" button.

### Dependencies
- coverlet.collector: Code coverage tool.
- Microsoft.NET.Test.Sdk: .NET test SDK.
- MSTest.TestAdapter: Adapter for running MSTest tests.
- MSTest.TestFramework: MSTest framework.
