using System.Diagnostics;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using FontInstaller;
using System.Windows.Forms;

namespace MEh_Typewriter
{
    internal class Font
    {
        public static FontCheckResponse Check(FontSettings fontSettings)
        {
            bool fontIsInstalled = IsInstalled(fontSettings.Name);
            if (fontIsInstalled)
            {
                return new FontCheckResponse(FontCheckResult.FontIsAlreadyInstalled);
            }

            string fontFilePath = Path.Combine(fontSettings.Folder, fontSettings.TtfFile);

            FontCheckResponse installationResult;
            try
            {
                installationResult = Install(fontSettings.InstallerExe, fontFilePath);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return new FontCheckResponse(FontCheckResult.FontInstallationError);
            }


            // For some reason the font is not seen as installed after the installation,
            // though the font is really installed. We need to restart the application.
            if (installationResult.CheckResult == FontCheckResult.FontInstallationSuccess)
            {
                return new FontCheckResponse(FontCheckResult.ApplicationRestartIsRequired);
            }

            return installationResult;
        }


        public static bool IsInstalled(string fontName)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;
            string requiredFontNameLC = fontName.ToLower();

            foreach (FontFamily fontFamily in fontFamilies)
            {
                if (fontFamily.Name.ToLower() == requiredFontNameLC) return true;
            }

            return false;
        }


        public static FontCheckResponse Install(string fontInstallerExePath, string fontPath)
        {
            // Ensure that both Installer and Font File exist.
            if (!File.Exists(fontInstallerExePath))
            {
                return new FontCheckResponse(FontCheckResult.FontInstallerIsMissing);
            }
            if (!File.Exists(fontPath))
            {
                return new FontCheckResponse(FontCheckResult.FontFileIsMissing);
            }

            // Font Installer needs to be started with Administrator Access.
            Process proc = Helper.ExecuteFileAsAdmin(fontInstallerExePath, fontPath);
            proc.WaitForExit();

            if (proc.ExitCode != 0)
            {
                return new FontCheckResponse(FontCheckResult.FontInstallationError, (ExitCode)proc.ExitCode);
            }

            return new FontCheckResponse(FontCheckResult.FontInstallationSuccess);
        }
    }
}
