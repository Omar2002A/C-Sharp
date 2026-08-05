using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Challenges
{
    internal class Program
    {
        public static int[] mirrorCompression(int[] numbers)
        {
            int left = 0, right = numbers.Length - 1;
            List<int> result = new List<int>();

            while (left <= right)
            {
                if (left == right)
                {
                    result.Add(numbers[left]);
                }
                else
                {
                    result.Add(numbers[left] + numbers[right]);
                }
                left++;
                right--;

            }
            return result.ToArray();
        }

        public static void frequencyWithoutCountingTwice(int[] numbers)
        {
            int maxVal = 0;
            foreach (int number in numbers)
            {
                if (number > maxVal) 
                    maxVal = number;
            }

            int[] freq = new int[maxVal + 1];
            List<int> isDone = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                freq[numbers[i]]++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!isDone.Contains(numbers[i]))
                {
                    isDone.Add(numbers[i]);
                    Console.WriteLine($"{numbers[i]} -> {freq[numbers[i]]}");
                }

                //if (freq[i] > 0)
                //{
                //    Console.WriteLine($"{i} -> {freq[i]}");
                //}
            }
        }

        public static int longestMountain(int[] numbers)
        {
            int up = 0, down = 0, maxLength = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] > numbers[i])
                {
                    if (down > 0)
                    {
                        up = 0;
                        down = 0;
                    }

                    up++;
                }
                else if (numbers[i + 1] < numbers[i])
                {
                    if (up > 0)
                    {
                        down++;

                        int currentLength = up + down + 1;

                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                        }
                    }
                }
                else
                {
                    up = 0;
                    down = 0;
                }
            }
            return maxLength;
        }

        public static bool isSorted(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void swap(int[] numbers, int firstIndex, int secondIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }

        public static void fakeSortDetector(int[] numbers)
        {
            /*if (numbers == null || numbers.Length == 0) 
            {
                Console.WriteLine("Empty !");
                return;
            }

            int[] sorted = (int[])numbers.Clone();
            Array.Sort(sorted);

            if (numbers.SequenceEqual(sorted))
            {
                Console.WriteLine("Already Sorted");
                return;
            }

            List<int> diffrentIndexes = new List<int>();
            // or can use int count 

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] != sorted[i])
                {
                    diffrentIndexes.Add(i);
                }
            }

            if (diffrentIndexes.Count != 2)
            {
                Console.WriteLine("Not Sortable By One Swap");
                return;
            }

            int[] swapped = (int[])numbers.Clone();

            int firstIndex = diffrentIndexes[0];
            int secondIndex = diffrentIndexes[1];

            int temp = swapped[firstIndex];
            swapped[firstIndex] = swapped[secondIndex];
            swapped[secondIndex] = temp;

            if (swapped.SequenceEqual(sorted))
            {
                Console.WriteLine("Almost Sorted");
            }
            else
            {
                Console.WriteLine("Not Sortable By One Swap");
            }*/

            //with out sorted!
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Empty!");
                return;
            }

            if (isSorted(numbers))
            {
                Console.WriteLine("Already Sorted");
                return;
            }

            int left = -1, right = -1;

            int minRight = numbers[numbers.Length - 1];

            for (int i = numbers.Length - 2; i >= 0; i--)
            {
                if (numbers[i] > minRight)
                {
                    left = i;
                }
                if (numbers[i] < minRight)
                {
                    minRight = numbers[i];
                }
            }

            int maxLeft = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxLeft)
                {
                    maxLeft = numbers[i];
                }
                if (numbers[i] < maxLeft)
                {
                    right = i;
                }
            }

            swap(numbers, left, right);
            bool canSorted = isSorted(numbers);
            swap(numbers, left, right);

            if (canSorted)
            {
                Console.WriteLine("Almost Sorted");
            }
            else
            {
                Console.WriteLine("Not Sortable By One Swap");
            }
        }

        public static bool circularShiftEquality(int[] numbers, int[] goal)
        {
            if (numbers == null || goal == null || numbers.Length == 0 || goal.Length == 0) 
                return false;

            if (numbers.Length != goal.Length) 
                return false;

            if (numbers.SequenceEqual(goal))
                return true;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isMatch = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int indexNumbers = (i + j) % numbers.Length;
                    if (numbers[indexNumbers] != goal[j])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch)
                    return true;
            }
            return false;
        }

        public static int balancedSplit(int[] numbers)
        {
            if (numbers == null || numbers.Length < 3)
                return -1;

            int totalSum = 0;
            foreach (int number in numbers)
                totalSum += number;

            int leftSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = totalSum - leftSum - numbers[i];

                if (leftSum == rightSum)
                    return i;

                leftSum += numbers[i];
            }
            return -1;
        }

        public static int hiddenConsecutiveChain(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            /*int[] sorted = (int[])numbers.Clone();
            Array.Sort(sorted);

            int currentLength = 1;
            int maxLength = 1;

            for (int i = 0; i < sorted.Length - 1; i++) 
            {
                if (sorted[i] == sorted[i + 1])
                    continue;

                if (sorted[i] + 1 == sorted[i + 1])
                    currentLength++;
                else
                    currentLength = 1;

                if (currentLength > maxLength) 
                    maxLength = currentLength;
                
            }
            return maxLength;*/


            HashSet<int> values = new HashSet<int>(numbers);

            int maxLength = 1;

            foreach (int number in values)
            {
                if (!values.Contains(number - 1))
                {
                    int currentNumber = number;
                    int currentLength = 1;

                    while (values.Contains(currentNumber + 1))
                    {
                        currentNumber++;
                        currentLength++;
                    }

                    if (currentLength > maxLength) 
                        maxLength = currentLength;
                }
            }
            return maxLength;
        }

        public static void reverseLevels(int[] numbers)
        {
            int index = 0, groupSize = 1;

            while (index < numbers.Length)
            {
                int end = Math.Min(index + groupSize - 1, numbers.Length - 1);

                for (int i = end; i >= index; i--)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();

                index += groupSize;
                groupSize++;
            }
        }

        public static int magicDifference(int[] numbers)
        {
            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                int greaterCount = 0, smallerCount = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        greaterCount++;
                    }
                    else if (numbers[j] < numbers[i])
                    {
                        smallerCount++;
                    }
                }
                int difference = greaterCount - smallerCount;
                maxDiffrent = Math.Max(maxDiffrent, difference);
            }
            return maxDiffrent;*/

            int min = numbers.Min();

            int minCount = numbers.Count(number => number == min);

            return numbers.Length - minCount;
        }

        public static bool zigzagValidator(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++) 
            {
                bool isUp = numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];

                bool isDown = numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1];

                if (!isUp && !isDown)
                    return false;
                
            }
            return true;
        }

        public static int[] layerRotation(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int left = 0, right = i;
                while (left < right)
                {
                    int temp = numbers[left];
                    numbers[left] = numbers[right];
                    numbers[right] = temp;
                    left++;
                    right--;
                }
            }
            return numbers;
        }

        public static void nearestGreaterDistance(int[] numbers)
        {
            /*for (int i = 0; i < numbers.Length; i++)
            {
                int distance = -1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        distance = j - i;
                        break;
                    }
                }
                Console.WriteLine(distance);
            }*/
            
            int[] answer = new int[numbers.Length];
            Stack<int> stack = new Stack<int>();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && numbers[stack.Peek()] <= numbers[i]) 
                    stack.Pop();

                answer[i] = stack.Count == 0 ? -1 : stack.Peek() - i;
                stack.Push(i);
            }

            foreach (int val in answer)
            {
                Console.WriteLine(val);
            }
        }

        public static List<int> Read()
        {
            string input = Console.ReadLine();

            return input.Split()
                        .Select(int.Parse)
                        .ToList();
        }

        public static bool Validate(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number < 0)
                    return false;
            }

            return true;
        }

        public static List<int> Transform(List<int> numbers)
        {
            numbers = numbers.Distinct().ToList();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] *= 2;
                }
            }

            numbers.Add(numbers.Sum());

            return numbers;
        }

        public static void Print(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static int PyramidCollapse(List<int> numbers)
        {
            while (numbers.Count > 2)
            {
                List<int> newList = new List<int>();

                int index = 0;
                int levelSize = 1;

                while (index < numbers.Count)
                {
                    int sum = 0;

                    for (int i = 0; i < levelSize && index < numbers.Count; i++) 
                    {
                        sum += numbers[index];
                        index++;
                    }

                    newList.Add(sum);
                    levelSize++;
                }

                numbers = newList;
            }

            return numbers.Sum();
        }

        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                if (!result.Contains(number))
                {
                    result.Add(number);
                }
            }

            return result;
        }

        public static List<int> ReverseArray(List<int> numbers)
        {
            numbers.Reverse();
            return numbers;
        }

        public static List<int> MoveEvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }

            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            //int[] numbers = { 4, 8, 2, 5};
            //int[] result = mirrorCompression(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] numbers = { 5, 3, 5, 2, 3, 3, 8 };
            //frequencyWithoutCountingTwice(numbers);

            //int[] numbers = { 1, 2, 5, 9, 6, 3, 4, 7 };
            //Console.WriteLine(longestMountain(numbers));

            //int[] numbers = { 1, 2, 5, 4, 3, 6 };
            //fakeSortDetector(numbers);

            //int[] numbers = { 2, 4, 1, 2, 4 };
            //Console.WriteLine(balancedSplit(numbers));

            //int[] numbers = { 100, 4, 200, 1, 3, 2 };
            //Console.WriteLine(hiddenConsecutiveChain(numbers));

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //reverseLevels(numbers);

            //int[] numbers = { 4, 1, 7, 3 };
            //Console.WriteLine(magicDifference(numbers));

            //int[] numbers = { 5, 2, 7, 3, 8, 1 };
            //bool isZizag = zigzagValidator(numbers);
            //Console.WriteLine(isZizag ? "YES" : "NO");

            //int[] numbers = { 1, 2, 3, 4 };
            //int[] result = layerRotation(numbers);
            //Console.WriteLine($"{string.Join(", ", result)}");

            //int[] numbers = { 1, 2, 3, 4 };
            //nearestGreaterDistance(numbers);

            //List<int> numbers = Read();
            //if (Validate(numbers))
            //{
            //    List<int> result = Transform(numbers);
            //    Print(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Console.WriteLine(PyramidCollapse(numbers));

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers = RemoveDuplicates(numbers);
            numbers = ReverseArray(numbers);
            numbers = MoveEvenNumbers(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}