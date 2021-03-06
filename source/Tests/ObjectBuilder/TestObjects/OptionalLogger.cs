﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using ObjectBuilder2.Tests.TestDoubles;

namespace ObjectBuilder2.Tests.TestObjects
{
    internal class OptionalLogger
    {
        private string logFile;

        public OptionalLogger([Dependency] string logFile)
        {
            this.logFile = logFile;
        }

        public string LogFile
        {
            get { return logFile; }
        }
    }
}
