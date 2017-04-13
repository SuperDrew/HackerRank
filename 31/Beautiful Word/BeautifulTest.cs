namespace _31.Beautiful_Word
{
    using NUnit.Framework;
    
    [TestFixture]
    public class BeautifulTest
    {
        [Test]
        [TestCase("aawerwe", TestName = "duplicate at start")]
        [TestCase("werwezz", TestName = "duplicate at end")]
        [TestCase("werbbwe", TestName = "duplicate in middle")]
        [TestCase("eawerbwe", TestName = "vowel duplicate at start")]
        [TestCase("werbfweyfsdfsdf", TestName = "vowel duplicate at middle")]
        [TestCase("dea", TestName = "vowel duplicate at end, odd length")]
        [TestCase("dfea", TestName = "vowel duplicate at end, even length")]
        public void ConsecutiveShouldFail(string value)
        {
            // Act
            var passed = Beautiful.IsBeautiful(value);

            Assert.That(passed, Is.EqualTo("No"), $"{value} should not be beutiful");
        }

        [Test]
        [TestCase("batman")]
        [TestCase("batemani")]
        [TestCase("ebatemani")]
        [TestCase("temsdfjgyhsdfguhsedrijhslkjfd")]
        public void BeautifulStringShouldPass(string value)
        {
            // Act
            var passed = Beautiful.IsBeautiful(value);

            Assert.That(passed, Is.EqualTo("Yes"), $"{value} should not be beutiful");
        }
    }
}
