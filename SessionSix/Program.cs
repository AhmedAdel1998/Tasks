namespace SessionSix
{
    internal class Program
    {
        //************************************************************************************
        //Problem5
        //static void Grade (int grade){

        //    if (grade <40)
        //    {
        //        Console.WriteLine("Fail");
        //    }
        //    else if (grade > 40 && (grade+2) %5 ==0 && (grade + 2) - grade ==2)
        //    {
        //        grade = grade + 2;
        //        Console.WriteLine("Your grade is :" + grade);
        //    }
        //    else if (grade > 40 && (grade + 1) % 5 == 0 &&((grade + 1) - grade) == 1)
        //    {
        //        grade = grade + 1;
        //        Console.WriteLine("Your grade is :" + grade);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your grade is :" + grade);
        //    }
        //}
        //************************************************************************************
        //Problem6
        //static void socks(int[] arr)
        //{
        //    int sum = 0;
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //       
        //        for (int j = 0; j < arr.Length; j++) {
        //            if (arr[i] == arr[j])
        //            {
        //                sum++;
        //            }
        //        }
                   //Console.WriteLine(sum);
        //    }
 
        //}

        //************************************************************************************
        //problem7
        //static void candles(int[] arr)
        //{
        //    int tallest=arr.Max();
        //    int sum = 0;

        //    for (int i = 0; i < arr.Length; i++) {
        //        if (arr[i] == tallest)
        //        {
        //            sum++;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
        static void Main(string[] args)
        {

            //Problem1
            //int[] num = { 1, 2, 3, 4, 10, 11 };
            //int sum = 0;
            //for (int i = 0; i < num.Length; i++) { 
            //    sum = num[i]+sum;
            //}
            //Console.WriteLine(sum);

            //************************************************************************************
            //Problem2
            //int[] num = { 7 ,69 ,2 ,221 ,89 ,74};
            //int sum = num[0];
            //for (int i = 1; i < num.Length-1; i++)
            //{
            //    sum = num[i] + sum;
            //}
            //Console.Write(sum + " ");
            //int sum2 = num[1];

            //for (int i = 2; i < num.Length; i++)
            //{
            //    sum2 = num[i] + sum2;
            //}
            //Console.Write(sum2);

            //************************************************************************************
            //problem3
            //int[] arr1 = { 17, 28, 30};
            //int[] arr2 = { 99,16,8};
            //int Alice=0;
            //int Bob=0;

            //    if (arr1[0] == arr2[0])
            //    {
            //        Console.WriteLine("Nobody receives a point");
            //    }
            //    if (arr1[1] == arr2[1])
            //    {
            //        Console.WriteLine("Nobody receives a point");
            //    }
            //    if (arr1[2] == arr2[2])
            //    {
            //        Console.WriteLine("Nobody receives a point");
            //    }
            //    if (arr1[0] > arr2[0])
            //        {
            //           Alice = 1;

            //        }
            //if (arr1[1] > arr2[1])
            //{
            //    Alice++;

            //}
            //if (arr1[2] > arr2[2])
            //{
            //    Alice++;

            //}
            //if (arr1[0] < arr2[0])
            //    {
            //       Bob++;
            //    }
            //if ( arr1[1] < arr2[1])
            //{
            //    Bob ++;
            //}
            //if ( arr1[2] < arr2[2])
            //{
            //    Bob++;
            //}
            //Console.WriteLine($"[ {Alice} {Bob} ]");

            //************************************************************************************
            //Problem4
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //************************************************************************************
            //Problem5
            //Grade(4);
            //Grade(73);
            //Grade(67);
            //Grade(45);

            //************************************************************************************
            //Problem6
            //int[] arr = { 10, 20, 20, 10, 10, 30, 50, 10, 20 ,20,20,20 };
            //socks(arr);

            //************************************************************************************
            //Problem7
            //int[] arr = { 3, 2, 1, 3 };
            //candles(arr);

            //************************************************************************************
            //Problem8
            //int budget = 10;
            //int[] keyboards = { 3, 1 };
            //int[] drivers = { 5, 2, 8 };
            //if (keyboards[0] + drivers[0] <= budget)
            //{
            //    Console.WriteLine(keyboards[0] + drivers[0]);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
            //if (keyboards[0] + drivers[1] <= budget)
            //{
            //    Console.WriteLine(keyboards[0] + drivers[1]);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
            //if (keyboards[0] + drivers[2] <= budget)
            //{
            //    Console.WriteLine(keyboards[0] + drivers[2]);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
            //if (keyboards[1] + drivers[0] <= budget)
            //{
            //    Console.WriteLine(keyboards[0] + drivers[0]);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
            //if (keyboards[1] + drivers[1] <= budget)
            //{
            //    Console.WriteLine(keyboards[0] + drivers[0]);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
            //if (keyboards[1] + drivers[2] <= budget)
            //{
            //    Console.WriteLine(keyboards[0] + drivers[0]);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}

            //************************************************************************************
            //Problem9
            //Console.Write("Enter Password : ");
            //Console.ReadLine();
            //string Password = "";
            //if (Password != null && Password.Length >= 6 && Password.Any(char.IsUpper) && Password.Any(char.IsLower) && Password.Contains("!@#$%^&*()-+"))
            //{
            //    Console.WriteLine("Strong Password");
            //}
            //else
            //{
            //    Console.WriteLine("Your password isn't strong");
            //}

            //************************************************************************************
            //Problem10
            //int sum = 0;
            //string s = "abcacabcac";
            //for (int i=0;i<s.Length;i++)
            //{
            //    if (s[i]=='a')
            //    {
            //        sum++;
            //    }
            //}
            //Console.WriteLine(sum);
        }
    }
}

