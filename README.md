# DBLMF

An open source experimental dragon ball legends modding framework made in CSharp.

## navigation



**wiki** - [`DBLMF Wiki`](https://github.com/GodkuProjectReborn/DBLMF/wiki)

**Releases** - [`DBLMF Releases`](https://github.com/GodkuProjectReborn/DBLMF/releases)

**Discord** - [`Godku Project Reborn`](https://discord.gg/godkuprojectreborn)


## how to integrate `InvertFile.dll` into your code

```csharp
// example usage by godku project

using System;
using System.IO;
using System.Reflection;
using InvertFile;

namespace InvertFileProcessor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Drag and drop a file onto this executable to process it.");
                Console.ReadLine();
                return;
            }

            string filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"The file '{filePath}' does not exist.");
                return;
            }

            try
            {
                Assembly invertFileAssembly = Assembly.LoadFrom("InvertFile.dll");
                
                Type invertFileType = invertFileAssembly.GetType("InvertFile.InvertFile");

                MethodInfo processFileMethod = invertFileType.GetMethod("ProcessFile", BindingFlags.Public | BindingFlags.Static);

                if (processFileMethod != null)
                {
                    processFileMethod.Invoke(null, new object[] { filePath });
                    Console.WriteLine("File processed successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to find the ProcessFile method in InvertFile.dll.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
```

### how to compile the example code

First you need [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Then make the file and a .csproj (will be provided in the wiki soon)

Finally use `dotnet build` and if there are ANY errors make an [issue](https://github.com/GodkuProjectReborn/DBLMF/issues) and we will (hopefully) fix the example code and help troubleshoot it.
