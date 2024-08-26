
namespace FundamentalsTest.TypeSystem.IntegralTypes
{
    using Fundamentals.TypeSystem.IntegralTypes;
    public class IntegralTypesTest
    {
        private readonly int[] expected = [1, 1, 2, 2, 4, 4, 8, 8];
        [Test]
        public void Test()
        {
            Assert.That(IntegralTypes.ByteSize(), Is.EqualTo(expected));
        }
    }
}
