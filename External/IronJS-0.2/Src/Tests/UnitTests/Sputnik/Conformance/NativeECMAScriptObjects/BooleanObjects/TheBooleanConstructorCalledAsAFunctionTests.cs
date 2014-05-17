// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.BooleanObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheBooleanConstructorCalledAsAFunctionTests : SputnikTestFixture
    {
        public TheBooleanConstructorCalledAsAFunctionTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.6_Boolean_Objects\15.6.1_The_Boolean_Constructor_Called_as_a_Function")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.1.1")]
        [TestCase("S15.6.1.1_A1_T1.js", Description = "Returns a boolean value (not a Boolean object) computed by ToBoolean(value)")]
        [TestCase("S15.6.1.1_A1_T2.js", Description = "Returns a boolean value (not a Boolean object) computed by ToBoolean(value)")]
        [TestCase("S15.6.1.1_A1_T3.js", Description = "Returns a boolean value (not a Boolean object) computed by ToBoolean(value)")]
        [TestCase("S15.6.1.1_A1_T4.js", Description = "Returns a boolean value (not a Boolean object) computed by ToBoolean(value)")]
        [TestCase("S15.6.1.1_A1_T5.js", Description = "Returns a boolean value (not a Boolean object) computed by ToBoolean(value)")]
        public void ReturnsABooleanValueNotABooleanObjectComputedByToBooleanValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.1.1")]
        [TestCase("S15.6.1.1_A2.js", Description = "Boolean() returns false")]
        public void BooleanReturnsFalse(string file)
        {
            RunFile(file);
        }
    }
}