using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace FindMyBLEDevice.UITests
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

        /*
        
            Important Note: Mind that you always have to have installed the latest version of the app!
                    Running tests does NOT push the app to the running emulator, it justs starts the existing version.

            Some examples:

            Interactive mode: useful for setting up tests.
            `app.Repl();`

            Search ("query") (until it shows up, in case of animations etc.) for UI-Elements via their "AutomationId". 
            `AppResult[] results = app.WaitForElement(c => c.Marked("Page_About"));`

            Search ("query") for UI-Elements via their "AutomationId". 
            `appResult[] results2 = app.Query(c => c.Marked("Page_About"));`
            `Assert.IsTrue(results.Any());`

            Mimick user actions
            `app.Tap(c => c.Marked("Btn_ID"));`

         */


        [Test]
        public void OpenAboutPage()
        {

            // Assert "About"-Screen is shown
            AppResult[] results = app.Query(c => c.Marked("Page_About"));
            Assert.IsTrue(results.Any());

            // Tap on menu drawer
            app.Tap(c => c.Marked("Open navigation drawer"));

            // Wait for drawer
            AppResult[] results2 = app.WaitForElement(c => c.Marked("FlyoutItem_About"));
            Assert.IsTrue(results2.Any());

            // Open devices page
            app.Tap(c => c.Marked("FlyoutItem_About"));

            // Assert that devices page (or at least one element from the page) is visible
            AppResult[] results3 = app.WaitForElement(c => c.Marked("Page_About"));
            Assert.IsTrue(results3.Any());

        }


        [Test]
        public void OpenDevicesPage()
        {

            // Assert "About"-Screen is shown
            AppResult[] results = app.Query(c => c.Marked("Page_About"));
            Assert.IsTrue(results.Any());

            // Tap on menu drawer
            app.Tap(c => c.Marked("Open navigation drawer"));

            // Wait for drawer
            AppResult[] results2 = app.WaitForElement(c => c.Marked("FlyoutItem_Devices"));
            Assert.IsTrue(results2.Any());

            // Open devices page
            app.Tap(c => c.Marked("FlyoutItem_Devices"));

            // Assert that devices page (or at least one element from the page) is visible
            AppResult[] results3 = app.WaitForElement(c => c.Marked("Page_Devices"));
            Assert.IsTrue(results3.Any());

        }

        [Test]
        public void OpenStrengthPage()
        {

            // Assert "About"-Screen is shown
            AppResult[] results = app.Query(c => c.Marked("Page_About"));
            Assert.IsTrue(results.Any());

            // Tap on menu drawer
            app.Tap(c => c.Marked("Open navigation drawer"));

            // Wait for drawer
            AppResult[] results2 = app.WaitForElement(c => c.Marked("FlyoutItem_Strength"));
            Assert.IsTrue(results2.Any());

            // Open devices page
            app.Tap(c => c.Marked("FlyoutItem_Strength"));

            // Assert that devices page (or at least one element from the page) is visible
            AppResult[] results3 = app.WaitForElement(c => c.Marked("Page_Strength"));
            Assert.IsTrue(results3.Any());

        }


        [Test]
        public void OpenMapsPage()
        {

            // Assert "About"-Screen is shown
            AppResult[] results = app.Query(c => c.Marked("Page_About"));
            Assert.IsTrue(results.Any());

            // Tap on menu drawer
            app.Tap(c => c.Marked("Open navigation drawer"));

            // Wait for drawer
            AppResult[] results2 = app.WaitForElement(c => c.Marked("FlyoutItem_Map"));
            Assert.IsTrue(results2.Any());

            // Open devices page
            app.Tap(c => c.Marked("FlyoutItem_Map"));

            // Assert that devices page (or at least one element from the page) is visible
            AppResult[] results3 = app.WaitForElement(c => c.Marked("Page_Map"));
            Assert.IsTrue(results3.Any());

        }

        [Test]
        public void OpenSettingsPage()
        {

            // Assert "About"-Screen is shown
            AppResult[] results = app.Query(c => c.Marked("Page_About"));
            Assert.IsTrue(results.Any());

            // Tap on menu drawer
            app.Tap(c => c.Marked("Open navigation drawer"));

            // Wait for drawer
            AppResult[] results2 = app.WaitForElement(c => c.Marked("FlyoutItem_Settings"));
            Assert.IsTrue(results2.Any());

            // Open devices page
            app.Tap(c => c.Marked("FlyoutItem_Settings"));

            // Assert that devices page (or at least one element from the page) is visible
            AppResult[] results3 = app.WaitForElement(c => c.Marked("Page_Settings"));
            Assert.IsTrue(results3.Any());

        }




    }
}
