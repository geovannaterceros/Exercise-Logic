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

        public List<int> DeleteDuplicate(List<int> input) 
        {
            List<int> result = input.Distinct().ToList();
            return result;  
        }

        public List<Person>OrderByForNameAndAge(List<Person> input)
        {
            List<Person> result = input.OrderBy(x=>x.Name).ThenBy(x=>x.Age).ToList();
            return result;
        }

        public int AgregateOperation(List<int> input) 
        {
            int result = input.Aggregate((x, y) => x + y);
            return result;
        }
    }
}
