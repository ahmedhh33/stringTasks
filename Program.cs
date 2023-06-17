namespace stringTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";
            string input1 = "ahmed";
            string reversed = ReversString(input);// EX1
            Console.WriteLine("The revesed chars in words is  "+reversed);
            Console.WriteLine("****************************************");
            int nofVowels = CountVowels(input1);//EX2
            Console.WriteLine("number of Vowels is " + nofVowels);
            Console.WriteLine("****************************************");


            string reversedword = Reverse(input);//EX3
            Console.WriteLine(" the reversed word sentence is "+reversedword);
            Console.WriteLine("****************************************");

        }



        static int CountVowels(string input)//EX2 COUNTING vowels
        {
            char[] charArray = input.ToCharArray();
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < Vowels.Length; j++)
                {
                    if (charArray[i] == Vowels[j])
                        count++;
                }
            }
            return count;
        }

        static string ReversString(string input)// EX1 REVERS CHARS OF WORDS
        {
            char[] charArray = input.ToCharArray();
            int start = 0;
            int end = charArray.Length - 1;
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

        public static string Reverse(string sentence)//EX3 REVERSE WPRDS IN SENTENCE
        {
            // Split the sentence into an array of words.
            string[] wordsArray = sentence.Split(' ');

            int start = 0;
            int end = wordsArray.Length - 1;
            while (start < end)
            {
                string c = wordsArray[start];// swap characters
                wordsArray[start] = wordsArray[end];
                wordsArray[end] = c;
                start++;// move indicates towards the center
                end--;
            }

            //Join the words back together into a string.
            string reversedSentence = string.Join(" ", wordsArray);
            return reversedSentence;

        }
    }
}