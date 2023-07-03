using Exercises.Models;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Exercises
{
    public class ExercisesClass
    {
        /// <summary>
        /// This method will return the input string inverted.
        /// </summary>
        public string InvertString(string input)
        {
            IEnumerable<char> revert =  input.Reverse();
            return new String(revert.ToArray());
        }

        /// <summary>
        /// This method will return wether the input value has a valid email format example@site.com
        /// </summary>
        public bool IsEmailFormat(string input)
        {
            /*
             * ^ - Representa el comienzo de la cadena.
                [a-zA-Z0-9._%+-]+ - Corresponde a uno o más caracteres alfanuméricos, puntos, guiones bajos, signos de porcentaje y signos más y menos. 
                Esto representa el nombre de usuario de la dirección de correo electrónico.
                @ - Corresponde al símbolo "@" que separa el nombre de usuario del dominio.
                [a-zA-Z0-9.-]+ - Corresponde a uno o más caracteres alfanuméricos, puntos y guiones. 
                Esto representa el dominio de la dirección de correo electrónico.
                \. - Corresponde a un punto literal ".", que se utiliza para separar el dominio de la extensión.
                [a-zA-Z]{2,} - Corresponde a dos o más letras, que representan la extensión del dominio (por ejemplo, "com", "org", "edu").
                $ - Representa el final de la cadena.
             */
            Regex regexToEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            return regexToEmail.IsMatch(input);
        }

        /// <summary>
        /// This method will return the input string after removing all vowels from it.
        /// </summary>
        public string RemoveVowels(string input)
        {
            string regexReplaceVowels = Regex.Replace(input, "[aeiouAEIOU]", "");
            return regexReplaceVowels;
        }

        /// <summary>
        /// This method will convert the input string from pascal case to a normal sentence.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string PascalCaseToSentence(string input)
        {

            string regexReplacePascalCase = Regex.Replace(input, "(?<!^)([A-Z])", match =>
            {
                char lowercaseLetter = char.ToLower(match.Value[0]);
                return $" {lowercaseLetter}";
            });
            return regexReplacePascalCase;
        }

        /// <summary>
        /// This method wil separate the input string using the given separator char, and return the collection.
        /// </summary>
        public IEnumerable<string> Separate(string input, char separator)
        {
            if (input.Length > 1) {
                input = input.Trim();
                var separeted = input.Split(separator);
                return separeted.Select(s => s.Trim()).ToArray();
            }
            else
            {
                return Array.Empty<string>();
            }
        }

        /// <summary>
        /// This method will return how many items does the input container has in total, including inside the boxes.
        /// </summary>
        public int CountItems(Container input)
        {
            int count = 0;
            int countItems = input.Items.Count();
            count += countItems;

            foreach (var item in input.Boxes) 
            {
                count = count + item.Items.Count();
            }
            return count;
        }

        /// <summary>
        /// This method will return wether the input object's class is a reference type or not
        /// </summary>
        public bool IsReferenceType(Type input)
        {
            bool result = !input.IsValueType;
            return result;
        }

        /// <summary>
        /// This method will return wether the input object's class has a property named 'Name' or not, including private properties.
        /// </summary>
        public bool HasProperty(Type input, string propertyName)
        {
            PropertyInfo[] properties = input.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                if (property.Name == propertyName) {
                
                    return true;            
                }  
            }
            return false;
        }
    }
}