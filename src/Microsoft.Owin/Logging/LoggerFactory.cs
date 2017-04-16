// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Owin.Logging
{
    /// <summary>
    /// Provides a default ILoggerFactory.
    /// </summary>
    public static class LoggerFactory
    {
        static LoggerFactory()
        {
#if NET45
            Default = new DiagnosticsLoggerFactory();
#else
            Default = null;
#endif
        }

        /// <summary>
        /// Provides a default ILoggerFactory based on System.Diagnostics.TraceSorce.
        /// </summary>
        public static ILoggerFactory Default { get; set; }
    }
}
