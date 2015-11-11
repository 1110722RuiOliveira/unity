﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Unity.Configuration;
using System;
using Xunit;

namespace Unity.TestSupport.Configuration
{
    public abstract class SectionLoadingFixture<TResourceLocator>: IDisposable
    {
        protected UnityConfigurationSection section;
        private readonly string configFileName;
        protected string SectionName { get; private set; }

        protected SectionLoadingFixture(string configFileName)
            : this(configFileName, "unity")
        {
        }

        protected SectionLoadingFixture(string configFileName, string sectionName)
        {
            this.configFileName = configFileName;
            this.SectionName = sectionName;
        }

        protected virtual void Arrange()
        {
            var loader = new ConfigFileLoader<TResourceLocator>(configFileName);
            section = loader.GetSection<UnityConfigurationSection>(SectionName);
        }

        protected virtual void Act()
        {
        }

        protected virtual void Teardown()
        {
        }

        public void MainSetup()
        {
            Arrange();
            Act();
        }

        public void MainTeardown()
        {
            Teardown();
        }

        public void Dispose()
        {
            MainTeardown();
        }
    }
}
