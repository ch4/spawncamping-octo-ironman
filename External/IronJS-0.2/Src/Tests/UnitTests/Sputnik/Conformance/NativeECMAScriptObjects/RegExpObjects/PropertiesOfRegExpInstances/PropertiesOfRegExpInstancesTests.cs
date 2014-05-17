// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PropertiesOfRegExpInstances
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertiesOfRegExpInstancesTests : SputnikTestFixture
    {
        public PropertiesOfRegExpInstancesTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.7_Properties_of_RegExp_Instances")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.7")]
        [TestCase("S15.10.7_A1_T1.js", Description = "RegExp instance has not [[call]] property")]
        [TestCase("S15.10.7_A1_T2.js", Description = "RegExp instance has not [[call]] property")]
        public void RegExpInstanceHasNotCallProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.7")]
        [TestCase("S15.10.7_A2_T1.js", Description = "RegExp instance has not [[construct]] property")]
        [TestCase("S15.10.7_A2_T2.js", Description = "RegExp instance has not [[construct]] property")]
        public void RegExpInstanceHasNotConstructProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.7")]
        [TestCase("S15.10.7_A3_T1.js", Description = "RegExp instance type is RegExp")]
        [TestCase("S15.10.7_A3_T2.js", Description = "RegExp instance type is RegExp")]
        public void RegExpInstanceTypeIsRegExp(string file)
        {
            RunFile(file);
        }
    }
}