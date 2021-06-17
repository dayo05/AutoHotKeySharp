using System.Windows.Forms;

namespace AutoHotKeyCSharp
{
    static class KeyChecker
    {
        public static bool IsControl(KeyEventArgs e)
            => e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control;
        public static bool IsAlt(KeyEventArgs e)
            => e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu || e.KeyCode == Keys.Menu;
        public static bool IsWin(KeyEventArgs e)
            => e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin;
        public static bool IsShift(KeyEventArgs e)
            => e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey;
        public static bool IsRArrow(KeyEventArgs e)
            => e.KeyCode == Keys.Right;
        public static bool IsLArrow(KeyEventArgs e)
            => e.KeyCode == Keys.Left;
        public static bool IsUArrow(KeyEventArgs e)
            => e.KeyCode == Keys.Up;
        public static bool IsDArrow(KeyEventArgs e)
            => e.KeyCode == Keys.Down;
        public static bool IsHome(KeyEventArgs e)
            => e.KeyCode == Keys.Home;
        public static bool IsEnd(KeyEventArgs e)
            => e.KeyCode == Keys.End;
        public static bool IsPageUp(KeyEventArgs e)
            => e.KeyCode == Keys.PageUp;
        public static bool IsPageDown(KeyEventArgs e)
            => e.KeyCode == Keys.PageDown;
        public static bool IsEnter(KeyEventArgs e)
            => e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return;
        public static bool IsBackspace(KeyEventArgs e)
            => e.KeyCode == Keys.Back;
        public static bool IsDelete(KeyEventArgs e)
            => e.KeyCode == Keys.Delete;
        public static bool IsInsert(KeyEventArgs e)
            => e.KeyCode == Keys.Insert;
        public static bool IsPrintScreen(KeyEventArgs e)
            => e.KeyCode == Keys.PrintScreen;
        public static bool IsF1(KeyEventArgs e)
            => e.KeyCode == Keys.F1;
        public static bool IsF2(KeyEventArgs e)
            => e.KeyCode == Keys.F2;
        public static bool IsF3(KeyEventArgs e)
            => e.KeyCode == Keys.F3;
        public static bool IsF4(KeyEventArgs e)
            => e.KeyCode == Keys.F4;
        public static bool IsF5(KeyEventArgs e)
            => e.KeyCode == Keys.F5;
        public static bool IsF6(KeyEventArgs e)
            => e.KeyCode == Keys.F6;
        public static bool IsF7(KeyEventArgs e)
            => e.KeyCode == Keys.F7;
        public static bool IsF8(KeyEventArgs e)
            => e.KeyCode == Keys.F8;
        public static bool IsF9(KeyEventArgs e)
            => e.KeyCode == Keys.F9;
        public static bool IsF10(KeyEventArgs e)
            => e.KeyCode == Keys.F10;
        public static bool IsF11(KeyEventArgs e)
            => e.KeyCode == Keys.F11;
        public static bool IsF12(KeyEventArgs e)
            => e.KeyCode == Keys.F12;
        public static bool IsTab(KeyEventArgs e)
            => e.KeyCode == Keys.Tab;
        public static bool IsEsc(KeyEventArgs e)
            => e.KeyCode == Keys.Escape;

        public static bool IsA(KeyEventArgs e)
            => e.KeyCode == Keys.A;
        public static bool IsB(KeyEventArgs e)
            => e.KeyCode == Keys.B;
        public static bool IsC(KeyEventArgs e)
            => e.KeyCode == Keys.C;
        public static bool IsD(KeyEventArgs e)
            => e.KeyCode == Keys.D;
        public static bool IsE(KeyEventArgs e)
            => e.KeyCode == Keys.E;
        public static bool IsF(KeyEventArgs e)
            => e.KeyCode == Keys.F;
        public static bool IsG(KeyEventArgs e)
            => e.KeyCode == Keys.G;
        public static bool IsH(KeyEventArgs e)
            => e.KeyCode == Keys.H;
        public static bool IsI(KeyEventArgs e)
            => e.KeyCode == Keys.I;
        public static bool IsJ(KeyEventArgs e)
            => e.KeyCode == Keys.J;
        public static bool IsK(KeyEventArgs e)
            => e.KeyCode == Keys.K;
        public static bool IsL(KeyEventArgs e)
            => e.KeyCode == Keys.L;
        public static bool IsM(KeyEventArgs e)
            => e.KeyCode == Keys.M;
        public static bool IsN(KeyEventArgs e)
            => e.KeyCode == Keys.N;
        public static bool IsO(KeyEventArgs e)
            => e.KeyCode == Keys.O;
        public static bool IsP(KeyEventArgs e)
            => e.KeyCode == Keys.P;
        public static bool IsQ(KeyEventArgs e)
            => e.KeyCode == Keys.Q;
        public static bool IsR(KeyEventArgs e)
            => e.KeyCode == Keys.R;
        public static bool IsS(KeyEventArgs e)
            => e.KeyCode == Keys.S;
        public static bool IsT(KeyEventArgs e)
            => e.KeyCode == Keys.T;
        public static bool IsU(KeyEventArgs e)
            => e.KeyCode == Keys.U;
        public static bool IsV(KeyEventArgs e)
            => e.KeyCode == Keys.V;
        public static bool IsW(KeyEventArgs e)
            => e.KeyCode == Keys.W;
        public static bool IsX(KeyEventArgs e)
            => e.KeyCode == Keys.X;
        public static bool IsY(KeyEventArgs e)
            => e.KeyCode == Keys.Y;
        public static bool IsZ(KeyEventArgs e)
            => e.KeyCode == Keys.Z;

        public static bool Is1(KeyEventArgs e)
            => e.KeyCode == Keys.D1;
        public static bool Is2(KeyEventArgs e)
            => e.KeyCode == Keys.D2;
        public static bool Is3(KeyEventArgs e)
            => e.KeyCode == Keys.D3;
        public static bool Is4(KeyEventArgs e)
            => e.KeyCode == Keys.D4;
        public static bool Is5(KeyEventArgs e)
            => e.KeyCode == Keys.D5;
        public static bool Is6(KeyEventArgs e)
            => e.KeyCode == Keys.D6;
        public static bool Is7(KeyEventArgs e)
            => e.KeyCode == Keys.D7;
        public static bool Is8(KeyEventArgs e)
            => e.KeyCode == Keys.D8;
        public static bool Is9(KeyEventArgs e)
            => e.KeyCode == Keys.D9;
        public static bool Is0(KeyEventArgs e)
            => e.KeyCode == Keys.D0;
        public static bool IsNumpad1(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad1;
        public static bool IsNumpad2(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad2;
        public static bool IsNumpad3(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad3;
        public static bool IsNumpad4(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad4;
        public static bool IsNumpad5(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad5;
        public static bool IsNumpad6(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad6;
        public static bool IsNumpad7(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad7;
        public static bool IsNumpad8(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad8;
        public static bool IsNumpad9(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad9;
        public static bool IsNumpad0(KeyEventArgs e)
            => e.KeyCode == Keys.NumPad0;

        public static bool IsSemiColon(KeyEventArgs e)
            => e.KeyCode == Keys.OemSemicolon;
    }
}
