using Fundamentals.TypeSystem.FloatingTypes;

namespace FundamentalsTest.TypeSystem.FloatingTypesTest.cs
{
    public class FloatingTypesTest
    {
        private readonly string expected = "Decimal Arithmetic: 3.1, 3.1, 1.2345, 111.1, 1500000";
        [Test]
        public void Test()
        {
            Assert.That(FloatingTypes.Solution(), Is.EqualTo(expected));
        }
    }
}
