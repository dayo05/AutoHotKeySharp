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
            //Execute.ShowMessage("Test Complated!!");
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
            Thread.Sleep(100);
            Console.WriteLine("Win + D Pressed");
            Execute.KeyDown((byte)Keys.LControlKey);
            Execute.KeyDown((byte)Keys.LMenu);
            Execute.KeyDown((byte)Keys.Escape);
            Thread.Sleep(10);
            Execute.KeyUp((byte)Keys.Escape);
            Execute.KeyUp((byte)Keys.LMenu);
            Execute.KeyUp((byte)Keys.LControlKey);
        }
        [Key(special: (long)SpecialKeyList.Control | (long)SpecialKeyList.Alt | (long)SpecialKeyList.F12)]
        public static void FinishProcess()
            => Application.Exit();
    }
}
