# How to run

This repository needs the following prerequisites installed:
* [.Net 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* [.Net Stryker](https://stryker-mutator.io/docs/stryker-net/Getting-started)

On your preferred commandline switch to the root of this repository. 

You can now do the following:

* Build the solution using `dotnet build`.

* Run the tests using `dotnet test`.

* Run mutation testing using `dotnet stryker --solution-path MutationTesting.sln`

# Mutation Testing Report

[Mutation Testing Report for the current commit](./mutation-report.html)