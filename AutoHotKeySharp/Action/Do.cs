using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoHotKeyCSharp.Actions
{
    public static class Execute
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        public static void ClickKey(byte vk)
        {
            KeyDown(vk);
            KeyUp(vk);
        }
        public static void KeyDown(byte vk)
        {
            keybd_event(vk, 0, 0x01, 0);
        }
        public static void KeyUp(byte vk)
        {
            keybd_event(vk, 0, 0x03, 0);
        }
        public static void KeyDown(PressedKeys k)
        {
            //TODO
        }
        public static void ShowMessage(string message, string title = " ", MessageBoxIcon icon = MessageBoxIcon.None)
            => MessageBox.Show(message, title, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }
}
