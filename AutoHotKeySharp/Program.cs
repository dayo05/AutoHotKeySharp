using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AutoHotKeyCSharp
{
    public interface IAutoHotKeySharpClass { }
    public static class AutoHotKeySharp
    {
        private readonly static Dictionary<PressedKeys, Action> method = new();
        private static bool initd = false;
        private static readonly KeyboardHook hook = new();
        internal static readonly PressedKeys current = new();
        private static void Init()
        {
            hook.Hook();
            hook.KeyDown += KeyDown;
            hook.KeyUp += KeyUp;
        }
        public static void KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyChecker.IsControl(e))
                current.AddKey(SpecialKeyList.Control);
            if (KeyChecker.IsAlt(e))
                current.AddKey(SpecialKeyList.Alt);
            if (KeyChecker.IsWin(e))
                current.AddKey(SpecialKeyList.Win);
            if (KeyChecker.IsF1(e))
                current.AddKey(SpecialKeyList.F1);
            if (KeyChecker.IsF2(e))
                current.AddKey(SpecialKeyList.F2);
            if (KeyChecker.IsF3(e))
                current.AddKey(SpecialKeyList.F3);
            if (KeyChecker.IsF4(e))
                current.AddKey(SpecialKeyList.F4);
            if (KeyChecker.IsF5(e))
                current.AddKey(SpecialKeyList.F5);
            if (KeyChecker.IsF6(e))
                current.AddKey(SpecialKeyList.F6);
            if (KeyChecker.IsF7(e))
                current.AddKey(SpecialKeyList.F7);
            if (KeyChecker.IsF8(e))
                current.AddKey(SpecialKeyList.F8);
            if (KeyChecker.IsF9(e))
                current.AddKey(SpecialKeyList.F9);
            if (KeyChecker.IsF10(e))
                current.AddKey(SpecialKeyList.F10);
            if (KeyChecker.IsF11(e))
                current.AddKey(SpecialKeyList.F11);
            if (KeyChecker.IsF12(e))
                current.AddKey(SpecialKeyList.F12);
            if (KeyChecker.IsRArrow(e))
                current.AddKey(SpecialKeyList.RArrow);
            if (KeyChecker.IsLArrow(e))
                current.AddKey(SpecialKeyList.LArrow);
            if (KeyChecker.IsUArrow(e))
                current.AddKey(SpecialKeyList.UArrow);
            if (KeyChecker.IsDArrow(e))
                current.AddKey(SpecialKeyList.DArrow);
            if (KeyChecker.IsHome(e))
                current.AddKey(SpecialKeyList.Home);
            if (KeyChecker.IsEnd(e))
                current.AddKey(SpecialKeyList.End);
            if (KeyChecker.IsPageUp(e))
                current.AddKey(SpecialKeyList.PageUp);
            if (KeyChecker.IsPageDown(e))
                current.AddKey(SpecialKeyList.PageDown);
            if (KeyChecker.IsEnter(e))
                current.AddKey(SpecialKeyList.Enter);
            if (KeyChecker.IsBackspace(e))
                current.AddKey(SpecialKeyList.BackSpace);
            if (KeyChecker.IsDelete(e))
                current.AddKey(SpecialKeyList.Delete);
            if (KeyChecker.IsInsert(e))
                current.AddKey(SpecialKeyList.Insert);
            if (KeyChecker.IsPrintScreen(e))
                current.AddKey(SpecialKeyList.PrintScreen);
            if (KeyChecker.IsEsc(e))
                current.AddKey(SpecialKeyList.Esc);
            if (KeyChecker.IsTab(e))
                current.AddKey(SpecialKeyList.Tab);

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

            if (KeyChecker.Is1(e))
                current.AddKey(NumberKeyList.One);
            if (KeyChecker.Is2(e))
                current.AddKey(NumberKeyList.Two);
            if (KeyChecker.Is3(e))
                current.AddKey(NumberKeyList.Three);
            if (KeyChecker.Is4(e))
                current.AddKey(NumberKeyList.Four);
            if (KeyChecker.Is5(e))
                current.AddKey(NumberKeyList.Five);
            if (KeyChecker.Is6(e))
                current.AddKey(NumberKeyList.Six);
            if (KeyChecker.Is7(e))
                current.AddKey(NumberKeyList.Seven);
            if (KeyChecker.Is8(e))
                current.AddKey(NumberKeyList.Eight);
            if (KeyChecker.Is9(e))
                current.AddKey(NumberKeyList.Nine);
            if (KeyChecker.Is0(e))
                current.AddKey(NumberKeyList.Zero);
            if (KeyChecker.IsNumpad1(e))
                current.AddKey(NumberKeyList.PadOne);
            if (KeyChecker.IsNumpad2(e))
                current.AddKey(NumberKeyList.PadTwo);
            if (KeyChecker.IsNumpad3(e))
                current.AddKey(NumberKeyList.PadThree);
            if (KeyChecker.IsNumpad4(e))
                current.AddKey(NumberKeyList.PadFour);
            if (KeyChecker.IsNumpad5(e))
                current.AddKey(NumberKeyList.PadFive);
            if (KeyChecker.IsNumpad6(e))
                current.AddKey(NumberKeyList.PadSix);
            if (KeyChecker.IsNumpad7(e))
                current.AddKey(NumberKeyList.PadSeven);
            if (KeyChecker.IsNumpad8(e))
                current.AddKey(NumberKeyList.PadEight);
            if (KeyChecker.IsNumpad9(e))
                current.AddKey(NumberKeyList.PadNine);
            if (KeyChecker.IsNumpad0(e))
                current.AddKey(NumberKeyList.PadZero);
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
            if (KeyChecker.IsF1(e))
                current.RemoveKey(SpecialKeyList.F1);
            if (KeyChecker.IsF2(e))
                current.RemoveKey(SpecialKeyList.F2);
            if (KeyChecker.IsF3(e))
                current.RemoveKey(SpecialKeyList.F3);
            if (KeyChecker.IsF4(e))
                current.RemoveKey(SpecialKeyList.F4);
            if (KeyChecker.IsF5(e))
                current.RemoveKey(SpecialKeyList.F5);
            if (KeyChecker.IsF6(e))
                current.RemoveKey(SpecialKeyList.F6);
            if (KeyChecker.IsF7(e))
                current.RemoveKey(SpecialKeyList.F7);
            if (KeyChecker.IsF8(e))
                current.RemoveKey(SpecialKeyList.F8);
            if (KeyChecker.IsF9(e))
                current.RemoveKey(SpecialKeyList.F9);
            if (KeyChecker.IsF10(e))
                current.RemoveKey(SpecialKeyList.F10);
            if (KeyChecker.IsF11(e))
                current.RemoveKey(SpecialKeyList.F11);
            if (KeyChecker.IsF12(e))
                current.RemoveKey(SpecialKeyList.F12);
            if (KeyChecker.IsRArrow(e))
                current.RemoveKey(SpecialKeyList.RArrow);
            if (KeyChecker.IsLArrow(e))
                current.RemoveKey(SpecialKeyList.LArrow);
            if (KeyChecker.IsUArrow(e))
                current.RemoveKey(SpecialKeyList.UArrow);
            if (KeyChecker.IsDArrow(e))
                current.RemoveKey(SpecialKeyList.DArrow);
            if (KeyChecker.IsHome(e))
                current.RemoveKey(SpecialKeyList.Home);
            if (KeyChecker.IsEnd(e))
                current.RemoveKey(SpecialKeyList.End);
            if (KeyChecker.IsPageUp(e))
                current.RemoveKey(SpecialKeyList.PageUp);
            if (KeyChecker.IsPageDown(e))
                current.RemoveKey(SpecialKeyList.PageDown);
            if (KeyChecker.IsEnter(e))
                current.RemoveKey(SpecialKeyList.Enter);
            if (KeyChecker.IsBackspace(e))
                current.RemoveKey(SpecialKeyList.BackSpace);
            if (KeyChecker.IsDelete(e))
                current.RemoveKey(SpecialKeyList.Delete);
            if (KeyChecker.IsInsert(e))
                current.RemoveKey(SpecialKeyList.Insert);
            if (KeyChecker.IsPrintScreen(e))
                current.RemoveKey(SpecialKeyList.PrintScreen);
            if (KeyChecker.IsEsc(e))
                current.RemoveKey(SpecialKeyList.Esc);
            if (KeyChecker.IsTab(e))
                current.RemoveKey(SpecialKeyList.Tab);

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

            if (KeyChecker.Is1(e))
                current.RemoveKey(NumberKeyList.One);
            if (KeyChecker.Is2(e))
                current.RemoveKey(NumberKeyList.Two);
            if (KeyChecker.Is3(e))
                current.RemoveKey(NumberKeyList.Three);
            if (KeyChecker.Is4(e))
                current.RemoveKey(NumberKeyList.Four);
            if (KeyChecker.Is5(e))
                current.RemoveKey(NumberKeyList.Five);
            if (KeyChecker.Is6(e))
                current.RemoveKey(NumberKeyList.Six);
            if (KeyChecker.Is7(e))
                current.RemoveKey(NumberKeyList.Seven);
            if (KeyChecker.Is8(e))
                current.RemoveKey(NumberKeyList.Eight);
            if (KeyChecker.Is9(e))
                current.RemoveKey(NumberKeyList.Nine);
            if (KeyChecker.Is0(e))
                current.RemoveKey(NumberKeyList.Zero);
            if (KeyChecker.IsNumpad1(e))
                current.RemoveKey(NumberKeyList.PadOne);
            if (KeyChecker.IsNumpad2(e))
                current.RemoveKey(NumberKeyList.PadTwo);
            if (KeyChecker.IsNumpad3(e))
                current.RemoveKey(NumberKeyList.PadThree);
            if (KeyChecker.IsNumpad4(e))
                current.RemoveKey(NumberKeyList.PadFour);
            if (KeyChecker.IsNumpad5(e))
                current.RemoveKey(NumberKeyList.PadFive);
            if (KeyChecker.IsNumpad6(e))
                current.RemoveKey(NumberKeyList.PadSix);
            if (KeyChecker.IsNumpad7(e))
                current.RemoveKey(NumberKeyList.PadSeven);
            if (KeyChecker.IsNumpad8(e))
                current.RemoveKey(NumberKeyList.PadEight);
            if (KeyChecker.IsNumpad9(e))
                current.RemoveKey(NumberKeyList.PadNine);
            if (KeyChecker.IsNumpad0(e))
                current.RemoveKey(NumberKeyList.PadZero);
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

