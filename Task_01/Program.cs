namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's carpet cleaning service \nCharges :\n $25 per small \n $35 per large\n sales tax rate is 6%\nEstimates are valid for 30 days  \n");

            Console.WriteLine("please enter how many small carpets to wash : \n  ");
            int numOfSmall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter how many large carpets to wash : \n  ");
            int numOfLarge = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"number of small carpets {numOfSmall} : \n  ");
            Console.WriteLine($"number of small carpets {numOfLarge} : \n  ");


            double tax = 0.06;
            int cost = (numOfSmall * 25) + (numOfLarge * 35);
            double total = cost + (cost * tax);

            Console.WriteLine($"the cost : {cost}");
            Console.WriteLine("tax : 6%");
            Console.WriteLine($"the total : {total}");
        }
    }
}
