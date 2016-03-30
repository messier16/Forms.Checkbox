using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CheckboxUiTestApp
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .StartApp();
            }

			var simulatorId = "A48759EA-A2F7-44F9-8EE6-5AB3AA374721";

            return ConfigureApp
				.iOS.DeviceIdentifier(simulatorId)
				.AppBundle("../../../iOS/bin/iPhoneSimulator/Debug/CheckboxTestAppiOS.app")

                .StartApp();
        }
    }
}

