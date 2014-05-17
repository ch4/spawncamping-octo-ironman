// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.LexicalConventions.Literals
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RegularExpressionLiteralsTests : SputnikTestFixture
    {
        public RegularExpressionLiteralsTests()
            : base(@"Conformance\07_Lexical_Conventions\7.8_Literals\7.8.5_Regular_Expression_Literals")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.1")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A1.1_T1.js", Description = "RegularExpressionFirstChar :: NonTerminator but not * or \\ or /, RegularExpressionChars :: [empty], RegularExpressionFlags :: [empty]")]
        [TestCase("S7.8.5_A1.1_T2.js", Description = "RegularExpressionFirstChar :: NonTerminator but not * or \\ or /, RegularExpressionChars :: [empty], RegularExpressionFlags :: [empty]")]
        public void RegularExpressionFirstCharNonTerminatorButNotOrOrRegularExpressionCharsEmptyRegularExpressionFlagsEmpty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A1.2_T1.js", Description = "RegularExpressionFirstChar :: * or \\ or / or [empty] is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A1.2_T2.js", Description = "RegularExpressionFirstChar :: * or \\ or / or [empty] is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A1.2_T3.js", Description = "RegularExpressionFirstChar :: * or \\ or / or [empty] is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A1.2_T4.js", Description = "RegularExpressionFirstChar :: * or \\ or / or [empty] is incorrect", ExpectedException = typeof(Exception))]
        public void RegularExpressionFirstCharOrOrOrEmptyIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A1.3_T1.js", Description = "RegularExpressionFirstChar :: LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A1.3_T2.js", Description = "RegularExpressionFirstChar :: LineTerminator is incorrect")]
        [TestCase("S7.8.5_A1.3_T3.js", Description = "RegularExpressionFirstChar :: LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A1.3_T4.js", Description = "RegularExpressionFirstChar :: LineTerminator is incorrect")]
        [TestCase("S7.8.5_A1.3_T5.js", Description = "RegularExpressionFirstChar :: LineTerminator is incorrect")]
        [TestCase("S7.8.5_A1.3_T6.js", Description = "RegularExpressionFirstChar :: LineTerminator is incorrect")]
        public void RegularExpressionFirstCharLineTerminatorIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.1")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A1.4_T1.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\NonTerminator,  RegularExpressionChars :: [empty], RegularExpressionFlags :: [empty]")]
        [TestCase("S7.8.5_A1.4_T2.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\NonTerminator,  RegularExpressionChars :: [empty], RegularExpressionFlags :: [empty]")]
        public void RegularExpressionFirstCharBackslashSequenceNonTerminatorRegularExpressionCharsEmptyRegularExpressionFlagsEmpty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A1.5_T1.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A1.5_T2.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        [TestCase("S7.8.5_A1.5_T3.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A1.5_T4.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        [TestCase("S7.8.5_A1.5_T5.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        [TestCase("S7.8.5_A1.5_T6.js", Description = "RegularExpressionFirstChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        public void RegularExpressionFirstCharBackslashSequenceLineTerminatorIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.1")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A2.1_T1.js", Description = "RegularExpressionChar :: NonTerminator but not \\ or /, RegularExpressionFlags :: [empty]")]
        [TestCase("S7.8.5_A2.1_T2.js", Description = "RegularExpressionChar :: NonTerminator but not \\ or /, RegularExpressionFlags :: [empty]")]
        public void RegularExpressionCharNonTerminatorButNotOrRegularExpressionFlagsEmpty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A2.2_T1.js", Description = "RegularExpressionChar :: \\ or / is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A2.2_T2.js", Description = "RegularExpressionChar :: \\ or / is incorrect", ExpectedException = typeof(Exception))]
        public void RegularExpressionCharOrIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A2.3_T1.js", Description = "RegularExpressionChar :: LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A2.3_T2.js", Description = "RegularExpressionChar :: LineTerminator is incorrect")]
        [TestCase("S7.8.5_A2.3_T3.js", Description = "RegularExpressionChar :: LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A2.3_T4.js", Description = "RegularExpressionChar :: LineTerminator is incorrect")]
        [TestCase("S7.8.5_A2.3_T5.js", Description = "RegularExpressionChar :: LineTerminator is incorrect")]
        [TestCase("S7.8.5_A2.3_T6.js", Description = "RegularExpressionChar :: LineTerminator is incorrect")]
        public void RegularExpressionCharLineTerminatorIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.1")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A2.4_T1.js", Description = "RegularExpressionChar :: BackslashSequence :: \\NonTerminator,  RegularExpressionFlags :: [empty]")]
        [TestCase("S7.8.5_A2.4_T2.js", Description = "RegularExpressionChar :: BackslashSequence :: \\NonTerminator,  RegularExpressionFlags :: [empty]")]
        public void RegularExpressionCharBackslashSequenceNonTerminatorRegularExpressionFlagsEmpty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A2.5_T1.js", Description = "RegularExpressionChar :: BackslashSequence :: \\LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A2.5_T2.js", Description = "RegularExpressionChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        [TestCase("S7.8.5_A2.5_T3.js", Description = "RegularExpressionChar :: BackslashSequence :: \\LineTerminator is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.5_A2.5_T4.js", Description = "RegularExpressionChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        [TestCase("S7.8.5_A2.5_T5.js", Description = "RegularExpressionChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        [TestCase("S7.8.5_A2.5_T6.js", Description = "RegularExpressionChar :: BackslashSequence :: \\LineTerminator is incorrect")]
        public void RegularExpressionCharBackslashSequenceLineTerminatorIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.4.1")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A3.1_T1.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T2.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T3.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T4.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T5.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T6.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T7.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T8.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        [TestCase("S7.8.5_A3.1_T9.js", Description = "RegularExpressionFlags :: IdentifierPart")]
        public void RegularExpressionFlagsIdentifierPart(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A4.1.js", Description = "A regular expression literal is an input element that is converted to a RegExp object when it is scanned")]
        public void ARegularExpressionLiteralIsAnInputElementThatIsConvertedToARegExpObjectWhenItIsScanned(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.5")]
        [TestCase("S7.8.5_A4.2.js", Description = "Two regular expression literals in a program evaluate to regular expression objects that never compare as === to each other even if the two literals\' contents are identical")]
        public void TwoRegularExpressionLiteralsInAProgramEvaluateToRegularExpressionObjectsThatNeverCompareAsToEachOtherEvenIfTheTwoLiteralsContentsAreIdentical(string file)
        {
            RunFile(file);
        }
    }
}