using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoHotKeyCSharp
{
    class KeyboardHook
    {
        /***************************
         * 
         * Source from https://cwkcw.tistory.com/261
         *
        ***************************/
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref KeyboardHookStruct IParam);
        [DllImport("user32.dll")]
        static extern short GetKeyState(int nCode);
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string IpFileName);   // 라이브러리 등록

        private delegate int keyboardHookProc(int code, int wParam, ref KeyboardHookStruct IParam);     // callback Delegate
        public struct KeyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        // Pre-defined const number
        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;

        private readonly keyboardHookProc khp;
        IntPtr hhook = IntPtr.Zero;

        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
        public KeyboardHook()
        {
            khp = new keyboardHookProc(Hookproc);
            KeyDown = Blank;
            KeyUp = Blank;
        }

        private void Blank(object _, KeyEventArgs __) { }
        public void Hook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, khp, hInstance, 0);
        }

        public void Unhook()
            => UnhookWindowsHookEx(hhook);
        public int Hookproc(int code, int wParam, ref KeyboardHookStruct IParam)
        {
            if (code >= 0)
            {
                Keys key = (Keys)IParam.vkCode;
                
                KeyEventArgs kea = new(key);
                if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                    KeyDown(this, kea);
                else if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
                    KeyUp(this, kea);
                if (kea.Handled)
                    return 1;
            }
            return CallNextHookEx(hhook, code, wParam, ref IParam);
        }
    }
}