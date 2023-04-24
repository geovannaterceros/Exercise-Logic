using System.Collections;

namespace Exercises.Tests.ClassData
{
    public class IsEmailFormatData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "@test.com",
                false,
            };

            yield return new object[]
            {
                "Hello World!",
                false,
            };

            yield return new object[]
            {
                "",
                false,
            };

            yield return new object[]
            {
                "testsite.com",
                false,
            };

            yield return new object[]
            {
                "some test@site.com",
                false,
            };

            yield return new object[]
            {
                "sometest@site.com",
                true,
            };

            yield return new object[]
            {
                "name.com@gmail",
                false,
            };

            yield return new object[]
            {
                "john.wick@site.com",
                true,
            };

            yield return new object[]
            {
                "some@test@site.com",
                false,
            };

            yield return new object[]
            {
                "some@test@site.",
                false,
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
