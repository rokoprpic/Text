namespace ConsecutiveStringN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string of numbers (eg 1-2-3..): ");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            foreach(var n in input.Split('-'))
                numbers.Add(int.Parse(n));
            var isConsecutive = true;
            for(var i=1; i<numbers.Count; i++)
            {
                if (numbers[i] != numbers[i-1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            Console.WriteLine(isConsecutive ? "Consecutive" : "Non Consecutive");
        }
    }
}