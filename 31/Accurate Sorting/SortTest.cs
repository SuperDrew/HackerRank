namespace _31.Accurate_Sorting
{
    using NUnit.Framework;

    [TestFixture]
    public class SortTest
    {
        [Test]
        [TestCase(new[] { 0, 1 }, TestName = "already sorted")]
        [TestCase(new[] { 1, 0 }, TestName = "one sort required")]
        [TestCase(new[] { 1, 0, 2 }, TestName = "swop at begging")]
        [TestCase(new[] { 0, 2, 1 }, TestName = "swop at begging")]
        [TestCase(new[] { 0, 2, 1, 3 }, TestName = "swop in the middle")]
        [TestCase(new[] { 0, 2, 1, 3, 4 }, TestName = "longer one")]
        public void ShouldBeSortable(int[] value)
        {
            var result = Sort.DoIt(value);
            Assert.That(result, Is.EqualTo("Yes"), "should have been sortable, output of sort was: " + value);
        }

        [Test]
        [TestCase(new[] { 2, 0 }, TestName = "gap is too big")]
        [TestCase(new[] { 2, 0, 1 }, TestName = "gap is too big, at begging")]
        [TestCase(new[] { 1, 2, 0 }, TestName = "gap is too big, at end")]
        [TestCase(new[] { 1, 2, 0, 3 }, TestName = "gap is too big, in the middle")]
        public void ShouldNotBeSortable(int[] value)
        {
            var result = Sort.DoIt(value);
            Assert.That(result, Is.EqualTo("No"), "Should not have been sortable, output of sort was: " + value);
        }
    }
}
