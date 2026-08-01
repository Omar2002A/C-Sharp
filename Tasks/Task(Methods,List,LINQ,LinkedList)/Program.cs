using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_Methods_List_LINQ_LinkedList_
{
    internal class Program
    {
        public static List<int> evenNumbersFilter(List<int> numbers)
        {
            List<int> result = numbers.Where(n => n % 2 == 0).ToList();
            return result;
        }

        public static List<int> removeDuplicates(List<int> numbers)
        {
            List<int> result = numbers.GroupBy(n => n).Select(o => o.Key).ToList();
            // List<int> result = numbers.Distinct().ToList();
            return result;
        }

        public static int findMaximumNumber(List<int> numbers)
        {
            int result = numbers.Max();
            return result;
        }

        public static List<int> reverseList(List<int> numbers)
        {
            // numbers.Reverse();
            // return numbers;

            List<int> result = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result.Add(numbers[i]);
            }

            return result;
        }

        public static int countNumbersGreaterThanX(List<int> numbers)
        {
            int result = numbers.Count(n => n > 50);
            return result;
        }

        public static void studentScores()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Omar", 90);
            students.Add("Ahmad", 75);
            students.Add("Sara", 88);
            students.Add("Lina", 45);

            var result = students.Where(s => s.Value > 80);

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Key} has a score greater than 80. Score: {student.Value}");
            }
        }

        public static void searchByKey(Dictionary<string, int> students, string name)
        {
            if (students.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s score is {students[name]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public static int sumOfValues(Dictionary<string, int> students)
        {
            int result = students.Values.Sum();
            return result;
        }

        public static Dictionary<string, int> removeLowScores(Dictionary<string, int> students)
        {
            Dictionary<string, int> result = students
                .Where(s => s.Value >= 50)
                .ToDictionary(s => s.Key, s => s.Value);

            return result;
        }

        public static void highestScore()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Omar", 90);
            students.Add("Ali", 75);
            students.Add("Sara", 95);

            int max = students.Values.Max();

            foreach (var student in students)
            {
                if (student.Value == max)
                {
                    Console.WriteLine($"{student.Key} : {student.Value}");
                }
            }
        }

        public static LinkedList<string> addElements()
        {
            LinkedList<string> navigation = new LinkedList<string>();

            navigation.AddFirst("Home");
            navigation.AddLast("Products");
            navigation.AddLast("About");
            navigation.AddLast("Contact");

            return navigation;
        }

        public static LinkedList<string> removeMiddleElement(LinkedList<string> navigation, string valueToRemove)
        {
            navigation.Remove(valueToRemove);
            return navigation;
        }

        public static LinkedList<string> addBeforeAndAfter(LinkedList<string> navigation, string existingValue,
            string beforeValue, string afterValue)
        {
            LinkedListNode<string> currentNode = navigation.Find(existingValue);

            if (currentNode != null)
            {
                navigation.AddBefore(currentNode, beforeValue);
                navigation.AddAfter(currentNode, afterValue);
            }

            return navigation;
        }

        public static void traverseLinkedList(LinkedList<string> navigation)
        {
            foreach (string item in navigation)
            {
                Console.WriteLine(item);
            }
        }

        public static void printFirstAndLast(LinkedList<string> navigation)
        {
            if (navigation.First != null && navigation.Last != null)
            {
                Console.WriteLine($"First: {navigation.First.Value}");
                Console.WriteLine($"Last: {navigation.Last.Value}");
            }
            else
            {
                Console.WriteLine("The LinkedList is empty");
            }
        }

        public static List<int> oddNumbers(List<int> numbers)
        {
            List<int> result = numbers.Where(n => n % 2 != 0).ToList();
            return result;
        }

        public static List<int> multiplyAllNumbers(List<int> numbers)
        {
            List<int> result = numbers.Select(n => n * 2).ToList();
            return result;
        }

        public static List<int> sortDescending(List<int> numbers)
        {
            List<int> result = numbers.OrderByDescending(n => n).ToList();
            return result;
        }

        public static int firstNumberGreaterThan100(List<int> numbers)
        {
            int result = numbers.Where(n => n > 100).FirstOrDefault();

            return result;
        }

        public static double averageCalculation(List<int> numbers)
        {
            double result = numbers.Average();
            return result;
        }

        public static List<int> compareTwoLists(List<int> firstList, List<int> secondList)
        {
            List<int> result = firstList.Intersect(secondList).ToList();
            return result;
        }

        public static List<int> mergeTwoLists(List<int> firstList, List<int> secondList)
        {
            List<int> result = firstList.Concat(secondList).ToList();
            return result;
        }

        public static List<int> uniqueValuesOnly(List<int> numbers)
        {
            List<int> result = numbers
                .GroupBy(n => n)
                .Where(group => group.Count() == 1)
                .Select(group => group.Key)
                .ToList();

            return result;
        }

        public static List<int> dictionaryToList(Dictionary<string, int> students)
        {
            List<int> result = students.Values.ToList();
            return result;
        }

        public static Dictionary<string, int> filterDictionary(Dictionary<string, int> items)
        {
            Dictionary<string, int> result = items
                .Where(item => item.Value > 100)
                .ToDictionary(item => item.Key, item => item.Value);

            return result;
        }

        public static bool manualSearch(List<int> numbers, int numberToFind)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numberToFind)
                {
                    return true;
                }
            }

            return false;
        }

        public static int countEvenWithoutLINQ(List<int> numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static List<int> removeWhileLooping(List<int> numbers, int numberToRemove)
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] == numberToRemove)
                {
                    numbers.RemoveAt(i);
                }
            }

            return numbers;
        }

        public static int findSecondLargestNumber(List<int> numbers)
        {
            int largest = 0;
            int secondLargest = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber > largest)
                {
                    secondLargest = largest;
                    largest = currentNumber;
                }
                else if (currentNumber < largest && (currentNumber > secondLargest))
                {
                    secondLargest = currentNumber;
                }
            }

            return secondLargest;
        }

        public static int hiddenPatternFinder(int[] numbers)
        {
            int mostRepeated = numbers[0];
            int highestCount = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                int count = 0;

                for (int j = 0; j < numbers.Length; j++) 
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }

                if(count >  highestCount)
                {
                    highestCount = count;
                    mostRepeated = numbers[i];
                }
            }
            return mostRepeated;
        }

        public static void rotationPuzzle(int[] numbers, int steps)
        {
            steps = steps % numbers.Length;

            for (int step = 0; step < steps; step++) 
            {
                int lastNumber = numbers[numbers.Length - 1];

                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    numbers[i] = numbers[i - 1];
                }
                numbers[0] = lastNumber;
            }
        }

        public static bool mirrorCheck(int[] numbers)
        {
            int left = 0, right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] != numbers[right])
                {
                    return false;
                }

                left++;
                right--;
            }
            return true;
        }

        public static int missingNumberDetective(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++) 
            {
                if (numbers[i + 1] != numbers[i] + 1) 
                {
                    return numbers[i] + 1;
                }
            }
            return numbers[numbers.Length - 1] + 1;
        }

        public static int splitListIntoBalancedParts(int[] numbers)
        {
            int minDiffrent = int.MaxValue;
            int bestSplit = 0;

            for (int split = 1; split < numbers.Length; split++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int i = 0; i < split; i++)
                {
                    leftSum += numbers[i];
                }

                for (int i = split; i < numbers.Length; i++)
                {
                    rightSum += numbers[i];
                }

                int diffrent = Math.Abs(leftSum - rightSum);

                if (diffrent < minDiffrent)
                {
                    minDiffrent = diffrent;
                    bestSplit = split;
                }
            }
            return bestSplit;
        }

        public static List<int> longestIncreasingSequence(int[] numbers)
        {
            int currentStart = 0, currentLength = 1, bestStart = 0, bestLength = 1;

            if (numbers.Length == 0)
            {
                return new List<int>();
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStart = currentStart;
                }
            }

            List<int> result = new List<int>();

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                result.Add(numbers[i]);
            }

            return result;
        }

        public static int duplicateDistance(int[] numbers)
        {
            int shortestDistance = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i] == numbers[j])
                    {
                        if (j - i < shortestDistance)
                        {
                            shortestDistance = j - i;
                        }
                        break;
                    }
                }
            }
            return shortestDistance;
        }

        public static List<int> reorderByRule(int[] numbers)
        {

            var result = numbers.Where(n => n % 2 == 0).Concat(numbers.Where(n => n % 2 != 0)).ToList();
            //List<int> result = new List<int>();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        result.Add(numbers[i]);
            //    }
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        result.Add(numbers[i]);
            //    }
            //}

            return result;
        }

        public static List<int> peaksFinder(int[] numbers)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) 
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }

        public static void twoSum(int[] numbers, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int need = target - numbers[i];

                if (values.ContainsKey(need))
                {
                    Console.WriteLine($"{need} + {numbers[i]} = {target}");
                    return;
                }
                values.Add(numbers[i], i);
            }
            Console.WriteLine("Not Found");
        }

        public static void shiftZeros(int[] numbers)
        {
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    numbers[index] = numbers[i];
                    index++;
                }
            }

            while (index < numbers.Length)
            {
                numbers[index] = 0;
                index++;
            }
        }

        public static List<int> alternatingMerge(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();

            int maxLength = Math.Max(arr1.Length, arr2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < arr1.Length)
                {
                    result.Add(arr1[i]);
                }
                if (i < arr2.Length)
                {
                    result.Add(arr2[i]);
                }
            }
            return result;
        }

        public static void countFrequenciesWithoutDictionary(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isCounted = false;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isCounted = true;
                        break;
                    }
                }

                if (isCounted)
                {
                    continue;
                }

                int count = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{numbers[i]} -> {count}");
            }
        }

        public static int findSecondMaximum(int[] numbers)
        {
            int max = int.MinValue, secondMax = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    secondMax = max;
                    max = numbers[i];
                }
                else if (numbers[i] > secondMax && numbers[i] != max)
                {
                    secondMax = numbers[i];
                }
            }
            return secondMax;
        }

        public static bool subarraySum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    sum+=numbers[j];

                    if (sum == target)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void reverseOnlyPart(int[] numbers, int start, int end)
        {
            while (start < end)
            {
                int temp = numbers[start];
                numbers[start] = numbers[end];
                numbers[end] = temp;

                start++;
                end--;
            }
        }

        public static int minimalSwapsToSort(int[] numbers)
        {
            int swaps = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[minIndex];
                    numbers[minIndex] = temp;
                    
                    swaps++;
                }
            }
            return swaps;
        }

        public static List<int> trickyReordering(int[] numbers)
        {
            List<int> sortedNumber = numbers.OrderBy(n => n).ToList();
            List<int> result = new List<int>();

            int left = 0, right = sortedNumber.Count - 1;

            while (left <= right)
            {
                result.Add(sortedNumber[left]);
                left++;

                if (left <= right)
                {
                    result.Add(sortedNumber[right]);
                    right--;
                }
            }
            return result;
        }

        public static List<int> longestRepeatedPattern(int[] numbers)
        {
            int longest = 0, start = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int length = 0;

                    while (j + length < numbers.Length && numbers[i + length] == numbers[j + length] && i + length < j) 
                    {
                        length++;

                        if (i + length >= j)
                        {
                            break;
                        }
                    }

                    if (length > longest)
                    {
                        longest = length;
                        start = i;
                    }
                }
            }

            List<int> result = new List<int>();

            for (int i = start; i < start + longest; i++)
            {
                result.Add(numbers[i]);
            }

            return result;
        }

        public static List<int> removeNumber(int[] numbers, int numberToRemove)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numberToRemove)
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            // List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            // Console.WriteLine(string.Join(", ", evenNumbersFilter(numbers1)));

            // List<int> numbers2 = new List<int> { 1, 7, 7, 3, 4, 3, 5, 1 };
            // Console.WriteLine(string.Join(", ", removeDuplicates(numbers2)));

            // Console.WriteLine(findMaximumNumber(numbers2));
            // Console.WriteLine(string.Join(", ", reverseList(numbers2)));

            // List<int> numbers3 = new List<int> { 51, 57, 67, 73, 4, 3, 5, 1 };
            // Console.WriteLine(countNumbersGreaterThanX(numbers3));

            // studentScores();

            //Dictionary<string, int> students = new Dictionary<string, int>
            // {
            //     { "Omar", 90 },
            //     { "Ahmad", 45 },
            //     { "Sara", 88 }
            // };

            // searchByKey(students, "Omar");
            // Console.WriteLine(sumOfValues(students));

            // Dictionary<string, int> passedStudents = removeLowScores(students);
            // foreach (var student in passedStudents)
            // {
            //     Console.WriteLine($"{student.Key}: {student.Value}");
            // }

            //highestScore();

            //LinkedList<string> navigation = addElements();
            //removeMiddleElement(navigation, "About");
            //addBeforeAndAfter(navigation, "Products", "Categories", "Cart");
            //traverseLinkedList(navigation);
            //printFirstAndLast(navigation);

            //List<int> linqNumbers = new List<int> { 1, 2, 3, 4, 101, 6, 150 };
            // Console.WriteLine(string.Join(", ", oddNumbers(linqNumbers)));
            // Console.WriteLine(string.Join(", ", multiplyAllNumbers(linqNumbers)));
            // Console.WriteLine(string.Join(", ", sortDescending(linqNumbers)));

            //int firstLargeNumber = firstNumberGreaterThan100(linqNumbers);
            //Console.WriteLine(firstLargeNumber == null ? "Not found" : firstLargeNumber.ToString());

            // Console.WriteLine(averageCalculation(linqNumbers));

            // List<int> firstList = new List<int> { 1, 2, 3, 4 };
            // List<int> secondList = new List<int> { 3, 4, 5, 6 };
            // Console.WriteLine(string.Join(", ", compareTwoLists(firstList, secondList)));
            // Console.WriteLine(string.Join(", ", mergeTwoLists(firstList, secondList)));

            // List<int> repeatedNumbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            // Console.WriteLine(string.Join(", ", uniqueValuesOnly(repeatedNumbers)));

            // Dictionary<string, int> products = new Dictionary<string, int>
            // {
            //     { "Laptop", 700 },
            //     { "Mouse", 20 },
            //     { "Keyboard", 120 }
            // };

            // Console.WriteLine(string.Join(", ", dictionaryToList(products)));

            // Dictionary<string, int> expensiveProducts = filterDictionary(products);
            // foreach (var product in expensiveProducts)
            // {
            //     Console.WriteLine($"{product.Key}: {product.Value}");
            // }

            // List<int> thinkingNumbers = new List<int> { 1, 2, 2, 3, 4, 6, 8 };
            // Console.WriteLine(manualSearch(thinkingNumbers, 3));
            // Console.WriteLine(countEvenWithoutLINQ(thinkingNumbers));
            // Console.WriteLine(string.Join(", ", removeWhileLooping(thinkingNumbers, 2)));
            // Console.WriteLine(findSecondLargestNumber(thinkingNumbers));

            int[] numbers = { 1, 2, 3, 45, 5, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 4, 4, 4, 4, 4, 4, 4 };

            //int result = hiddenPatternFinder(numbers);
            //Console.WriteLine(result);

            //rotationPuzzle(numbers, 2);
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] number = { 1, 2, 4, 5 };
            //int result = missingNumberDetective(number);
            //Console.WriteLine(result);

            //int splitIndex = splitListIntoBalancedParts(numbers);
            //Console.WriteLine(splitIndex);

            //List<int> result = longestIncreasingSequence(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] numbers1 = { 5, 1, 2, 5, 3, 5 };
            //Console.WriteLine(duplicateDistance(numbers1));

            //List<int> result = reorderByRule(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //List<int> result = peaksFinder(numbers);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] number = { 2, 7, 11, 15 };
            //twoSum(number, 9);

            //int[] number = { 0, 1, 0, 3, 12 };
            //shiftZeros(number);
            //Console.WriteLine($"[{string.Join(", ", number)}]");

            //int[] array1 = { 1, 2, 3 };
            //int[] array2 = { 4, 5, 6, 9, 1 };
            //List<int> result = alternatingMerge(array1, array2);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //countFrequenciesWithoutDictionary(numbers);

            //Console.WriteLine(findSecondMaximum(numbers));

            //int[] number = { 1, 2, 3, 7, 5 };
            //Console.WriteLine(subarraySum(number, 12));

            //int[] number = { 1, 2, 3, 4, 5 };
            //reverseOnlyPart(number, 1, 3);
            //Console.WriteLine($"[{string.Join(", ", number)}]");

            //int[] number = { 4, 3, 2, 1 };
            //int result = minimalSwapsToSort(number);
            //Console.WriteLine($"Swaps: {result}");
            //Console.WriteLine($"[{string.Join(", ", number)}]");

            //int[] number = { 4, 1, 6, 2, 5, 3 };
            //List<int> result = trickyReordering(number);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] number = { 1, 2, 3, 1, 2, 3, 4 };
            //List<int> result = longestRepeatedPattern(number);
            //Console.WriteLine($"[{string.Join(", ", result)}]");

            //int[] number = { 1, 2, 3, 2, 4, 2, 5 };
            //List<int> result = removeNumber(number, 2);
            //Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}