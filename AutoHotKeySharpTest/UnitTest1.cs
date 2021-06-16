using NUnit.Framework;

using AutoHotKeyCSharp;

namespace AutoHotKeySharpTest
{
    public class TestAttr : IAutoHotKeySharpClass
    {
        [Key(special: (long)SpecialKeyList.Control)]
        public static void Hi()
            => Assert.Pass("sssss");
        [Key(special: (long)SpecialKeyList.Alt)]
        [Key(number: (long)NumberKeyList.Four)]
        public static void Gyu()
        {
            Assert.Fail("GGANG");
        }
        [Key(special: (long)SpecialKeyList.Alt, number: (long)NumberKeyList.Four)]
        public static void Tester()
        {
            Assert.Fail("nya");
        }
        [Key(10)]
        [Key(11)]
        public static void Hii()
            => Assert.Fail("Hiii");
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            AutoHotKeySharp.Rigister(new TestAttr());
        }

        [Test]
        public void Test1()
        {
            AutoHotKeySharp.Test_ExecuteViaKeyCode(new PressedKeys(special: SpecialKeyList.Control));
        }
        [Test]
        public void Test2()
        {
            AutoHotKeySharp.Test_ExecuteViaKeyCode(new PressedKeys(special: SpecialKeyList.Alt, num: NumberKeyList.Four));
        }
        [Test]
        public void Test4()
        {
            if (new PressedKeys(special: SpecialKeyList.Control) == new PressedKeys(num: NumberKeyList.Zero, special: SpecialKeyList.Control))
                Assert.Fail();
            else Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            AutoHotKeySharp.Test_ExecuteViaKeyCode(new PressedKeys((NumberKeyList)11));
        }
    }
}