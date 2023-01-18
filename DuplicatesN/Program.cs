namespace DuplicatesN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string of numbers seperated by '-': ");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            foreach (var n in input.Split('-'))
                numbers.Add(int.Parse(n));
            var isDuplicate = false;
            numbers.Sort();
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    isDuplicate = true;
                    break;
                }
            }
            Console.WriteLine(isDuplicate ? "Duplicates" : "No Duplicates");
        }
    }
}