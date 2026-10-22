using System;

namespace Practice9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[] arr = { 6, 34, 1, -4, 5, 786, -67, 0, 23, 45 };
            Console.WriteLine("Original array: " + string.Join(", ", arr));
            BubbleSort(arr);
            Console.WriteLine("Sorted array by bubble sort: " + string.Join(", ", arr));


            // task 2
            int[] arr2 = { 6, 34, 1, -4, 5, 786, -67, 0, 23, 45 };
            Console.WriteLine("Original array: " + string.Join(", ", arr2));
            InsertionSort(arr2);
            Console.WriteLine("Sorted array by insertion sort: " + string.Join(", ", arr2));

            // task 3
            int[] grades = new int[10];

            Console.WriteLine("Enter 10 grades (1-12):");

            for (int i = 0; i < grades.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Grade {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int inputGrade) && inputGrade >= 1 && inputGrade <= 12)
                    {
                        grades[i] = inputGrade;
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a grade between 1 and 12.");
                }
            }

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Grades output");
                Console.WriteLine("2. Exam retake");
                Console.WriteLine("3. Scholarship checking");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine()!;
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        DisplayGrades(grades);
                        break;
                    case "2":
                        RetakeExam(grades);
                        break;
                    case "3":
                        CheckScholarship(grades);
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }


            // task 4
            int[] arr3 = { 6, 34, 1, -4, 5, 786, -67, 0, 23, 45 };
            Console.WriteLine("Original array: " + string.Join(", ", arr3));
            SelectionSort(arr3);
            Console.WriteLine("Sorted array by selection sort: " + string.Join(", ", arr3));


            // task 5
            int[] numbers = { 5, -2, 10, -8, 3, 1, 7, -4, 12, 0, 9, -1 };
            Console.WriteLine("Original array: " + string.Join(", ", numbers));
            ProcessArray(numbers);
            Console.WriteLine("Processed array: " + string.Join(", ", numbers));
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
                }
            }
        }

        static void DisplayGrades(int[] grades)
        {
            Console.WriteLine("Current student grades:");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Exam {i + 1}: {grades[i]}");
            }
        }

        static void RetakeExam(int[] grades)
        {
            int index = 0;
            int newGrade = 0;

            while (true)
            {
                Console.Write($"Enter number of exam to retake it (1-{grades.Length}): ");
                if (int.TryParse(Console.ReadLine(), out index) && index >= 1 && index <= grades.Length)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid exam number.");
            }

            while (true)
            {
                Console.Write($"Enter new grade for exam {index} (1-12): ");
                if (int.TryParse(Console.ReadLine(), out newGrade) && newGrade >= 1 && newGrade <= 12)
                {
                    grades[index - 1] = newGrade;
                    Console.WriteLine($"Exam {index} grade updated to {newGrade}.");
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a grade between 1 and 12.");
            }
        }

        static void CheckScholarship(int[] grades)
        {
            int sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            double average = (double)sum / grades.Length;
            if (average >= 10.7)
            {
                Console.WriteLine($"Average grade: {average:F2}. Student is eligible for a scholarship.");
            }
            else
            {
                Console.WriteLine($"Average grade: {average:F2}. Student is not eligible for a scholarship.");
            }
        }

        static void ProcessArray(int[] arr)
        {
            if (arr == null || arr.Length == 0) return;

            double avg = arr.Average();

            int thirdIndex = arr.Length / 3;
            int sortLength = (avg > 0) ? thirdIndex * 2 : thirdIndex;

            int reverseLength = arr.Length - sortLength;

            Array.Sort(arr, 0, sortLength);

            Array.Reverse(arr, sortLength, reverseLength);
        }



    }
}   
