// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.StringObjects.PropertiesOfTheStringPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class StringPrototypeCharAtTests : SputnikTestFixture
    {
        public StringPrototypeCharAtTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.5_String_Objects\15.5.4_Properties_of_the_String_Prototype_Object\15.5.4.4_String.prototype.charAt")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A1.1.js", Description = "String.prototype.charAt() can accept many arguments")]
        public void StringPrototypeCharAtCanAcceptManyArguments(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A1_T1.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T10.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T2.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T3.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T4.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T5.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T6.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T7.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T8.js", Description = "String.prototype.charAt(pos)")]
        [TestCase("S15.5.4.4_A1_T9.js", Description = "String.prototype.charAt(pos)")]
        public void StringPrototypeCharAtPos(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A10.js", Description = "The String.prototype.charAt.length property has the attribute ReadOnly")]
        public void TheStringPrototypeCharAtLengthPropertyHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A11.js", Description = "The length property of the charAt method is 1")]
        public void TheLengthPropertyOfTheCharAtMethodIs1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A2.js", Description = "When String.prototype.charAt(pos) calls if ToInteger(pos) less than 0 the empty string returns")]
        public void WhenStringPrototypeCharAtPosCallsIfToIntegerPosLessThan0TheEmptyStringReturns(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A3.js", Description = "When String.prototype.charAt(pos) calls if ToInteger(pos) not less than ToString(this value) the empty string returns")]
        public void WhenStringPrototypeCharAtPosCallsIfToIntegerPosNotLessThanToStringThisValueTheEmptyStringReturns(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A4_T1.js", Description = "If pos is a value of Number type that is an integer, then the result of x.charAt(pos) is equal to the result of x.substring(pos, pos+1)")]
        [TestCase("S15.5.4.4_A4_T2.js", Description = "If pos is a value of Number type that is an integer, then the result of x.charAt(pos) is equal to the result of x.substring(pos, pos+1)")]
        [TestCase("S15.5.4.4_A4_T3.js", Description = "If pos is a value of Number type that is an integer, then the result of x.charAt(pos) is equal to the result of x.substring(pos, pos+1)")]
        public void IfPosIsAValueOfNumberTypeThatIsAnIntegerThenTheResultOfXCharAtPosIsEqualToTheResultOfXSubstringPosPos1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A5.js", Description = "When String.prototype.charAt(pos) calls first calls ToString, giving it the this value as its argument")]
        public void WhenStringPrototypeCharAtPosCallsFirstCallsToStringGivingItTheThisValueAsItsArgument(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A6.js", Description = "String.prototype.charAt has not prototype property")]
        public void StringPrototypeCharAtHasNotPrototypeProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A7.js", Description = "String.prototype.charAt can\'t be used as constructor")]
        public void StringPrototypeCharAtCanTBeUsedAsConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A8.js", Description = "The String.prototype.charAt.length property has the attribute DontEnum")]
        public void TheStringPrototypeCharAtLengthPropertyHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.4")]
        [TestCase("S15.5.4.4_A9.js", Description = "The String.prototype.charAt.length property has the attribute DontDelete")]
        public void TheStringPrototypeCharAtLengthPropertyHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }
    }
}