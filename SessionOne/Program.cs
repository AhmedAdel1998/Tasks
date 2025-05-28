namespace SessionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's Carpet Cleaning Service!! \n ");

            Console.WriteLine("We clean the small carpets with 25$ and the large carpets with 35$ and the sales tax rate is 6% \n ");

            double numberOfSmallCarpets = 3.0;

            double numberOfLargeCarpets = 1.0;

            double Cost = (numberOfSmallCarpets * 25) + (numberOfLargeCarpets * 35);

            double totalEstimate = Cost + (6.0 / 100.0 * Cost);

            Console.WriteLine($"The total estimate is : {totalEstimate} \n");

            Console.WriteLine("This estimate is valid for only 30 days \n ");

            //----------------------------------------------Another Solution------------------------------------------------------------//

            //Console.WriteLine("Welcome To Islam's Carpet Cleaning Service!! \n ");

            //Console.WriteLine("We clean the small carpets with 25$ and the large carpets with 35$ and the sales tax rate is 6% \n ");

            //Console.Write("Enter number of small carpets :  ");

            //double numberOfSmallCarpets = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter number of large carpets :  ");

            //double numberOfLargeCarpets = Convert.ToDouble(Console.ReadLine() );

            //double Cost = (numberOfSmallCarpets * 25) + (numberOfLargeCarpets * 35);

            //double totalEstimate = Cost + (6.0 / 100.0 * Cost);

            //Console.WriteLine($" \nThe total estimate is : {totalEstimate} \n");

            //Console.WriteLine("This estimate is valid for only 30 days \n ");
        }
    }
}
