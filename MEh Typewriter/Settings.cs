using IniParser.Model;
using IniParser;
using System;
using System.Windows.Forms;

namespace MEh_Typewriter
{
    public class Settings
    {
        public string SourceFile { get; }
        public static string DefaultSourceFile = "settings.ini";
        public bool AreLoaded { get; }
        public int ApplicationRestartDelayMs { get; }
        public int LoadFileSizeWarning { get; }
        public static int DefaultApplicationRestartDelayMs = 5000;
        public FontSettings Font { get; }
        const string FontName = "MEh";
        const int LoadFileSizeWarningDefault = 1_000_000; // 1 MB.


        public Settings(string sourceFile)
        {
            // Fill the Source File and default Settings.
            SourceFile = sourceFile;
            if (SourceFile.Length == 0)
                SourceFile = DefaultSourceFile;

            ApplicationRestartDelayMs = DefaultApplicationRestartDelayMs;
            LoadFileSizeWarning = LoadFileSizeWarningDefault;

            AreLoaded = false;


            // Read and parse the Settings File.
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(SourceFile);

                string fontFolder = data["Font"]["Folder"];
                string fontFile = data["Font"]["File"];
                float fontSize = float.Parse(data["Font"]["Size"]);
                string fontInstallerExe = data["Font"]["InstallerExe"];

                Font = new FontSettings(FontName, fontFolder, fontFile, fontInstallerExe, fontSize);

                AreLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
