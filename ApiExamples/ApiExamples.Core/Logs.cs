using System;
using Microsoft.Extensions.Logging;
using MvvmCross;
using MvvmCross.Logging;

namespace ApiExamples.Core
{
    public static class Logs
    {
        public static ILogger Instance { get; } = Mvx.IoCProvider.Resolve<ILoggerProvider>().CreateLogger("ApiExamples");
    }
}
