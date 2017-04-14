using NUnit.Framework;

namespace _31.Colliding_Circles
{
    [TestFixture]
    public class CollideTest
    {
        [Test]
        [TestCase(3, 1, new[] { 1, 2, 3 }, 67.0206432766f, TestName = "n3, k1, radii: 1, 2, 3: expected result 67.02...")]
        public void Go(int numberOfCircles, int numberOfSeconds, int[] radii, float expectedRadius)
        {
            var radius = Collide.Go(numberOfCircles, numberOfSeconds, radii);
            Assert.That(radius, Is.EqualTo(expectedRadius).Within(1).Ulps);
        }
    }
}
