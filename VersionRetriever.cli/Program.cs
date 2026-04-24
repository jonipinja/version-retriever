using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersionRetriever;

namespace VersionRetriever.cli
{
    class Program
    {
        static void Main(string[] args)
        {
            // No arguments -> print help.
            if (args.Count() == 0)
            {
                PrintHelp();
                return;
            }

            CommandLineParser parser = new CommandLineParser();

            // Add command line parameters.
            parser.AddParameter(new CliParameter("help", new List<string>() { "--help", "-h" }, true, typeof(string), false, true));
            parser.AddParameter(new CliParameter("source", new List<string>() { "--source", "-s" }, false, typeof(string), false));
            parser.AddParameter(new CliParameter("filename", new List<string>() { "--filename", "-fn" }, true, typeof(string), false));
            parser.AddParameter(new CliParameter("extensions", new List<string>() { "--extensions", "-ext" }, true, typeof(string), true));
            parser.AddParameter(new CliParameter("notes", new List<string>() { "--notes", "-n" }, true, typeof(string), false));

            // Parse command line. If true, go-on.
            // Will return false if mandatory parameter fails to parse.
            if (parser.ParseCommandLine(args))
            {
                // Check if help is requested.
                var help = parser.GetParameter("help");
                if (help.Parsed)
                {
                    PrintHelp();
                    return;
                }

                var par = parser.GetParameter("source");
                string source = par.GetParameterValue<string>();

                // Filename parsed.
                string filename = string.Empty;
                par = parser.GetParameter("filename");
                if (par.Parsed)
                {
                    filename = par.GetParameterValue<string>();
                }

                // Extensions parsed.
                IEnumerable<string> extensions = new List<string>();
                par = parser.GetParameter("extensions");
                if (par.Parsed)
                {
                    extensions = par.GetMultipleParameterValue<IEnumerable<string>, string>();
                }
                else
                {
                    extensions = new List<string>() { ".dll", ".exe", ".js" };
                }

                // Release notes parsed.
                string releaseNotes = string.Empty;
                par = parser.GetParameter("notes");
                if (par.Parsed)
                {
                    releaseNotes = par.GetParameterValue<string>();
                }

                VersionRetriever retriever = new VersionRetriever(source, extensions);
                if (!retriever.ReadFileVersions())
                {
                    Console.WriteLine("Error reading file versions.");
                    Console.WriteLine(retriever.ErrorMessage);
                    return;
                }

                // Output filename.
                string output = $"{source}\\{filename}";

                // If zip-archive, we need to make some special handling for the output file.
                string extension = Path.GetExtension(source);
                if (!string.IsNullOrWhiteSpace(extension) && extension.ToLowerInvariant() == ".zip")
                {
                    string dir = Path.GetDirectoryName(source);

                    // No filename given, lets use the zip's filename.
                    if (string.IsNullOrWhiteSpace(filename))
                    {
                        filename = $"{Path.GetFileNameWithoutExtension(source)}.md";
                    }

                    output = $"{dir}{Path.DirectorySeparatorChar}{filename}";
                }

                // No extension -> folder.
                // No filename given.
                else if (string.IsNullOrWhiteSpace(extension) && string.IsNullOrWhiteSpace(filename))
                {
                    string dir = Path.GetDirectoryName(source);
                    filename = Path.GetFileName(source);
                    output = $"{dir}{Path.DirectorySeparatorChar}{filename}";
                }

                VersionWriter writer = new VersionWriter(output);
                writer.WriteVersions(retriever, releaseNotes);
            }
            else
            {
                // Something funky with the command line.
                Console.WriteLine(parser.ErrorMessage);
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Command line parameters:");
            Console.WriteLine("--help, -h : Shows this help text.");
            Console.WriteLine("--source, -s : Source zip-file or folder where to get the version info.");
            Console.WriteLine("--filename, -fn : Output filename.");
            Console.WriteLine("--extensions, -ext : File extensions to consider, comma separated.");
            Console.WriteLine("--notes, -n : Release notes.");
            Console.WriteLine();
            Console.WriteLine("Usage:");
            Console.WriteLine("switch=\"value\"");
            Console.WriteLine("For example: --source=\"C:\\temp\\folder to check\\\"");
        }
    }
}
