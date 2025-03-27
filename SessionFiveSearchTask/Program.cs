using System.Data;

namespace SessionFiveSearchTask
{
    internal class Program
    {
        static void CheckVowels(string input)
        {
            if (input.Contains("a") || input.Contains("o") || input.Contains("i") || input.Contains("e") || input.Contains("u"))
            {
                Console.WriteLine("Yor input is : " + input);
            }
            else
            {
                throw new Exception("The input must contains vowels characters");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input");
            string input = Console.ReadLine();
            CheckVowels(input);
            //****************************Exception on duplicate***************************//

            //List<int> numbers = new List<int>();
            //int number;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter number you want to add to the list");
            //        number = Convert.ToInt32(Console.ReadLine());

            //        if (numbers.Contains(number))
            //        {
            //            Console.WriteLine("The number is added before");
            //            numbers.Remove(number);
            //        }
            //        else
            //        {
            //            numbers.Add(number);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("The input should be an integer");
            //    }
            //} while (numbers.Count() != 0);
        }
    }
}