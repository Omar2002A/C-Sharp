using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_Loops__String__Array_
{
    internal class Program
    {
        public static void zigzagNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int j = i;
                while (j > 0)
                {
                    Console.Write(j);
                    j--;
                }
                Console.WriteLine();
            }
        }

        public static void mirrorNumberPattern(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                int spacesCount = (number - i) * 2;
                Console.Write(new string(' ', spacesCount));

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }

        public static void centeredNumberPyramid(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int spaceCount = (number - i);
                Console.Write(new string(' ', spaceCount));
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void skipNumbersPattern(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((j * 2) - 1);
                }
                Console.WriteLine();
            }
        }

        public static void rowSumPattern(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Math.Pow(2,i));
                }
                Console.WriteLine();
            }
        }

        public static void alternatingDirectionTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    for(int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void hollowPyramidNumbers(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                string space = new string(' ', number - i);
                if (i == 1)
                {
                    Console.Write(space);
                    Console.Write(1);
                    Console.WriteLine();
                    continue;
                }


                int spaceBettenInt = ((2 * i) - 1) - 2;
                string spaceBetween = new string(' ', spaceBettenInt);
                
                if (i == number)
                {
                    Console.Write(new string('1', spaceBettenInt + 2));
                    continue;
                }

                Console.Write(space);
                Console.Write(1);
                Console.Write(spaceBetween);
                Console.Write(1);
                Console.WriteLine();
            }
        }

        public static void diagonalCrossPattern(int number)
        {
            float middest = (float)number / 2;
            int mid = (int)Math.Ceiling(middest);

            for (int j = 1; j < mid; j++)
            {
                string spaceBetween = new string(' ', number - (j * 2));

                string space = new string(' ', j - 1);

                Console.Write(space);
                Console.Write(j);
                Console.Write(spaceBetween);
                Console.Write(j);
                Console.WriteLine();
            }

            if (number %2 != 0 )
                 Console.WriteLine(new string(' ', mid - 1) + mid);
            else
                Console.WriteLine(new string(' ', mid ) + mid);


            for (int j = mid + 1; j <= number; j++) 
            {
                string spaceBetween = new string(' ', ((j - mid) * 2) - 1);
                string space = new string(' ', number - j);

                Console.Write(space);
                Console.Write(j);
                Console.Write(spaceBetween);
                Console.Write(j);
                Console.WriteLine();

            }

        }

        public static void incrementalBlocks(int number)
        {
            int num = 1;
            for(int i = 1; i <= number; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.WriteLine();
            }
        }

        public static void patternWithGaps(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i == number) 
                {
                    Console.Write(1);
                    Console.Write(new string('1', i - 1));
                    Console.Write(1);
                    Console.WriteLine();
                    continue;
                }
                Console.Write(1);
                Console.Write(new string(' ', i));
                Console.Write(1);
                Console.WriteLine();
            }
        }

        public static int[] firstNonRepeatingSubarray(int[] numbers)
        {
            if(numbers ==  null || numbers.Length < 2)
            {
                return Array.Empty<int>();
            }

            List<int> uniqueNumbers = new List<int>();

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                int firstNumber = numbers[i];
                int secondNumber = numbers[i + 1];
                if(firstNumber != secondNumber)
                {
                    uniqueNumbers.Add(firstNumber);
                    uniqueNumbers.Add(secondNumber);

                    for(int j = i + 2; j < numbers.Length; j++)
                    {
                        if (uniqueNumbers.Contains(numbers[j]))
                        {
                            break;
                        }
                        uniqueNumbers.Add(numbers[j]);
                    }
                    return uniqueNumbers.ToArray();
                }
            }
            return Array.Empty<int>();
        }

        public static int[] equalDistanceElements(int[] numbers)
        {
            List<int> uniqueNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
            }

            List<int> result = new List<int>();
            List<int> indexes = new List<int>();

            foreach (int number in uniqueNumbers)
            {
                indexes.Clear();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        indexes.Add(i);
                    }
                }

                if (indexes.Count < 2)
                {
                    continue;
                }

                List<int> distances = new List<int>();

                for (int i = 0; i < indexes.Count - 1; i++)
                {
                    int distance = indexes[i + 1] - indexes[i];
                    distances.Add(distance);
                }

                bool hasEqualDistance = true;
                int firstDistance = distances[0];

                foreach (int distance in distances)
                {
                    if (distance != firstDistance)
                    {
                        hasEqualDistance = false;
                        break;
                    }
                }

                if (hasEqualDistance)
                {
                    result.Add(number);
                }
            }

            return result.ToArray();
        }

        public static List<List<int>> splitByValueChange(int[] numbers)
        {
            List<List<int>> result = new List<List<int>>();

            if (numbers.Length == 0)
            {
                return result;
            }

            List<int> currentChunk = new List<int>();
            currentChunk.Add(numbers[0]);

            for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i - 1])
                {
                    currentChunk.Add(numbers[i]);
                }
                else
                {
                    result.Add(currentChunk);

                    currentChunk = new List<int>();
                    currentChunk.Add(numbers[i]);
                }
            }
            result.Add(currentChunk);
            return result;

        }

        public static bool findAlmostSorted(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2) 
            {
                return false;
            }

            int[] sortedNumbers = (int[])numbers.Clone();
            Array.Sort(sortedNumbers);

            List<int> differentIndexes = new List<int>();

            for (int i =0; i < numbers.Length; i++)
            {
                if (numbers[i] != sortedNumbers[i])
                {
                    differentIndexes.Add(i);
                }
            }

            if (differentIndexes.Count != 2)
            {
                return false;
            }

            int firstIndex = differentIndexes.First(); //[0]
            int secondIndex = differentIndexes.Last(); //[-1 or 1] cause just have 2 indexes

            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;

            bool isSorted = true;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != sortedNumbers[i])
                {
                    isSorted = false;
                    break;
                }
            }

            temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;

            return isSorted;
        }

        public static int longestStableSegment(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            List<int> lengthOfArrays = new List<int>();

            for (int i =0; i < numbers.Length; i++)
            {
                int count = 0;
                int max = numbers[i];
                int min = numbers[i];
                
                for(int j = i; j < numbers.Length; j++)
                {
                    if(numbers[j] > max)
                    {
                        max = numbers[j];
                    }
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                    }
                    if (max - min <= 1) 
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                lengthOfArrays.Add(count);
            }
            return lengthOfArrays.Max();
        }

        public static int[] duplicateWindow(int[] numbers)
        {
            List<List<int>> windows = new List<List<int>>();
            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i]  == numbers[j])
                    {
                        List<int> window = numbers.Skip(i).Take(j - i + 1).ToList();
                        windows.Add(window);
                    }
                }
            }
            if (windows.Count == 0)
            {
                return Array.Empty<int>();
            }

            int smallestIndex = 0;

            for (int i = 1; i < windows.Count; i++)
            {
                if (windows[i].Count < windows[smallestIndex].Count)
                {
                    smallestIndex = i;
                }
            }

            return windows[smallestIndex].ToArray();
        }

        public static int[] progressiveDifference(int[] numbers)
        {
            int[] newArray = new int[numbers.Length];
            newArray[0] = numbers[0];

            for (int i = 1; i < numbers.Length; i++) 
            {
                newArray[i] = numbers[i] - numbers[i - 1];
            }
            return newArray;
        }

        public static int[] rearrangeAlternating(int[] numbers)
        {
            List<int> positives = new List<int>();
            List<int> negatives = new List<int>();

            foreach(int number in numbers)
            {
                if(number >= 0)
                {
                    positives.Add(number);
                }
                else
                {
                    negatives.Add(number);
                }
            }

            int[] result = new int[numbers.Length];

            int p = 0;
            int n = 0;
            int index = 0;

            while (p < positives.Count && n < negatives.Count)
            {
                result[index++] = positives[p++];
                result[index++] = negatives[n++];
            }

            while (p < positives.Count)
            {
                result[index++] = positives[p++];
            }

            while (n < negatives.Count)
            {
                result[index++] = negatives[n++];
            }

            return result;
        }

        public static int prefixBalancePoint(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int hiddenIncreasingSequence(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                return 0;
            }

            int[] lengths = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++) 
            {
                lengths[i] = 1;

                for (int j = 0; j < i; j++) 
                {
                    if (numbers[j] < numbers[i]) 
                    {
                        if (lengths[j] + 1 > lengths[i])
                        {
                            lengths[i] = lengths[j] + 1;
                        }
                    }
                }
            }

            int maxLength = lengths[0];

            for(int i = 0; i < lengths.Length; i++)
            {
                if(lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                }
            }
            return maxLength;
        }

        public static string removeAdjacentOpposites(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (Math.Abs(text[i] - text[i + 1]) == 32)
                {
                    text = text.Remove(i, 2);

                    i -= 2;

                    if (i < -1)
                    {
                        i = -1;
                    }
                }
            }
            return text;
        }

        public static string compressButKeepOrder(string text)
        {
            string result = "";

            List<char> wellDoneChar = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (wellDoneChar.Contains(currentChar))
                {
                    continue;
                }

                int count = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == currentChar)
                    {
                        count++;
                    }
                }

                result += currentChar;
                result += count;

                wellDoneChar.Add(currentChar);
            }
            return result;
        }

        public static string alternateCaseFix(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++) 
            {
                if(i % 2 == 0)
                {
                    result += char.ToLower(text[i]);
                }
                else
                {
                    result += char.ToUpper(text[i]);
                }
            }
            return result;
        }

        public static int countValidSubstrings(string text)
        {
            int validSubStrings = 0;

            for (int i = 0; i < text.Length; i++) 
            {
                for (int j = i; j < text.Length; j++)
                {
                    int ones = 0;
                    int zeros = 0;

                    for (int k = i; k <= j; k++)
                    {
                        if (text[k] == '0')
                        {
                            zeros++;
                        }
                        else if (text[k] == '1')
                        {
                            ones++;
                        }
                    }

                    if (zeros == ones)
                    {
                        validSubStrings++;
                    }
                }
            }
            return validSubStrings;
        }

        public static string reverseOnlyLetters(string text)
        {
            /*List<char> letters = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters.Add(text[i]);
                }
            }

            letters.Reverse();

            char[] result = new char[text.Length];

            int letterIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    result[i] = letters[letterIndex];
                    letterIndex++;
                }
                else
                {
                    result[i] = text[i];
                }
            }
            return new string(result); */

            //Two Pointers
            char[] result = text.ToCharArray();

            int left = 0;
            int right = result.Length - 1;

            while (left < right)
            {
                if (!char.IsLetter(result[left]))
                {
                    left++;
                }
                else if (!char.IsLetter(result[right]))
                {
                    right--;
                }
                else
                {
                    char temp = result[left];
                    result[left] = result[right];
                    result[right] = temp;

                    left++;
                    right--;
                }
            }
            return new string(result);
        }

        public static int longestRepeatingBlock(string text)
        {
            if (text.Length == 0) 
            {
                return 0;
            }

            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }

        public static string shiftCharacters(string text)
        {
            char[] letters = text.ToCharArray();

            for (int i = 0; i < letters.Length; i++)  
            {
                if (letters[i] == 'z')
                {
                    letters[i] = 'a';
                }
                else if (letters[i] == 'Z')
                {
                    letters[i] = 'A';
                }
                else
                {
                    letters[i]++;
                }
            }
            return new string(letters);
        }

        static bool IsPalindrome(string text, int left, int right)
        {
            while (left < right)
            {
                if (text[left] != text[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static bool removeOneToMakePalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] == text[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    bool removeLeft = IsPalindrome(text, left + 1, right);

                    bool removeRight = IsPalindrome(text, left, right - 1);

                    return removeLeft || removeRight;
                }
            }
            return false;
        }

        public static void patternDistance(string text)
        {
            List<char> wellDoneChar = new List<char>();

            for (int i = 0; i < text.Length; i++) 
            {
                char currentChar = text[i];

                if (wellDoneChar.Contains(currentChar))
                {
                    continue;
                }

                int firstIndex = i;
                int lastIndex = i;

                for (int j = text.Length - 1; j > i; j--)
                {
                    if (text[j] == currentChar)
                    {
                        lastIndex = j; 
                        break;
                    }
                }

                if (lastIndex != firstIndex)
                {
                    int distance = lastIndex - firstIndex;

                    Console.WriteLine(currentChar + " -> " + distance);
                }

                wellDoneChar.Add(currentChar);
            }
        }

        public static int splitBalancedString(string text)
        {
            if (text.Length == 0)
            {
                return 0;
            }

            int countL = 0;
            int countR = 0;
            int countParts = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'L')
                {
                    countL++;
                }
                else if (text[i] == 'R')
                {
                    countR++;
                }

                if (countL == countR)
                {
                    countParts++;
                }
            }
            return countParts;
        }

        static void Main(string[] args)
        {
            //zigzagNumber(5);
            //mirrorNumberPattern(5);
            //centeredNumberPyramid(4);
            //skipNumbersPattern(4);
            //rowSumPattern(4);
            //alternatingDirectionTriangle(6);
            //hollowPyramidNumbers(5);
            //diagonalCrossPattern(9);
            //incrementalBlocks(3);
            //patternWithGaps(4);

            //int[] numbers = { 1, 1, 2, 3, 7, 8, 9 };
            //int[] result = firstNonRepeatingSubarray(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] numbers = { 1, 2, 3, 1, 2, 4, 1, 2, 5 };
            //int[] result = equalDistanceElements(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] numbers = { 1, 1, 2, 2, 2, 4, 3, 3, 5 };
            //List<List<int>> result = splitByValueChange(numbers);
            //foreach(List<int> chunck in result)
            //{
            //    Console.WriteLine($"[{string.Join(", ", chunck)}]");
            //}

            //int[] numbers = { 3, 1, 2 };
            //bool sorted = findAlmostSorted(numbers);
            //if (sorted)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //int[] numbers = { 1, 1, 2, 3, 4, 2, 1 };
            //int result = longestStableSegment(numbers);
            //Console.WriteLine(result);

            //int[] numbers = { 1, 1, 3, 2, 2 };
            //int[] result = duplicateWindow(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] numbers = { 5, 7, 10 };
            //int[] result = progressiveDifference(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] numbers = { -1, -2, -3, -4, -5, 1, 2, 3, 45, 6 };
            //int[] result = rearrangeAlternating(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] numbers = { 1, 2, 3, 3 };
            //int result = prefixBalancePoint(numbers);
            //Console.WriteLine(result);

            //int[] numbers = { 3, 1, 2, 4, 5, 6 };
            //int result = hiddenIncreasingSequence(numbers);
            //Console.WriteLine(result);

            //string result = removeAdjacentOpposites("aAbBcC");
            //Console.WriteLine($"\"{result}\"");

            //string result = compressButKeepOrder("banana");
            //Console.WriteLine($"\"{result}\"");

            //string result = alternateCaseFix("aaBBcc");
            //Console.WriteLine($"\"{result}\"");

            //Console.WriteLine(countValidSubstrings("0101"));

            //string result = reverseOnlyLetters("a-bC-dEf-ghIj");
            //Console.WriteLine($"\"{result}\"");

            //Console.WriteLine(longestRepeatingBlock("aaabbccccd"));

            //string result = shiftCharacters("abczZ");
            //Console.WriteLine($"\"{result}\"");

            //bool result = removeOneToMakePalindrome("abca");
            //if (result)
            //    Console.WriteLine("yes");
            //else
            //    Console.WriteLine("no");

            //patternDistance("abca");

            //Console.WriteLine(splitBalancedString("LRLRLLRR"));
            
        }
    }
}
