using System.Reflection;
using cproject.Properties;

internal static class Program
{
    static void Main(string[] args)
    {
        static void createProject(string projectType) {
            var currentDirectory = Environment.CurrentDirectory;
            var assetsDirectory = currentDirectory + @"\assets\";

            switch (projectType) {
                case "html":
                    try
                    {
                        Directory.CreateDirectory(assetsDirectory);
                        using (FileStream htmlf = File.Create(currentDirectory + "index.html"))
                        using (FileStream stylef = File.Create(assetsDirectory + "style.css"))
                        using (FileStream scriptf = File.Create(assetsDirectory + "script.js"))

                        Thread.Sleep(500);
                        File.WriteAllText(currentDirectory + "index.html", Resources.htmltemplate);
                        Console.WriteLine("The project is created succesfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                        Thread.Sleep(500000);
                        throw;
                    }
                    break;

                case "c++" or "cpp":
                    try
                    {
                        Directory.CreateDirectory(assetsDirectory);
                        using (FileStream htmlf = File.Create(currentDirectory + "main.cpp"))

                        Thread.Sleep(500);
                        File.WriteAllText(currentDirectory + "index.html", Resources.cpptemplate);
                        Console.WriteLine("The project is created succesfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                        Thread.Sleep(500000);
                        throw;
                    }
                    break;

                case "bootstrap":
                    try
                    {
                        Directory.CreateDirectory(assetsDirectory);
                        using (FileStream htmlf = File.Create(currentDirectory + "index.html"))
                        using (FileStream stylef = File.Create(assetsDirectory + "style.css"))
                        using (FileStream scriptf = File.Create(assetsDirectory + "script.js"))

                        Thread.Sleep(500);
                        File.WriteAllText(currentDirectory + "index.html", Resources.boostraptemplate);
                        Console.WriteLine("The project is created succesfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                        Thread.Sleep(500000);
                        throw;
                    }
                    break;
            }

            Console.WriteLine(assetsDirectory);
        }

        if (args.Length == 0)
        {
            var versionString = Assembly.GetEntryAssembly()?
                                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                                    .InformationalVersion
                                    .ToString();

            Console.WriteLine($"create v{versionString}");
            Console.WriteLine("-------------");
            Console.WriteLine("\nUsage:");
            Console.WriteLine("  create <html, c++, bootstrap>");
            return;
        }

        createProject(string.Join(' ', args));
    }
}