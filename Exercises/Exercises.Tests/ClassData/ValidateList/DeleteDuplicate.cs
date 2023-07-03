using System.Collections;

namespace Exercises.Tests.ClassData.ValidateList
{
    internal class DeleteDuplicate : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]{
                new List<int>{1,2,3,2,1},
                new List<int>{1,2,3},
            };

            yield return new object[]{
                new List<int>{-1,0,0,0,1},
                new List<int>{-1,0,1},
            };

            yield return new object[]{
                new List<int>{1,2,3},
                new List<int>{1,2,3},
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
