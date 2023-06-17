namespace stringTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, World!";
            string input1 = "ahmed";
            string reversed = ReversString(input);
            Console.WriteLine(reversed);
            int nofVowels = CountVowels(input1);
            Console.WriteLine("number of Vowels "+ nofVowels);

        }



        static int CountVowels(string input)
        {
            char[] charArray = input.ToCharArray();
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0;j<Vowels.Length; j++)
                {
                    if(charArray[i] ==Vowels[ j])
                        count++;
                }
            }
            return count;
        }

        static string ReversString(string input)
        {
            char[] charArray = input.ToCharArray();
            int start = 0;
            int end = charArray.Length-1;
            while (start < end)
            {
                char c = charArray[start];// swap characters
                charArray[start] = charArray[end];
                charArray[end] = c;
                start++;// move indicates towards the center
                end--;
            }
            return new string(charArray);
        }
    }
}