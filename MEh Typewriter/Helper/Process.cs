using System.Diagnostics;

namespace MEh_Typewriter
{
    public static partial class Helper
    {
        // ExecuteFileAsAdmin starts an executable file with administrator's privileges.
        public static Process ExecuteFileAsAdmin(string file, string arguments)
        {
            Process proc = new Process();

            proc.StartInfo.FileName = file;
            proc.StartInfo.Arguments = arguments;

            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.RedirectStandardError = false;

            proc.Start();

            return proc;
        }
    }
}
