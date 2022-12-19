namespace MEh_Typewriter
{
    public enum FontCheckResult : int
    {
        FontIsAlreadyInstalled = 1,
        FontInstallerIsMissing = 2,
        FontFileIsMissing = 3,
        FontInstallationError = 4,
        FontInstallationSuccess = 5,
        ApplicationRestartIsRequired = 6
    }
}
