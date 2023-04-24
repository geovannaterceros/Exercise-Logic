using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class InvertStringData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "Something in the way",
                "yaw eht ni gnihtemoS",
            };

            yield return new object[]
            {
                "Hello World!",
                "!dlroW olleH",
            };

            yield return new object[]
            {
                "",
                "",
            };

            yield return new object[]
            {
                "65dos",
                "sod56",
            };

            yield return new object[]
            {
                " ",
                " ",
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
