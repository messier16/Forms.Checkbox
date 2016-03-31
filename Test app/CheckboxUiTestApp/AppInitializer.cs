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
                    .Debug()
                    .ApkFile(@"../../../Droid/bin/Release/com.thatcsharpguy.checkboxtestapp.apk")
                    .StartApp();
            }

            var simulatorId = "322D5999-8FAA-4DBE-8E50-675D99D1B1DC";

            return ConfigureApp
				.iOS.DeviceIdentifier(simulatorId)
				.AppBundle("../../../iOS/bin/iPhoneSimulator/Debug/CheckboxTestAppiOS.app")

                .StartApp();
        }
    }
}

