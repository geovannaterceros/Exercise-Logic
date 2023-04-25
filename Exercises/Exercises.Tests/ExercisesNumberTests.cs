using Exercises.Tests.ClassData.ValidateList;
using Xunit;

namespace Exercises.Tests
{
    public class ExercisesNumberTests
    {
        private readonly ExercisesNumber exercisesNumber;

        public ExercisesNumberTests()
        {
            this.exercisesNumber = new ExercisesNumber();
        }

        [Theory]
        [ClassData(typeof(OrderNumber))]
        public void OrderNumber(List<int> input, List<int> expectResult) 
        {
            List<int> result = this.exercisesNumber.OrderAsc(input);
            Assert.Equal(expectResult, result);
        }

        [Theory]
        [ClassData(typeof(GetMaxNumber))]
        public void GetMaxNumber(List<int> input, int expectResult) 
        {
            int result = this.exercisesNumber.GetMaxNumber(input);
            Assert.Equal(expectResult, result);
        }
    }
}
