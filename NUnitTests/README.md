# NUnit example
Example of tests with NUnit framework and adapter for Test IT

## Setup

1. Install [.NET 6+](https://learn.microsoft.com/ru-ru/dotnet/core/install/windows?tabs=net70)
2. Clone this repository `git clone https://github.com/testit-tms/dotnet-examples.git && cd NUnitTests/NUnitTests`
3. Configure the tests to run in **Tms.config.json** file. [How to configure?](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#configuration)
4. build the project `dotnet build`
5. download [TmsRunner from Assets of release](https://github.com/testit-tms/adapters-dotnet/releases)
6. Run tests via `TmsRunner --runner "/usr/local/share/dotnet/sdk/6.0.302/vstest.console.dll" --testassembly "/tests/NUnitTests.dll"` to upload the results to TMS

## Project structure

* **NUnitTests/** - example project
    * **attachments/** - attachment files for tests
    * **AttributesTests.cs** – simple test examples with [annotations TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **MethodTests.cs** – simple test examples with [methods TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **StepsTests.cs** – simple test examples with [steps TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **Tms.config.json** - configuration file where specified base options for tests
