
#if !NET45
// ReSharper disable once CheckNamespace
namespace System.Diagnostics
{
    /// <summary>Identifies the type of event that has caused the trace.</summary>
    public enum TraceEventType
    {
        Critical = 1,
        Error = 2,
        Warning = 4,
        Information = 8,
        Verbose = 16,
        Start = 256,
        Stop = 512,
        Suspend = 1024,
        Resume = 2048,
        Transfer = 4096,
    }
}
#endif
