namespace MEh_Typewriter
{
    public static class Msg
    {
        // Messages for Settings.
        public const string SettingsAreLoadedF = "Settings are loaded from '{0}'.";
        public const string SettingsReadingError = "Settings can not be read.";

        // Messages for Font Installation Process.
        public const string FontIsAlreadyInstalled = "Font is already installed.";
        public const string FontInstallerIsMissing = "Font installer is missing. Check the settings.";
        public const string FontFileIsMissing = "Font file is missing.";
        public const string FontInstallationErrorF = "Font installation has failed. Exit code: {0}.";
        public const string FontInstallationSuccess = "Font installation has succedded.";
        public const string ApplicationRestartIsRequired = "Font has been installed. Restarting the application. Please wait ...";
    }
}
