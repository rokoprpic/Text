namespace SentanceToPascalCWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence seperated by whitespace: ");
            var input = Console.ReadLine();
            try
            {
                var pascalSentence = "";
                foreach (var word in input.Split(' '))
                {
                    var pascalWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                    pascalSentence += pascalWord;
                }
                Console.WriteLine(pascalSentence);
            } catch (Exception ex)
            {
                Console.WriteLine("Wring input");
            }
        }
    }
}