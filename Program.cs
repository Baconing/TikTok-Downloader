namespace TikTok_Downloader
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Nothing rly going on here hehe
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}