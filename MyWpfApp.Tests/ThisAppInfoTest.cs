// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using NUnit.Framework;
using MyWPFApp;

namespace MyWPFApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var thisAppInfo = new ThisAppInfo();
        }

        [Test]
        public void GetDisplayName()
        {
            var displayName = ThisAppInfo.GetDisplayName();
            Assert.AreEqual("Not packaged", displayName);
        }

        [Test]
        public void GetAppInstallerUri()
        {
            var appInstallerUri = ThisAppInfo.GetAppInstallerUri();

            Assert.AreEqual("Not packaged", appInstallerUri);
        }

        [Test]
        public void customTest1()
        {
            var custom1 = ThisAppInfo.GetDisplayName();
            Assert.AreNotEqual("Package Found", custom1);
        }

        [Test]
        public void customTest2()
        {
            var custom1 = ThisAppInfo.GetAppInstallerUri();
            Assert.AreNotEqual("Package Found", custom1);
        }

        [Test]
        public void printSuccess()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
