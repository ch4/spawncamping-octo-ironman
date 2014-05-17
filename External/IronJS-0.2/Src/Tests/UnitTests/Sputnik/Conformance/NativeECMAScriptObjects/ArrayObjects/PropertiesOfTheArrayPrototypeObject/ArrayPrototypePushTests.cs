// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ArrayPrototypePushTests : SputnikTestFixture
    {
        public ArrayPrototypePushTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object\15.4.4.7_Array_prototype_push")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A1_T1.js", Description = "The arguments are appended to the end of the array, in the order in which they appear. The new length of the array is returned as the result of the call")]
        [TestCase("S15.4.4.7_A1_T2.js", Description = "The arguments are appended to the end of the array, in the order in which they appear. The new length of the array is returned as the result of the call")]
        public void TheArgumentsAreAppendedToTheEndOfTheArrayInTheOrderInWhichTheyAppearTheNewLengthOfTheArrayIsReturnedAsTheResultOfTheCall(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A2_T1.js", Description = "The push function is intentionally generic. It does not require that its this value be an Array object")]
        [TestCase("S15.4.4.7_A2_T2.js", Description = "The push function is intentionally generic. It does not require that its this value be an Array object")]
        [TestCase("S15.4.4.7_A2_T3.js", Description = "The push function is intentionally generic. It does not require that its this value be an Array object")]
        public void ThePushFunctionIsIntentionallyGenericItDoesNotRequireThatItsThisValueBeAnArrayObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A3.js", Description = "Check ToUint32(length) for Array object")]
        public void CheckToUint32LengthForArrayObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A4_T1.js", Description = "Check ToUint32(length) for non Array objects")]
        [TestCase("S15.4.4.7_A4_T2.js", Description = "Check ToUint32(length) for non Array objects")]
        [TestCase("S15.4.4.7_A4_T3.js", Description = "Check ToUint32(length) for non Array objects")]
        public void CheckToUint32LengthForNonArrayObjects(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [Category("ECMA 8.6.2.1")]
        [TestCase("S15.4.4.7_A5_T1.js", Description = "[[Get]] from not an inherited property")]
        public void GetFromNotAnInheritedProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A6.1.js", Description = "The length property of push has the attribute DontEnum")]
        public void TheLengthPropertyOfPushHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [Category("ECMA 15.2.4.5")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A6.2.js", Description = "The length property of push has the attribute DontDelete")]
        public void TheLengthPropertyOfPushHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A6.3.js", Description = "The length property of push has the attribute ReadOnly")]
        public void TheLengthPropertyOfPushHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A6.4.js", Description = "The length property of push is 1")]
        public void TheLengthPropertyOfPushIs1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A6.5.js", Description = "The push property of Array has the attribute DontEnum")]
        public void ThePushPropertyOfArrayHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A6.6.js", Description = "The push property of Array has not prototype property")]
        public void ThePushPropertyOfArrayHasNotPrototypeProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.2")]
        [Category("ECMA 15.4.4.7")]
        [TestCase("S15.4.4.7_A6.7.js", Description = "The push property of Array can\'t be used as constructor")]
        public void ThePushPropertyOfArrayCanTBeUsedAsConstructor(string file)
        {
            RunFile(file);
        }
    }
}