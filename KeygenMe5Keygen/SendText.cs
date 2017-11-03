using System;
using System.Runtime.InteropServices;

namespace KeygenMe5Keygen
{
    public class SendText
    {
        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, string lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        public const uint WM_SETTEXT = 0x000C;
        public const uint WM_GETTEXTLENGTH = 0x000E;
        private const int BN_CLICKED = 245;

        public void SetText(IntPtr iptrHWndDialog, int iControlID, string strTextToSet)
        {
            IntPtr iptrHWndControl = GetDlgItem(iptrHWndDialog, iControlID);
            HandleRef hrefHWndTarget = new HandleRef(null, iptrHWndControl);
            SendMessage(hrefHWndTarget, WM_SETTEXT, IntPtr.Zero, strTextToSet);
        }

        public void SendClick(int HwndChild)
        {
            SendMessage((IntPtr)HwndChild, BN_CLICKED, IntPtr.Zero, IntPtr.Zero);
        }

        public IntPtr FindWindowByIndex(IntPtr hWndParent, int index)
        {
            if (index == 0)
                return hWndParent;
            else
            {
                int ct = 0;
                IntPtr result = IntPtr.Zero;
                do
                {
                    result = FindWindowEx(hWndParent, result, null, null);
                    if (result != IntPtr.Zero)
                        ++ct;
                }
                while (ct < index && result != IntPtr.Zero);
                return result;
            }
        }
    }
}