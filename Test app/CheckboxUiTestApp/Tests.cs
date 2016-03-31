using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CheckboxUiTestApp
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }

        [Test]
        public void TapCheck1()
        {
            app.Tap(c=>c.Marked("check1"));

            var check2 = app.Query("check2").First();
            Assert.IsTrue(check2.Enabled);
        }


    }
}

