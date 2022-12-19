using FontInstaller;

namespace MEh_Typewriter
{
    public struct FontCheckResponse
    {
        public FontCheckResult CheckResult { get; }
        public ExitCode FontInstallerExitCode { get; }


        public FontCheckResponse(FontCheckResult checkResult, ExitCode fontInstallerExitCode)
        {
            CheckResult = checkResult;
            FontInstallerExitCode = fontInstallerExitCode;
        }


        public FontCheckResponse(FontCheckResult checkResult)
        {
            CheckResult = checkResult;
            FontInstallerExitCode = 0;
        }
    }
}
