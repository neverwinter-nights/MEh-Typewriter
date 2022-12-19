using System.IO;

namespace MEh_Typewriter
{
    public static partial class Helper
    {
        public static long GetFileSize(string path)
        {
            FileInfo fi = new FileInfo(path);
            return fi.Length;
        }
    }
}
