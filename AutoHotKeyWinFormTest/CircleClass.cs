using System;
using System.Threading;
using System.Windows.Forms;

using AutoHotKeyCSharp;
using AutoHotKeyCSharp.Actions;

namespace AutoHotKeyWinFormTest
{
    public class TestAttr : IAutoHotKeySharpClass
    {
        [Key(special: (long)SpecialKeyList.Control)]
        public static void Hello()
        {
            Console.WriteLine("Test");
            //MessageBox.Show("Test Complated!!");
        }
        [Key(special: (long)SpecialKeyList.Alt)]
        public static void AltPressedLol()
        {
            //MessageBox.Show("Alt Pressed!!");
        }
        [Key(special: (long)SpecialKeyList.Win)]
        public static void WinPressed()
        {
            //Execute.ShowMessage("Win pressed");
        }
        [Key(special: (long)SpecialKeyList.Win, ch: (long)EngCharKeyList.D)]
        public static void GotoBackGround()
        {
            Console.WriteLine("asdf");
            Thread.Sleep(500);
            Execute.KeyDown((uint)Keys.ControlKey);
            Execute.KeyDown((uint)Keys.LMenu);
            Execute.KeyDown((uint)Keys.Escape);
            Execute.KeyUp((uint)Keys.Escape);
            Execute.KeyUp((uint)Keys.LMenu);
            Execute.KeyUp((uint)Keys.ControlKey);
        }
    }

}
