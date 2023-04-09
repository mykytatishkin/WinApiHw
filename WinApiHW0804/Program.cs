using System.Runtime.InteropServices;
using WinApiHW0804;


Console.WriteLine("Hello, World!");

const int MB_RETRYCANCEL = 0x00000005;
const int MB_ICONINFORMATION = 0x00000040;
const int WM_SETTEXT = 0x000C;
const int WM_CLOSE = 0x0010;

/* Task 1*/

// var res = WinApiDll.MessageBox(IntPtr.Zero, "Name: Mykyta", "Hello World App", MB_ICONINFORMATION | MB_ICONINFORMATION);
// Console.WriteLine(res);
// var res1 = WinApiDll.MessageBox(IntPtr.Zero, "Age: 18", "Hello World App", MB_ICONINFORMATION | MB_ICONINFORMATION);
// Console.WriteLine(res1);

/* Task 2*/
// var hWnd = WinApiDll.FindWindow("WindowsForms10.Window.8.app.0.378734a_r3_ad1", null);

/* Task 3*/
// WinApiDll.Beep(2000, 1000);
// WinApiDll.MessageBeep(0x0);