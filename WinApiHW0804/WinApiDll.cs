using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinApiHW0804
{
    public class WinApiDll
    {
        // Task 1
        [DllImport("User32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string msg, string caption, int type);

        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int dwFreq, int dwDuration);
        
        [DllImport("User32.dll")]
        public static extern int MessageBeep(uint n);
    }
}
