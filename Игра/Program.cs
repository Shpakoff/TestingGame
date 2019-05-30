using System;
using System.Windows.Forms;

namespace Игра
{
    static class Rec
    {
        public static double rec { get; set; }
    }
    static class Rec2
    {
        public static double rec2 { get; set; }
    }
    static class Kol
    {
        public static int n { get; set; }
    }
    static class Data
    {
        public static string Name { get; set; }
    }
    static class Data2
    {
        public static string Login { get; set; }
    }
    static class Data3
    {
        public static string Password { get; set; }
    }
    static class Data4
    {
        public static int Kod { get; set; }
    }
    static class music
    {
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
