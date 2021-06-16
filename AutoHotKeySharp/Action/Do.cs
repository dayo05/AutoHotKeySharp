using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoHotKeyCSharp.Actions
{
    public static class Execute
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        public static void ClickKey(uint vk)
        {
            keybd_event(vk, 0, 0x00, 0);
            keybd_event(vk, 0, 0x02, 0);
        }
        public static void KeyDown(uint vk)
            => keybd_event(vk, 0, 0x00, 0);
        public static void KeyUp(uint vk)
            => keybd_event(vk, 0, 0x02, 0);
        public static void KeyDown(PressedKeys k)
    {
            //TODO
        }
        public static void ShowMessage(string message, string title = " ", MessageBoxIcon icon = MessageBoxIcon.None)
            => MessageBox.Show(message, title, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }
}
