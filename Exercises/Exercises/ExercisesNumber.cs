using Exercises.Models;

namespace Exercises
{
    public class ExercisesNumber
    {
        public List<int> OrderAsc(List<int> numbers) 
        {
            List<int> result = numbers.OrderBy(x => x).ToList();
            return result;
        }

        public int GetMaxNumber(List<int> numbers)
        { 
            int result = numbers.Max(x => x);
            return result;
        }
    }
}
