using System;

namespace Domasno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter a string");
            FunWithStrings(Console.ReadLine());
            string stringWithSpaces = "The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            removeSpaces(stringWithSpaces);
        }
        static void FunWithStrings(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));

            
            int i, len, vowel;

            Console.WriteLine("----------------------------------------------");


            vowel = 0;

            len = inputString.Length;

            for (i = 0; i < len; i++)
            {

                if (inputString[i] == 'a' || inputString[i] == 'e' || inputString[i] == 'i' || inputString[i] == 'o' || inputString[i] == 'u' || inputString[i] == 'A' || inputString[i] == 'E' || inputString[i] == 'I' || inputString[i] == 'O' || inputString[i] == 'U')
                {
                    vowel++;
                }
            }
            Console.WriteLine("The total number of vowel in the string is : ");
            Console.WriteLine(vowel);

            Console.WriteLine("----------------------------------------------");

           
            string firstHalf = inputString.Substring(0, inputString.Length / 2);
            char[] arr = inputString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);
            bool palindrome;

            if (firstHalf.Equals(secondHalf)) palindrome = true;
            else palindrome = false;
            
            Console.WriteLine("Is the string a Palindrome: ", palindrome);

            Console.WriteLine("----------------------------------------------");

            string[] words = inputString.Split(new[] { " " }, StringSplitOptions.None);
            string wordL = "";
            string wordS = "";
            int ctrL = 0;
            int ctrS = 0;
            foreach (String l in words)
            {
                if (l.Length > ctrL)
                {
                    wordL = l;
                    ctrL = l.Length;
                }
            }
            Console.WriteLine("The longest word is: ");
            Console.WriteLine(wordL);
            Console.WriteLine("----------------------------------------------");
            foreach (String s in words)
            {
                if (s.Length <= ctrS)
                {
                    wordS = s;
                    ctrS = s.Length;
                }
            }
            Console.WriteLine("The shortest word is: ");
            Console.WriteLine(wordS);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("the number of words is: ");
            Console.WriteLine(words.Length-1);
            Console.WriteLine("----------------------------------------------");

            int[] count = new int[256];
            int max = 0;
            Char result = Char.MinValue;
            Array.Clear(count, 0, count.Length - 1);
            foreach(char c in inputString)
            {
                if (c != ' ' && ++count[c] > max)
                {
                    max = count[c];
                    result = c;
                }
            }
            Console.WriteLine("most repeted character is '{0}': ", result);
            Console.WriteLine("----------------------------------------------");

        }
        static void removeSpaces(string inputString2)
        {
            string s = inputString2;
            string s1 = s.Replace("  ", " ");
            string s2 = s1.Replace("  ", " ");
            string s3 = s2.Replace("  ", " ");

            Console.WriteLine(s3);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
