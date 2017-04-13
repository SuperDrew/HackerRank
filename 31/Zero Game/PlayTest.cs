namespace _31.Zero_Game
{
    using NUnit.Framework;

    [TestFixture]
    public class PlayTest
    {
        private const string Alice = "Alice";

        private const string Bob = "Bob";

        [Test]
        [TestCase(new[] { 1, 0, 0, 1 }, Bob)]
        public void Test(int[] value, string expectedWinner)
        {
            
        }
    }
}
