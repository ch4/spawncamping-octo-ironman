// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ArrayPrototypeConstructorTests : SputnikTestFixture
    {
        public ArrayPrototypeConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object\15.4.4.1_Array_prototype_constructor")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.1")]
        [TestCase("S15.4.4.1_A1_T1.js", Description = "The initial value of Array.prototype.constructor is the built-in Array constructor")]
        public void TheInitialValueOfArrayPrototypeConstructorIsTheBuiltInArrayConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.4.1")]
        [TestCase("S15.4.4.1_A2.js", Description = "The constructor property of Array has the attribute DontEnum")]
        public void TheConstructorPropertyOfArrayHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }
    }
}