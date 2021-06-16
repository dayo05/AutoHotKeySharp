using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace AutoHotKeyCSharp
{
    public interface IAutoHotKeySharpClass
    {

    }
    public static class AutoHotKeySharp
    {
        private readonly static Dictionary<PressedKeys, Action> method = new();
        private static bool initd = false;
        private static readonly KeyboardHook hook = new();
        private static PressedKeys current = new();
        private static void Init()
        {
            hook.Hook();
            hook.KeyDown += KeyDown;
            hook.KeyUp += KeyUp;
        }
        public static void KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyDown");
            if (KeyChecker.IsControl(e))
                current.AddKey(SpecialKeyList.Control);
            if (KeyChecker.IsAlt(e))
                current.AddKey(SpecialKeyList.Alt);
            if (KeyChecker.IsWin(e))
                current.AddKey(SpecialKeyList.Win);
            if (KeyChecker.IsA(e))
                current.AddKey(EngCharKeyList.A);
            if (KeyChecker.IsB(e))
                current.AddKey(EngCharKeyList.B);
            if (KeyChecker.IsC(e))
                current.AddKey(EngCharKeyList.C);
            if (KeyChecker.IsD(e))
                current.AddKey(EngCharKeyList.D);
            if (KeyChecker.IsE(e))
                current.AddKey(EngCharKeyList.E);
            if (KeyChecker.IsF(e))
                current.AddKey(EngCharKeyList.F);
            if (KeyChecker.IsG(e))
                current.AddKey(EngCharKeyList.G);
            if (KeyChecker.IsH(e))
                current.AddKey(EngCharKeyList.H);
            if (KeyChecker.IsI(e))
                current.AddKey(EngCharKeyList.I);
            if (KeyChecker.IsJ(e))
                current.AddKey(EngCharKeyList.J);
            if (KeyChecker.IsK(e))
                current.AddKey(EngCharKeyList.K);
            if (KeyChecker.IsL(e))
                current.AddKey(EngCharKeyList.L);
            if (KeyChecker.IsM(e))
                current.AddKey(EngCharKeyList.M);
            if (KeyChecker.IsN(e))
                current.AddKey(EngCharKeyList.N);
            if (KeyChecker.IsO(e))
                current.AddKey(EngCharKeyList.O);
            if (KeyChecker.IsP(e))
                current.AddKey(EngCharKeyList.P);
            if (KeyChecker.IsQ(e))
                current.AddKey(EngCharKeyList.Q);
            if (KeyChecker.IsR(e))
                current.AddKey(EngCharKeyList.R);
            if (KeyChecker.IsS(e))
                current.AddKey(EngCharKeyList.S);
            if (KeyChecker.IsT(e))
                current.AddKey(EngCharKeyList.T);
            if (KeyChecker.IsU(e))
                current.AddKey(EngCharKeyList.U);
            if (KeyChecker.IsV(e))
                current.AddKey(EngCharKeyList.V);
            if (KeyChecker.IsW(e))
                current.AddKey(EngCharKeyList.W);
            if (KeyChecker.IsX(e))
                current.AddKey(EngCharKeyList.X);
            if (KeyChecker.IsY(e))
                current.AddKey(EngCharKeyList.Y);
            if (KeyChecker.IsZ(e))
                current.AddKey(EngCharKeyList.Z);
            new Thread(ExecuteMethod).Start();
        }
        private static void ExecuteMethod()
        {
            if (method.ContainsKey(current))
                method[current]();
        }
        public static void KeyUp(object sender, KeyEventArgs e)
        {
            if (KeyChecker.IsControl(e))
                current.RemoveKey(SpecialKeyList.Control);
            if (KeyChecker.IsAlt(e))
                current.RemoveKey(SpecialKeyList.Alt);
            if (KeyChecker.IsWin(e))
                current.RemoveKey(SpecialKeyList.Win);

            if (KeyChecker.IsA(e))
                current.RemoveKey(EngCharKeyList.A);
            if (KeyChecker.IsB(e))
                current.RemoveKey(EngCharKeyList.B);
            if (KeyChecker.IsC(e))
                current.RemoveKey(EngCharKeyList.C);
            if (KeyChecker.IsD(e))
                current.RemoveKey(EngCharKeyList.D);
            if (KeyChecker.IsE(e))
                current.RemoveKey(EngCharKeyList.E);
            if (KeyChecker.IsF(e))
                current.RemoveKey(EngCharKeyList.F);
            if (KeyChecker.IsG(e))
                current.RemoveKey(EngCharKeyList.G);
            if (KeyChecker.IsH(e))
                current.RemoveKey(EngCharKeyList.H);
            if (KeyChecker.IsI(e))
                current.RemoveKey(EngCharKeyList.I);
            if (KeyChecker.IsJ(e))
                current.RemoveKey(EngCharKeyList.J);
            if (KeyChecker.IsK(e))
                current.RemoveKey(EngCharKeyList.K);
            if (KeyChecker.IsL(e))
                current.RemoveKey(EngCharKeyList.L);
            if (KeyChecker.IsM(e))
                current.RemoveKey(EngCharKeyList.M);
            if (KeyChecker.IsN(e))
                current.RemoveKey(EngCharKeyList.N);
            if (KeyChecker.IsO(e))
                current.RemoveKey(EngCharKeyList.O);
            if (KeyChecker.IsP(e))
                current.RemoveKey(EngCharKeyList.P);
            if (KeyChecker.IsQ(e))
                current.RemoveKey(EngCharKeyList.Q);
            if (KeyChecker.IsR(e))
                current.RemoveKey(EngCharKeyList.R);
            if (KeyChecker.IsS(e))
                current.RemoveKey(EngCharKeyList.S);
            if (KeyChecker.IsT(e))
                current.RemoveKey(EngCharKeyList.T);
            if (KeyChecker.IsU(e))
                current.RemoveKey(EngCharKeyList.U);
            if (KeyChecker.IsV(e))
                current.RemoveKey(EngCharKeyList.V);
            if (KeyChecker.IsW(e))
                current.RemoveKey(EngCharKeyList.W);
            if (KeyChecker.IsX(e))
                current.RemoveKey(EngCharKeyList.X);
            if (KeyChecker.IsY(e))
                current.RemoveKey(EngCharKeyList.Y);
            if (KeyChecker.IsZ(e))
                current.RemoveKey(EngCharKeyList.Z);
        }
        public static void Rigister(IAutoHotKeySharpClass custom)
        {
            if (!initd)
            {
                Init();
                initd = true;
            }
            foreach (var m in custom.GetType().GetMethods())
            {
                foreach (var a in m.GetCustomAttributes(false))
                {
                    if (a is KeyAttribute)
                    {
                        var attr = a as KeyAttribute;
                        if (m.IsStatic)
                        {
                            if (method.ContainsKey(attr.Key))
                                method[attr.Key] += (Action)Delegate.CreateDelegate(typeof(Action), m);
                            else method.Add(attr.Key, (Action)Delegate.CreateDelegate(typeof(Action), m));
                        }
                        else
                        {
                            if (method.ContainsKey(attr.Key))
                                method[attr.Key] += (Action)Delegate.CreateDelegate(typeof(Action), custom, m);
                            else method.Add(attr.Key, (Action)Delegate.CreateDelegate(typeof(Action), custom, m));
                        }
                    }
                }
            }
        }
        public static void Test_ExecuteViaKeyCode(PressedKeys a)
        {
            if (method.ContainsKey(a))
                method[a]();
            else throw new IndexOutOfRangeException("No command exist");
        }
    }
}

