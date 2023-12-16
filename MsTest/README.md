# MsTest example

Example of tests with MsTest framework and adapter for Test IT

## Setup

1. Install [.NET 6+](https://learn.microsoft.com/ru-ru/dotnet/core/install/windows?tabs=net70)
2. Clone this repository `git clone https://github.com/testit-tms/dotnet-examples.git && cd MsTest/MsTest`
3. Configure the tests to run in **Tms.config.json**
   file. [How to configure?](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#configuration)
4. Build the project `dotnet build`
5. Download [TmsRunner from Assets of release](https://github.com/testit-tms/adapters-dotnet/releases)
6. Run tests
   via `TmsRunner --runner "/usr/local/share/dotnet/sdk/6.0.302/vstest.console.dll" --testassembly "/tests/MsTest.dll"`
   to upload the results to TMS

## Project structure

* **MsTest/** - example project
    * **Attachments/** - attachment files for tests
    * **Tests/AttributesTests.cs** – simple test examples
      with [annotations TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **Tests/MethodTests.cs** – simple test examples
      with [methods TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **Tests/StepsTests.cs** – simple test examples
      with [steps TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **Tms.config.json** - configuration file where specified base options for tests
