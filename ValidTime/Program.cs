namespace ValidTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter time 00:00 - 23:59: ");
            var input = Console.ReadLine();
            var hour_minute = input.Split(':');
            try
            {
                var h = int.Parse(hour_minute[0]);
                var min = int.Parse(hour_minute[1]);
                if (h >= 0 && h <= 23 && min >= 0 && min <= 59)
                    Console.WriteLine("OK time");
                else
                    Console.WriteLine("Invalid time");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid time");
            }
        }
    }
}