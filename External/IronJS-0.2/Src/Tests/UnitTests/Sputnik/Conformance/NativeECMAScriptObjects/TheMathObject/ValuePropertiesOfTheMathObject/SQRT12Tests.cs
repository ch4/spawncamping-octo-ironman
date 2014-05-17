// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.ValuePropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SQRT12Tests : SputnikTestFixture
    {
        public SQRT12Tests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.1_Value_Properties_of_the_Math_Object\15.8.1.7_SQRT1_2")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.7")]
        [TestCase("S15.8.1.7_A1.js", Description = "Math.SQRT1_2 is approximately 0.7071067811865476")]
        public void MathSQRT1_2IsApproximately07071067811865476(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.7")]
        [TestCase("S15.8.1.7_A2.js", Description = "Value Property SQRT1_2 of the Math Object has the attribute DontEnum")]
        public void ValuePropertySQRT1_2OfTheMathObjectHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.7")]
        [TestCase("S15.8.1.7_A3.js", Description = "Value Property SQRT1_2 of the Math Object has the attribute DontDelete")]
        public void ValuePropertySQRT1_2OfTheMathObjectHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.7")]
        [TestCase("S15.8.1.7_A4.js", Description = "Value Property SQRT1_2 of the Math Object has the attribute ReadOnly")]
        public void ValuePropertySQRT1_2OfTheMathObjectHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }
    }
}