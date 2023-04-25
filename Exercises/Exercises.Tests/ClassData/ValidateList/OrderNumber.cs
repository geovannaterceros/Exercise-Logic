using System.Collections;

namespace Exercises.Tests.ClassData.ValidateList
{
    public class OrderNumber : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new List<int>{3 , 2, 1, 4 },
                new List<int>{1 , 2, 3 , 4},
            };

            yield return new object[] {
                new List<int>{3 , 0, 1, 4 },
                new List<int>{0 , 1, 3 , 4},
            };

            yield return new object[] {
                new List<int>{3 , -1, 1, 4 },
                new List<int>{-1 , 1, 3 , 4},
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
