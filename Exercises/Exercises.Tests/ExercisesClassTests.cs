using Exercises.Models;
using Exercises.Tests.ClassData;
using Xunit;

namespace Exercises.Tests
{
    public class ExercisesClassTests
    {
        private readonly ExercisesClass exercisesClass;

        public ExercisesClassTests()
        {
            this.exercisesClass = new ExercisesClass();
        }

        [Theory]
        [ClassData(typeof(InvertStringData))]
        public void InvertString(string input, string expectedResult)
        {
            string result = this.exercisesClass.InvertString(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(IsEmailFormatData))]
        public void IsEmailFormat(string input, bool expectedResult)
        {
            bool result = this.exercisesClass.IsEmailFormat(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(RemoveVowelsData))]
        public void RemoveVowels(string input, string expectedResult)
        {
            string result = this.exercisesClass.RemoveVowels(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(PascalCaseToSentenceData))]
        public void PascalCaseToSentence(string input, string expectedResult)
        {
            string result = this.exercisesClass.PascalCaseToSentence(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(SeparateData))]
        public void Separate(string input, char separator, IEnumerable<string> expectedResult)
        {
            IEnumerable<string> result = this.exercisesClass.Separate(input, separator);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(CountItemsData))]
        public void CountItems(Container input, int expectedResult)
        {
            int result = this.exercisesClass.CountItems(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(IsReferenceTypeData))]
        public void IsReferenceType(Type input, bool expectedResult)
        {
            bool result = this.exercisesClass.IsReferenceType(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(HasPropertyData))]
        public void HasProperty(Type input, string propertyName, bool expectedResult)
        {
            bool result = this.exercisesClass.HasProperty(input, propertyName);
            Assert.Equal(expectedResult, result);
        }
    }
}