using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;
using WMPLib;

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
    static class Kol2
    {
        public static int m { get; set; }
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
    static class Razdels
    {
        public static string razdel { get; set; }
    }
    static class Glavi
    {
        public static string[] glava { get; set; }
    }
    static class music
    {
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer(); 
    }
    static class sound
    {
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
    }
    static class files
    {
        public static OpenFileDialog openFile1 = new OpenFileDialog();
        public static OpenFileDialog openFile2 = new OpenFileDialog();
        public static OpenFileDialog openFile3 = new OpenFileDialog();
        public static OpenFileDialog openFile4 = new OpenFileDialog();
        public static OpenFileDialog openFile5 = new OpenFileDialog();
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
