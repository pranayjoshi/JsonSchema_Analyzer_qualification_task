# ExistingLibrary

ExistingLibrary is a .NET library that provides a source generator for the `GeneratedAttribute` and exposes the `ServiceProvider` class.

## Installation

To use ExistingLibrary in your project, you need to install the `ExistingLibrary` NuGet package. Following are the steps to install `ExistingLibrary` package:

### Step 1 (Directory Setup)
1. Open your project in the integrated terminal.
2. Make sure you have `dotnet-sdk` installed on your system. You can verify the installation by running `dotnet --version` command.
3. In the next step, navigate to the directory of ExistingLibrary project. You can do this with the cd command. For example: `cd path/to/JsonSchema.GSoC2024.ExistingLibrary`.
### Step 2 (Nuget Setup for local packages)
1. Now you need to add the `JsonSchema.GSoC2024.ExistingLibrary.1.0.0.nupkg` file to the local nuget source.
2. Use `dotnet nuget list source`. It will return you an output containing all the `nuget sources` and their information.
![sources](./asset/sources_ss.png)
3. If you dont have a local source setuped, you can create a local nuget source by `dotnet nuget add source <ABSOLUTE/path/to/the/directory> -n local`, where the path is the location you want to save your local nuget packages.
4. Then again use `dotnet nuget list source` to verify committed changes.
5. After that in the `JsonSchema.GSoC2024.ExistingLibrary` navigate to the `.nupkg` file which will be in `\bin\Release` folder and copy its ABSOLUTE path.
6. After that in the terminal use the command, `dotnet nuget push <path you just copied> -s local`
7. That's all, the `JsonSchema.GSoC2024.ExistingLibrary` is pushed to your nuget source.
8. NOTE: Paths cannot be Relative, all the paths must be Absolute.

### Step 3 (Adding the package to your Project)
1. Navigate to your project and open terminal.
2. There might be case when the project with the same name exists on `Nuget.org` therefore it is a good practise to temporarily disable global fetching by using this command `dotnet nuget disable source nuget.org`.
3. The next step is to add the required nuget package, you can do this by running the following command `dotnet add package JsonSchema.GSoC2024.ExistingLibrary`.
4. This will install the `ExistingLibrary` package to your project.
5. Make sure to re-enable `nuget.org` by`dotnet nuget enable source nuget.org` command.
6. That's all, `dotnet add package JsonSchema.GSoC2024.ExistingLibrary` is successfully added to your project! You can verify this by going to your `.csproj` file, which will contain a `<Package Refrence>` to `JsonSchema.GSoC2024.ExistingLibrary`.


## Usage

After installing the NuGet package, you can use the `ServiceProvider` class and the `GeneratedAttribute` in your code.

### Using the `ServiceProvider`

```csharp
using JsonSchema.GSoC2024.ExistingLibrary;

namespace YourNamespace
{
    public class YourClass
    {
        public void YourMethod()
        {
            var serviceProvider = new ServiceProvider();
            // Use the ServiceProvider here
        }
    }
}
```


### Using the `GeneratedAttribute`

```csharp
using JsonSchema.GSoC2024.ExistingLibrary;

namespace YourNamespace
{
    public class YourClass
    {
        public void YourMethod()
        {
            var GeneratedAttribute = new GeneratedAttribute(<path/to/the/json>, <qualification name>);
            // Use the ServiceProvider here
        }
    }
}
```

## Credits

Thanks to "Stefan Pölz" for this wonderful video on Incremental Source Analyzer

https://www.youtube.com/watch?v=BfYxZ4mfv0E