using System.Collections;

namespace Exercises.Tests.ClassData.ValidateList
{
    public class GetMaxNumber : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]{
                new List<int>{1,2,3},
                3,
            };

            yield return new object[]{
                new List<int>{-1,-2,0},
                0,
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
