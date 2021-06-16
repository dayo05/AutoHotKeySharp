using System;

namespace AutoHotKeyCSharp
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class KeyAttribute : Attribute
    {
        public PressedKeys Key { get; private set; }
        public KeyAttribute(long number = 0, long ch = 0, long other = 0, long special = 0)
        {
            Key = new PressedKeys(num: (NumberKeyList)number,
                special: (SpecialKeyList)special,
                other: (OtherCharKeyList)other,
                ch: (EngCharKeyList)ch);
        }
    }
    public enum NumberKeyList : long
    {
        None = 0,
        Zero = 0b_0000_0000_0001,
        One = 0b_0000_0000_0010,
        Two = 0b_0000_0000_0100,
        Three = 0b_0000_0000_1000,
        Four = 0b_0000_0001_0000,
        Five = 0b_0000_0010_0000,
        Six = 0b_0000_0100_0000,
        Seven = 0b_0000_1000_0000,
        Eight = 0b_0001_0000_0000,
        Nine = 0b_0010_0000_0000,
        PadZero = 0b_0000_0000_0001_0000_0000_0000,
        PadOne = 0b_0000_0000_0010_0000_0000_0000,
        PadTwo = 0b_0000_0000_0100_0000_0000_0000,
        PadThree = 0b_0000_0000_1000_0000_0000_0000,
        PadFour = 0b_0000_0001_0000_0000_0000_0000,
        PadFive = 0b_0000_0010_0000_0000_0000_0000,
        PadSix = 0b_0000_0100_0000_0000_0000_0000,
        PadSeven = 0b_0000_1000_0000_0000_0000_0000,
        PadEight = 0b_0001_0000_0000_0000_0000_0000,
        PadNine = 0b_0010_0000_0000_0000_0000_0000,

    }
    public enum SpecialKeyList : long
    {
        None = 0,
        Control = 0b_0000_0000_0001,
        Alt = 0b_0000_0000_0010,
        Win = 0b_0000_0000_0100,
        Shift = 0b_0000_0000_1000,
        RArrow = 0b_0000_0001_0000,
        LArrow = 0b_0000_0010_0000,
        UArrow = 0b_0000_0100_0000,
        DArrow = 0b_0000_1000_0000,
        Home = 0b_0001_0000_0000,
        End = 0b_0010_0000_0000,
        PageUp = 0b_0100_0000_0000,
        PageDown = 0b_1000_0000_0000,
        F1 = 0b_0001_0000_0000_0000,
        F2 = 0b_0010_0000_0000_0000,
        F3 = 0b_0100_0000_0000_0000,
        F4 = 0b_1000_0000_0000_0000,
        F5 = 0b_0001_0000_0000_0000_0000,
        F6 = 0b_0010_0000_0000_0000_0000,
        F7 = 0b_0100_0000_0000_0000_0000,
        F8 = 0b_1000_0000_0000_0000_0000,
        F9 = 0b_0001_0000_0000_0000_0000_0000,
        F10 = 0b_0010_0000_0000_0000_0000_0000,
        F11 = 0b_0100_0000_0000_0000_0000_0000,
        F12 = 0b_1000_0000_0000_0000_0000_0000,
        Tab = 0b_0001_0000_0000_0000_0000_0000_0000,
        Del = 0b_0010_0000_0000_0000_0000_0000_0000,
        PrintScreen = 0b_0100_0000_0000_0000_0000_0000_0000,
        Insert = 0b_1000_0000_0000_0000_0000_0000_0000,
        Esc = 0b_0001_0000_0000_0000_0000_0000_0000_0000,
        Return = 0b_0010_0000_0000_0000_0000_0000_0000_0000,
        BackSpace = 0b_0100_0000_0000_0000_0000_0000_0000_0000
    }
    public enum EngCharKeyList : long
    {
        None = 0,
        A = 0b_0000_0000_0000_0000_0000_0000_0001,
        B = 0b_0000_0000_0000_0000_0000_0000_0010,
        C = 0b_0000_0000_0000_0000_0000_0000_0100,
        D = 0b_0000_0000_0000_0000_0000_0000_1000,
        E = 0b_0000_0000_0000_0000_0000_0001_0000,
        F = 0b_0000_0000_0000_0000_0000_0010_0000,
        G = 0b_0000_0000_0000_0000_0000_0100_0000,
        H = 0b_0000_0000_0000_0000_0000_1000_0000,
        I = 0b_0000_0000_0000_0000_0001_0000_0000,
        J = 0b_0000_0000_0000_0000_0010_0000_0000,
        K = 0b_0000_0000_0000_0000_0100_0000_0000,
        L = 0b_0000_0000_0000_0000_1000_0000_0000,
        M = 0b_0000_0000_0000_0001_0000_0000_0000,
        N = 0b_0000_0000_0000_0010_0000_0000_0000,
        O = 0b_0000_0000_0000_0100_0000_0000_0000,
        P = 0b_0000_0000_0000_1000_0000_0000_0000,
        Q = 0b_0000_0000_0001_0000_0000_0000_0000,
        R = 0b_0000_0000_0010_0000_0000_0000_0000,
        S = 0b_0000_0000_0100_0000_0000_0000_0000,
        T = 0b_0000_0000_1000_0000_0000_0000_0000,
        U = 0b_0000_0001_0000_0000_0000_0000_0000,
        V = 0b_0000_0010_0000_0000_0000_0000_0000,
        W = 0b_0000_0100_0000_0000_0000_0000_0000,
        X = 0b_0000_1000_0000_0000_0000_0000_0000,
        Y = 0b_0001_0000_0000_0000_0000_0000_0000,
        Z = 0b_0010_0000_0000_0000_0000_0000_0000,
    }
    public enum OtherCharKeyList : long
    {
        None = 0,
        SemiColon = 0b_0000_0000_0000_0000_0000_0001, // ;
        Dash = 0b_0000_0000_0000_0000_0000_0010, // -
        Dot = 0b_0000_0000_0000_0000_0000_0100, //.
        Slash = 0b_0000_0000_0000_0000_0000_1000, // /
    }
    public class BaseKeys
    {
        public long key;
        public override int GetHashCode()
            => (int)key % 0b_1000_0000_0000;
        public override bool Equals(object obj)
        {
            if (obj is not BaseKeys) throw new InvalidCastException($"{obj.GetType()} is not BaseKeys type");
            return (obj as BaseKeys).key == key;
        }
        public static bool operator ==(BaseKeys a, BaseKeys b)
            => a.key == b.key;
        public static bool operator !=(BaseKeys a, BaseKeys b)
            => a.key != b.key;
        public void CopyTo(BaseKeys a)
        {
            key = a.key;
        }
        public BaseKeys()
            => key = 0;
        public BaseKeys(long a)
            => key = a;
    }
    public class PressedKeys {
        public BaseKeys number, ch, special, other, editional;
        public PressedKeys(NumberKeyList num = 0, SpecialKeyList special = 0, OtherCharKeyList other = 0, EngCharKeyList ch = 0)
        {
            this.number = new((long)num);
            this.ch = new((long)ch);
            this.special = new((long)special);
            this.other = new((long)other);
            this.editional = new(); //Not Supported Yet
        }
        public void AddKey(NumberKeyList n)
            => number.key |= (long)n;
        public void AddKey(SpecialKeyList n)
            => special.key |= (long)n;
        public void AddKey(EngCharKeyList n)
            => ch.key |= (long)n;
        public void AddKey(OtherCharKeyList n)
            => ch.key |= (long)n;
        public void RemoveKey(NumberKeyList n)
        {
            if ((number.key | (long)n) == (long)n)
                number.key -= (long)n;
        }
        public void RemoveKey(SpecialKeyList n)
        {
            if ((special.key | (long)n) == (long)n)
                special.key -= (long)n;
        }
        public void RemoveKey(EngCharKeyList n)
        {
            if ((ch.key | (long)n) == (long)n)
                ch.key -= (long)n;
        }
        public void RemoveKey(OtherCharKeyList n)
        {
            if ((other.key | (long)n) == (long)n)
                other.key -= (long)n;
        }
        public bool ExistKey(NumberKeyList n)
            => (number.key | (long)n) == (long)n;
        public bool ExistKey(SpecialKeyList n)
            => (special.key | (long)n) == (long)n;
        public bool ExistKey(EngCharKeyList n)
            => (ch.key | (long)n) == (long)n;
        public bool ExistKey(OtherCharKeyList n)
            => (other.key | (long)n) == (long)n;
        public override int GetHashCode()
            => number.GetHashCode() & special.GetHashCode() & ch.GetHashCode() & other.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is not PressedKeys) throw new InvalidCastException($"{obj.GetType()} is not PressedKeys type");
            var k = obj as PressedKeys;
            return k.number == number && k.special == special && k.other == other && k.ch == ch && k.editional == editional;
        }
        public static bool operator ==(PressedKeys a, PressedKeys b)
            => a.Equals(b);
        public static bool operator !=(PressedKeys a, PressedKeys b)
            => !a.Equals(b);
    }
}
