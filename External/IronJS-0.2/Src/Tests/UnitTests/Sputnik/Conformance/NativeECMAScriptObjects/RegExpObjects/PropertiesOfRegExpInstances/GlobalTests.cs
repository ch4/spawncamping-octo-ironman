// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PropertiesOfRegExpInstances
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class GlobalTests : SputnikTestFixture
    {
        public GlobalTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.7_Properties_of_RegExp_Instances\15.10.7.2_global")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.7.2")]
        [TestCase("S15.10.7.2_A10.js", Description = "The RegExp instance global property has the attribute ReadOnly")]
        public void TheRegExpInstanceGlobalPropertyHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.7.2")]
        [TestCase("S15.10.7.2_A8.js", Description = "The RegExp instance global property has the attribute DontEnum")]
        public void TheRegExpInstanceGlobalPropertyHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.7.2")]
        [TestCase("S15.10.7.2_A9.js", Description = "The RegExp instance global property has the attribute DontDelete")]
        public void TheRegExpInstanceGlobalPropertyHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }
    }
}