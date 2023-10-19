namespace FindingThreeNumbersInArray
{
    internal class Program
    {
        public static void FindThreeNumbersInArray(int[] arr, int target)
        {

            bool foundCombination = false;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == target)
                        {
                            foundCombination = true;
                            Console.WriteLine($"Для получения числа {target} в заданном массиве найдены числа: {arr[i]}, {arr[j]}, {arr[k]}");
                            return;
                        }
                    }
                }
            }

            if (!foundCombination)
            {
                Console.WriteLine($"Для получения числа {target} в заданном массиве не существует трёх чисел.");
            }
        }

        static void Main(string[] args)
        {

            int[] arr1 = new int[] { -2, 10, 2, 31, 4, 10, 17, 7, 8, 9 };
            int[] arr2 = new int[] { -2, 10, 10, 17, 7, 8, 9 };
            int[] arr3 = new int[] { -2, 10, 1, 17, 7, 8, 9 };

            FindThreeNumbersInArray(arr1, 29);
            FindThreeNumbersInArray(arr2, 29);
            FindThreeNumbersInArray(arr3, 29);

            Console.ReadLine();
        }
    }
}