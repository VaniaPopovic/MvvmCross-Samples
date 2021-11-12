using System;
using MvvmCross;
using MvvmCross.Logging;

namespace ApiExamples.Core
{
    public static class Logs
    {
        public static IMvxLog Instance { get; } = Mvx.IoCProvider.Resolve<IMvxLogProvider>().GetLogFor("ApiExamples");
    }
}
