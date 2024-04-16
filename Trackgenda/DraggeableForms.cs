using System;
using System.Runtime.InteropServices;

namespace Trackgenda
{
    public static class DraggeableForms
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void Drag(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, 0xA1, 0x2, 0);
        }
    }
}
