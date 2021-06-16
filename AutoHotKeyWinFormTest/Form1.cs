using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using AutoHotKeyCSharp;

namespace AutoHotKeyWinFormTest
{
    public class TestAttr : IAutoHotKeySharpClass
    {
        [Key(special: (long)SpecialKeyList.Control)]
        public static void Hello()
        {
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
            MessageBox.Show("win");
        }
        [Key(special: (long)SpecialKeyList.Win, ch: (long)EngCharKeyList.D)]
        public static void GotoBackGround()
        {
            Thread.Sleep(500);
            //MessageBox.Show("BackGround");
            SendKeys.Send("^%{ESC}");
            MessageBox.Show("asdf");
        }
    }
    public partial class Form1 : Form
    {
        private readonly StreamWriter sw = new("log.log");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw.AutoFlush = true;
            Console.SetOut(sw);
            AutoHotKeySharp.Rigister(new TestAttr());
            //AutoHotKeySharp.Test_ExecuteViaKeyCode(new KeyCode(10));
        }
    }
}
