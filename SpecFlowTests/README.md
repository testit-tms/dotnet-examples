# SpecFlow example

Example of tests with SpecFlow framework and adapter for Test IT

## Setup

1. Install [.NET 6+](https://learn.microsoft.com/ru-ru/dotnet/core/install/windows?tabs=net70)
2. Clone this repository `git clone https://github.com/testit-tms/dotnet-examples.git && cd SpecFlow/SpecFlowTests`
3. Configure the tests to run in **Tms.config.json**
   file. [How to configure?](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#configuration)
4. Build the project `dotnet build`
5. Run tests via `dotnet test` to upload the results to TMS

## Project structure

* **SpecFlowTests/** - example project
    * **Attachments/** - attachment files for tests
    * **Features/annotations-tests.feature** – simple test examples
      with [annotations TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **Features/methods-tests.feature** – simple test examples
      with [methods TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **Features/steps-tests.feature** – simple test examples
      with [steps TestIt.Adapter](https://github.com/testit-tms/adapters-dotnet/tree/main/Tms.Adapter#attributes)
    * **Tms.config.json** - configuration file where specified base options for tests
