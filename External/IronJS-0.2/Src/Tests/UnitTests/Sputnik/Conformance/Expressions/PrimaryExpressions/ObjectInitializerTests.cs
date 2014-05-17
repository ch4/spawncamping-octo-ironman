// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.PrimaryExpressions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ObjectInitializerTests : SputnikTestFixture
    {
        public ObjectInitializerTests()
            : base(@"Conformance\11_Expressions\11.1_Primary_Expressions\11.1.5_Object_Initializer")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A1.1.js", Description = "Evaluate the production ObjectLiteral: { }")]
        public void EvaluateTheProductionObjectLiteral(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A1.2.js", Description = "Evaluate the production ObjectLiteral: { NumericLiteral : AssignmentExpression}")]
        public void EvaluateTheProductionObjectLiteralNumericLiteralAssignmentExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A1.3.js", Description = "Evaluate the production ObjectLiteral: { StringLiteral : AssignmentExpression}")]
        public void EvaluateTheProductionObjectLiteralStringLiteralAssignmentExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A1.4.js", Description = "Evaluate the production ObjectLiteral: { Identifier : AssignmentExpression}")]
        public void EvaluateTheProductionObjectLiteralIdentifierAssignmentExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A2.js", Description = "Evaluate the production ObjectLiteral: { PropertyName : AssignmentExpression }")]
        public void EvaluateTheProductionObjectLiteralPropertyNameAssignmentExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A3.js", Description = "Evaluate the production ObjectLiteral: { PropertyNameAndValueList }")]
        public void EvaluateTheProductionObjectLiteralPropertyNameAndValueList(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A4.1.js", Description = "The PropertyName is not BooleanLiteral", ExpectedException = typeof(Exception))]
        public void ThePropertyNameIsNotBooleanLiteral(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A4.2.js", Description = "The PropertyName is not nullLiteral", ExpectedException = typeof(Exception))]
        public void ThePropertyNameIsNotNullLiteral(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.5")]
        [TestCase("S11.1.5_A4.3.js", Description = "The PropertyName is undefined, ToString(BooleanLiteral), ToString(nullLiteral)")]
        public void ThePropertyNameIsUndefinedToStringBooleanLiteralToStringNullLiteral(string file)
        {
            RunFile(file);
        }
    }
}