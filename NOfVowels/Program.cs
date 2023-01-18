namespace NOfVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word in english: ");
            var input = Console.ReadLine();
            var letters = input.ToLower().ToCharArray();
            var count = 0;
            foreach (var letter in letters)
            {
                switch(letter)
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }
            }
            Console.WriteLine(count);
        }
    }
}