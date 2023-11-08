<p align="center"><img src="assets/box.svg?raw=true" width="350" alt="Logo"></p>

<div align="center">
<img src="https://dev.azure.com/dimesoftware/Utilities/_apis/build/status/dimenics.services?branchName=master"/>
<img src="https://feeds.dev.azure.com/dimesoftware/_apis/public/Packaging/Feeds/a7b896fd-9cd8-4291-afe1-f223483d87f0/Packages/f6766b4e-2b3d-4874-bd8e-f1fb9fa8296c/Badge" />
</div>

<div align="center">
<h1>Services</h1>
</div>

## Introduction

Contracts for the service layer of any project.

## Getting Started

- You must have Visual Studio 2022 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

The most notable types in this assembly include:

- `IQueryService<T>`: matches the R in CRUD operators
- `ICommandService<T>`: matches the CUD in CRUD operations
- `IService<T>`: Defines the capabilities of both `IQueryService<T>` and `ICommandService<T>`
- `IServiceLocator`: Defines how to instantiate service class instances

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the package manager NuGet to install Dime.System:

`dotnet add package Dime.Services`

## Usage

``` csharp
using Dime;

public class CustomerService : ICustomerService<Customer>
{
  public async Task<IEnumerable<CustomerDto>> GetAllAsync<CustomerDto>()
  {
      IEnumerable<Customer> customers = await this.Context.Customers.ToListAsync();
      return customers.Select(x => this.Mapper.Map<CustomerDto>(x));
  }
}
```

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)
