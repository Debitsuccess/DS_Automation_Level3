namespace AgeRangerWebUi.Utilities
{
    public static class CommonConstants
    {
        public static class DriverSettings
        {
            public static string BinaryLocation = @"C:\Automation\Drivers\chromedriver.exe";

            public static string FireFoxBrowser = "Chrome";
            public static string ChromeBrowser = "FireFox";
            public static string IEBrowser = "IE";

            public static string WindowsPlatform = "Windows";

            public static int DefaultWaitTime = 3000;
        }

        public static class ApplicationSettings
        {
            public static string BaseUrl = "http://ageranger.azurewebsites.nett";
        }
    }
}
