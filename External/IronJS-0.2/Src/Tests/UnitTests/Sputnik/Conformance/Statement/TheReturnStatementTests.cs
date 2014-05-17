// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Statement
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheReturnStatementTests : SputnikTestFixture
    {
        public TheReturnStatementTests()
            : base(@"Conformance\12_Statement\12.9_The_return_Statement")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.9")]
        [TestCase("S12.9_A1_T1.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T10.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T2.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T3.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T4.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T5.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T6.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T7.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T8.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.9_A1_T9.js", Description = "Appearing of \"return\" without a function body leads to syntax error", ExpectedException = typeof(Exception))]
        public void AppearingOfReturnWithoutAFunctionBodyLeadsToSyntaxError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.9")]
        [TestCase("S12.9_A2.js", Description = "LineTerminator between return and Identifier_opt yields return without Identifier_opt")]
        public void LineTerminatorBetweenReturnAndIdentifier_optYieldsReturnWithoutIdentifier_opt(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.9")]
        [TestCase("S12.9_A3.js", Description = "If Expression is omitted, the return value is undefined")]
        public void IfExpressionIsOmittedTheReturnValueIsUndefined(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.9")]
        [TestCase("S12.9_A4.js", Description = "The production ReturnStatement : return Expression")]
        public void TheProductionReturnStatementReturnExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.9")]
        [TestCase("S12.9_A5.js", Description = "Code after ReturnStatement is not evaluated")]
        public void CodeAfterReturnStatementIsNotEvaluated(string file)
        {
            RunFile(file);
        }
    }
}