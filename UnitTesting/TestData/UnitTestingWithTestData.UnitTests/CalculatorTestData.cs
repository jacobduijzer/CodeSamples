using System.Collections;
using System.Collections.Generic;

namespace UnitTestingWithTestData.UnitTests
{
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {10, 2, 8};
            yield return new object[] {2, 2, 0};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}