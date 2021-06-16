using System;
using System.Windows.Forms;
using System.IO;

using AutoHotKeyCSharp;

namespace AutoHotKeyWinFormTest
{   public partial class Form1 : Form
    {
        private readonly StreamWriter sw = new("log.log", true);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sw.AutoFlush = true;
            Console.SetOut(sw);
            AutoHotKeySharp.Rigister(new TestAttr());
            Opacity = 0;
            ShowInTaskbar = false;
            Visible = false;
        }
    }
}
