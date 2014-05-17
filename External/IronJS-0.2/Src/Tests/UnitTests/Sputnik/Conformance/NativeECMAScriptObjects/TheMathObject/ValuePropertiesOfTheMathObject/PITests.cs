// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.ValuePropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PITests : SputnikTestFixture
    {
        public PITests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.1_Value_Properties_of_the_Math_Object\15.8.1.6_PI")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.6")]
        [TestCase("S15.8.1.6_A1.js", Description = "Math.PI is approximately 3.1415926535897932")]
        public void MathPIIsApproximately31415926535897932(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.6")]
        [TestCase("S15.8.1.6_A2.js", Description = "Value Property PI of the Math Object has the attribute DontEnum")]
        public void ValuePropertyPIOfTheMathObjectHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.6")]
        [TestCase("S15.8.1.6_A3.js", Description = "Value Property PI of the Math Object has the attribute DontDelete")]
        public void ValuePropertyPIOfTheMathObjectHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.6")]
        [TestCase("S15.8.1.6_A4.js", Description = "Value Property PI of the Math Object has the attribute ReadOnly")]
        public void ValuePropertyPIOfTheMathObjectHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }
    }
}