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
    }
}
