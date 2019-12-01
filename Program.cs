using System;
using System.Threading.Tasks;

namespace ChildProcesses
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            using var parcel = new NpmScript();

            await parcel.RunAsync(Console.WriteLine);

            Console.WriteLine(parcel.HasServer
                ? $"From ASP.NET Core. Parcel is started ({parcel.HasServer}) @ {parcel.Url} at process: {parcel.ProcessId}"
                : "Script has executed.");

            await Task.Delay(TimeSpan.FromSeconds(4));
        }
    }
}