namespace SessionTwo___List_Task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char option;
            do
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("List Options: \n");
                Console.Write("Enter \"P\" or \"p\"  to print list items. \n");
                Console.Write("Enter \"A\" or \"a\" to add item to the list. \n");
                Console.Write("Enter \"R\" or \"r\" to remove item from the list. \n");
                Console.Write("Enter \"L\" or \"l\" to find largest value in the list. \n");
                Console.Write("Enter \"S\" or \"s\" to find smallest value in the list. \n");
                Console.Write("Enter \"M\" or \"m\" to find mean value in the list. \n");
                Console.Write("Enter \"F\" or \"f\" to find mean value in the list. \n");
                Console.Write("Enter \"C\" or \"c\" to clear the list. \n");
                Console.Write("Enter \"W\" or \"w\" to clear the list. \n");
                Console.Write("Enter \"Q\" or \"q\" to quit the program. \n \n");
                Console.Write("Enter your option: ");
                option = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.Write("\n");
                if (option == 'P' || option == 'p')
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
                if (option == 'A' || option == 'a')
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
                if (option == 'R' || option == 'r')
                {
                    Console.Write("Enter the number you want to remove : ");
                    int removedNumber = Convert.ToInt16(Console.ReadLine());
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
                if (option == 'L' || option == 'l')
                {

                    Console.WriteLine("The Largest number is : " + numbers[numbers.Count - 1]);

                }
                if (option == 'S' || option == 's')
                {

                    Console.WriteLine("The smallest number is : " + numbers[0]);

                }
                if (option == 'M' || option == 'm')
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
                if (option == 'F' || option == 'f')
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
                if (option == 'C' || option == 'c')
                {
                    numbers.Clear();
                    Console.WriteLine("You cleared the list");
                }

                if (option == 'W' || option == 'w')
                {
                    Console.Write("Enter the index of the first number : ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enterthe index of the second number : ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int num = numbers[x];
                    numbers[x] = numbers[y];
                    numbers[y] = num;
                }
                if (option == 'Q' || option == 'q')
                {
                    Console.WriteLine("Good bye");
                }

            } while (option != 'q' && option != 'Q');
        }
    }
}

