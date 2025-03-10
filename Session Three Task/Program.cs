namespace Session_Three_Task
{
    internal class Program
    {
        static void ListOptions()
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("List Options: \n");
            Console.Write("Enter \"P\" or \"p\"  to print list items. \n");
            Console.Write("Enter \"A\" or \"a\" to add item to the list. \n");
            Console.Write("Enter \"R\" or \"r\" to remove item from the list. \n");
            Console.Write("Enter \"L\" or \"l\" to find largest value in the list. \n");
            Console.Write("Enter \"S\" or \"s\" to find smallest value in the list. \n");
            Console.Write("Enter \"M\" or \"m\" to find mean value in the list. \n");
            Console.Write("Enter \"F\" or \"f\" to find a value in the list. \n");
            Console.Write("Enter \"C\" or \"c\" to clear the list. \n");
            Console.Write("Enter \"W\" or \"w\" to swap between two numbers in list. \n");
            Console.Write("Enter \"Q\" or \"q\" to quit the program. \n \n");
            Console.Write("Enter your option: ");
        }
        static void Print(char option, List<int> numbers)
        {

            if (numbers.Count == 0)
            {
                Console.WriteLine("\n The list is empty");
            }
            else
            {
                Console.Write("Your list items : ");
                Console.Write("[");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(" " + numbers[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine("\n");
            }
        }
        static void AddToList(char option, List<int> numbers)
        {
            Console.Write("Enter the number you want to add :");
            int addedNumber = Convert.ToInt32(Console.ReadLine());
            numbers.Add(addedNumber);
            Console.Write("\n");
            Console.WriteLine("The number is added successfuly");
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int num = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = num;
                    }
                }
            }
        }
        static void RemoveFromList(char option, List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.Write("Enter the number you want to remove : ");
                int removedNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (removedNumber == numbers[i])
                    {
                        numbers.Remove(removedNumber);
                        Console.WriteLine("The number is removed successfuly");
                    }
                    else
                    {
                        Console.WriteLine("This number isn't in the list!");
                    }
                }
            }
        }
        static void DisplayLargestNumber(char option, List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.WriteLine("The Largest number is : " + numbers[numbers.Count - 1]);
            }
        }
        static void DisplaySmallestNumber(char option, List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.WriteLine("The smallest number is : " + numbers[0]);
            }
        }
        static void DisplayMeanValue(char option, List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                double sum = 0;
                double mean;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum = sum + numbers[i];
                }
                mean = sum / numbers.Count;
                Console.WriteLine("The mean is " + mean);
            }
        }
        static void FindNumber(char option, List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.Write("Write the number you want to find :  ");
                int findNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == findNumber)
                    {
                        Console.WriteLine("Your number is at index : " + i);
                    }
                    else
                    {
                        Console.WriteLine("Your number isn't in the list");
                    }
                }
            }

        }
        static void ClearList(char option, List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                numbers.Clear();
                Console.WriteLine("You cleared the list");
            }

        }
        static void SwapTwoNumbers(char option, List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.Write("Enter the index of the first number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the index of the second number : ");
                int y = Convert.ToInt32(Console.ReadLine());
                int num = numbers[x];
                numbers[x] = numbers[y];
                numbers[y] = num;
            }

        }
        static void QuitProgram(char option)
        {
            Console.WriteLine("Good bye");
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char option;
            do
            {
                ListOptions();
                option = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.Write("\n");

                switch (option)
                {
                    case 'P':
                    case 'p':
                        Print(option, numbers);
                        break;
                    case 'A':
                    case 'a':
                        AddToList(option, numbers);
                        break;
                    case 'R':
                    case 'r':
                        RemoveFromList(option, numbers);
                        break;
                    case 'L':
                    case 'l':
                        DisplayLargestNumber(option, numbers);
                        break;
                    case 'S':
                    case 's':
                        DisplaySmallestNumber(option, numbers);
                        break;
                    case 'M':
                    case 'm':
                        DisplayMeanValue(option, numbers);
                        break;
                    case 'F':
                    case 'f':
                        FindNumber(option, numbers);
                        break;
                    case 'C':
                    case 'c':
                        ClearList(option, numbers);
                        break;
                    case 'W':
                    case 'w':
                        SwapTwoNumbers(option, numbers);
                        break;
                    case 'Q':
                    case 'q':
                        QuitProgram(option);
                        break;
                    default:
                        Console.WriteLine("Select invalid character");
                        break;
                }

            } while (option != 'Q' && option != 'q');
        }
    }
}
