// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.LexicalConventions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class IdentifiersTests : SputnikTestFixture
    {
        public IdentifiersTests()
            : base(@"Conformance\07_Lexical_Conventions\7.6_Identifiers")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.6")]
        [TestCase("S7.6_A1.2_T1.js", Description = "IdentifierStart :: $")]
        [TestCase("S7.6_A1.2_T2.js", Description = "IdentifierStart :: $")]
        [TestCase("S7.6_A1.2_T3.js", Description = "IdentifierStart :: $")]
        public void IdentifierStart(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.6")]
        [TestCase("S7.6_A1.3_T1.js", Description = "IdentifierStart :: _")]
        [TestCase("S7.6_A1.3_T2.js", Description = "IdentifierStart :: _")]
        [TestCase("S7.6_A1.3_T3.js", Description = "IdentifierStart :: _")]
        public void IdentifierStart_(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.6")]
        [TestCase("S7.6_A2.1_T1.js", Description = "IdentifierPart :: IdentifierStart")]
        [TestCase("S7.6_A2.1_T2.js", Description = "IdentifierPart :: IdentifierStart")]
        [TestCase("S7.6_A2.1_T3.js", Description = "IdentifierPart :: IdentifierStart")]
        [TestCase("S7.6_A2.1_T4.js", Description = "IdentifierPart :: IdentifierStart")]
        public void IdentifierPartIdentifierStart(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.6")]
        [TestCase("S7.6_A4.1_T1.js", Description = "Correct interpretation of ENGLISH ALPHABET")]
        [TestCase("S7.6_A4.1_T2.js", Description = "Correct interpretation of ENGLISH ALPHABET")]
        public void CorrectInterpretationOfENGLISHALPHABET(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.6")]
        [TestCase("S7.6_A4.2_T1.js", Description = "Correct interpretation of RUSSIAN ALPHABET")]
        [TestCase("S7.6_A4.2_T2.js", Description = "Correct interpretation of RUSSIAN ALPHABET")]
        public void CorrectInterpretationOfRUSSIANALPHABET(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.6")]
        [TestCase("S7.6_A4.3_T1.js", Description = "Correct interpretation of DIGITS")]
        public void CorrectInterpretationOfDIGITS(string file)
        {
            RunFile(file);
        }
    }
}