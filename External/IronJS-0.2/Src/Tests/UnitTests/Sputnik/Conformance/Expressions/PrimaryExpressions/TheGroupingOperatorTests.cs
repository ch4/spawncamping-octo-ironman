// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.PrimaryExpressions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheGroupingOperatorTests : SputnikTestFixture
    {
        public TheGroupingOperatorTests()
            : base(@"Conformance\11_Expressions\11.1_Primary_Expressions\11.1.6_The_Grouping_Operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.6")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.1.6_A1.js", Description = "White Space and Line Terminator inside \"grouping\" operator are allowed")]
        public void WhiteSpaceAndLineTerminatorInsideGroupingOperatorAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.6")]
        [TestCase("S11.1.6_A2.js", Description = "\"This\" operator doesn\'t use GetValue. The operators \"delete\" and \"typeof\" can be applied to parenthesised expressions")]
        public void ThisOperatorDoesnTUseGetValueTheOperatorsDeleteAndTypeofCanBeAppliedToParenthesisedExpressions(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.6")]
        [TestCase("S11.1.6_A3_T1.js", Description = "\"This\" operator only evaluates Expression")]
        [TestCase("S11.1.6_A3_T2.js", Description = "\"This\" operator only evaluates Expression")]
        [TestCase("S11.1.6_A3_T3.js", Description = "\"This\" operator only evaluates Expression")]
        [TestCase("S11.1.6_A3_T4.js", Description = "\"This\" operator only evaluates Expression")]
        [TestCase("S11.1.6_A3_T5.js", Description = "\"This\" operator only evaluates Expression")]
        [TestCase("S11.1.6_A3_T6.js", Description = "\"This\" operator only evaluates Expression")]
        public void ThisOperatorOnlyEvaluatesExpression(string file)
        {
            RunFile(file);
        }
    }
}