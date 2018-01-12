using Avalonia.Logging.Serilog;
using System;
using System.Linq;
using System.Reflection;
using Avalonia;

namespace AvaloniaExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>();
        }
    }
}
