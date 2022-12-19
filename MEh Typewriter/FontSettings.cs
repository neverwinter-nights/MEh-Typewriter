namespace MEh_Typewriter
{
    public class FontSettings
    {
        public string Name { get; }
        public string Folder { get; }
        public string TtfFile { get; }
        public string InstallerExe { get; }
        public float Size { get; }


        public FontSettings(string fontName, string fontFolder, string ttfFile, string installerExe, float size)
        {
            Name = fontName;
            Folder = fontFolder;
            TtfFile = ttfFile;
            InstallerExe = installerExe;
            Size = size;
        }
    }
}
