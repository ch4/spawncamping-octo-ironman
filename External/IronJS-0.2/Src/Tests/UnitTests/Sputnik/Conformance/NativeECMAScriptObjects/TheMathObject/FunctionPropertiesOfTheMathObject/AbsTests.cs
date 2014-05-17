// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.FunctionPropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AbsTests : SputnikTestFixture
    {
        public AbsTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.2_Function_Properties_of_the_Math_Object\15.8.2.1_abs")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.1")]
        [TestCase("S15.8.2.1_A1.js", Description = "If x is NaN, Math.abs(x) is NaN")]
        public void IfXIsNaNMathAbsXIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.1")]
        [TestCase("S15.8.2.1_A2.js", Description = "If x is -0, Math.abs(x) is +0")]
        public void IfXIs0MathAbsXIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.1")]
        [TestCase("S15.8.2.1_A3.js", Description = "If x is -Infinity, Math.abs(x) is +Infinity")]
        public void IfXIsInfinityMathAbsXIsInfinity(string file)
        {
            RunFile(file);
        }
    }
}