using System.Linq.Expressions;

namespace day4
{
    class arrayento
    {
        public static void Main(string[] args)
        {
            //Reading and writing of array using diff 
            Console.WriteLine("Enter the size of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Enter the elements of array1");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You entered  showing using string.array array1 ");
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine("you entered showing using foreach");
            foreach (int num in arr1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("SHowing using Array.ConvertAll");
            Console.WriteLine($"Enter {n} of elements only (Space separated)");
            while (true)
            //Array.convertAll(Console.ReadLine().Split(),int.parse);
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length != n)
                {

                    Console.WriteLine($" invalid : Enter only {n} numbers");
                    // return;
                    continue;
                }
                try
                {
                    arr1 = Array.ConvertAll(input, int.Parse);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format enter only numbers:");

                }
            }

            Console.WriteLine(string.Join(" ", arr1));




            //Sum & Average of array elements.
            Console.WriteLine("Sum of array of elements:");
            Console.WriteLine("Enter the size and elements of an array(space separated");
            int sumsize = Convert.ToInt32(Console.ReadLine());
            int[] sum1 = new int[sumsize];
            sum1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum = 0;

            foreach (int num in sum1)
            {
                sum += num;

            }
            int avg = sum / sumsize;
            Console.WriteLine($"Sum of array:{sum}");
            Console.WriteLine($"Average or array:{avg}");
            //find max and min
            Console.WriteLine($"finding max min in :{String.Join(" ", sum1)}");
            int max = sum1[0];
            int min = sum1[0];
            foreach (int maxmin in sum1)
            {
                if (maxmin > max)

                    max = maxmin;



                if (maxmin < min)

                    min = maxmin;

            }
            Console.WriteLine($"max of array is {max}");
            Console.WriteLine($"min of array is {min}");
            //Reverse of array
            Console.WriteLine($"finding reverse of in :{String.Join(" ", sum1)}");
            int[] reverse = new int[sumsize];
            for (int i = 0; i < sumsize; i++)
            {
                reverse[i] = sum1[sumsize - 1 - i];
            }
            Console.WriteLine(String.Join(" ", reverse));

            int[] reverse2 = { 1, 2, 3, 4, 5, 6 };
            int reversize = reverse2.Length;
            Console.WriteLine(String.Join(" ", reverse2));
            for (int i = 0; i < reversize / 2; i++)
            {
                int temp = reverse2[i];
                reverse2[i] = reverse2[reversize - 1 - i];
                reverse2[reversize - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(" ", reverse2));
            Console.WriteLine(string.Join(" ", reverse2.Reverse()));
            //Count vowels and consonants in a string.
             Console.WriteLine("enter a string to Count vowels and consonants");
            string VowelsConst = Console.ReadLine();
            // char[] converchar = VowelsConst.ToCharArray();
            int countvowel = 0;
            int countconst = 0;
            foreach (char c in VowelsConst)
            {
                if (char.IsLetter(c))
                {
                    char charletters = char.ToLower(c);
                    //Console.Write(c+" ");
                    //Console.Write($"{charletters}");
                    if ("aeiou".Contains(charletters))
                    {
                        Console.WriteLine($"{charletters} is a vowel");
                        countvowel++;
                    }
                    else
                    {
                        Console.WriteLine($"{charletters} is a constant");
                        countconst++;
                    }
                }

            }
            Console.WriteLine($"Vowels count in {VowelsConst} is :{countvowel}");
            Console.WriteLine($"Constants count in {VowelsConst} is :{countconst}");
            //Check if a string is palindrome(same forward &backward).
            Console.WriteLine("Enter string to check palindrome or not");
            string palin = Console.ReadLine();
            int sizepal = palin.Length;
            //  char[] palinst = palin.ToCharArray();
            bool ispalindrome = true;
            for (int i = 0; i < sizepal / 2; i++)
            {
                // char plainlet = char.ToLower(i);
                if (char.ToLower(palin[i]) != char.ToLower(palin[sizepal - 1 - i]))
                {
                    ispalindrome = false;
                    break;
                }
            }
            if (ispalindrome)
            {

                Console.WriteLine($"Enteres {palin} is palindrome");
            }
            else
            {
                Console.WriteLine($"Enteres {palin} is not palindrome");
            }
            //Count words in a sentence (using Split).
            Console.WriteLine("Enter the sentence to count the number of workds");
            string wordsent = Console.ReadLine();
            string[] countoword = wordsent.Split(' ');
            int nowords= countoword.Length; 
            foreach(string c in countoword)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"Number of words in the {wordsent} is :{nowords}");

        }
    }
}

