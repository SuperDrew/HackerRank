namespace _31.Zero_Game
{
    using NUnit.Framework;

    [TestFixture]
    public class PlayTest
    {
        private const string Alice = "Alice";

        private const string Bob = "Bob";

        [Test]
        [TestCase(new[] { 1, 0, 0, 1 }, Bob, TestName ="Eg1")]
        [TestCase(new[] { 1, 0, 1, 0, 1 }, Alice, TestName = "Eg2")]
        [TestCase(new[] { 0, 0, 0, 0, 0, 0 }, Bob, TestName = "Eg3")]
        [TestCase(new[] { 0, 0 }, Bob, TestName = "n = 2")]
        [TestCase(new[] { 0, 1, 0 }, Alice, TestName = "n = 3, one swap available")]
        [TestCase(new[] { 0, 1, 1 }, Bob, TestName = "n = 3, no swap available")]
        public void Test(int[] value, string expectedWinner)
        {
            var winner = Play.Go(value);
            Assert.That(
                winner, 
                Is.EqualTo(expectedWinner), 
                $"{expectedWinner} should have won, sequence was {Utils.ArrayToString(value)}");
        }
    }
}
