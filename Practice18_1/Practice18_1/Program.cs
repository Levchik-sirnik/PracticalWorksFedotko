using System;

namespace Practice18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[] sourceArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] targetShape = { 2, 3, 2 }; // 3D-массив размером 2x3x2

            try
            {
                Array result = ReshapeArray(sourceArray, targetShape);
            
                // Выведем элемент для проверки: результат[1, 2, 0]
                Console.WriteLine($"Элемент по индексу: {result.GetValue(1, 2, 0)}"); // Должно быть 11
                Console.WriteLine("Массив успешно преобразован!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


            // task 2
            const int totalStudents = 5;
            string[] lastNames = new string[totalStudents];

            Console.WriteLine($"Введите фамилии {totalStudents} студентов:");

            // 1. Ввод фамилий с базовой проверкой
            for (int i = 0; i < totalStudents; i++)
            {
                while (true)
                {
                    Console.Write($"Студент {i + 1}: ");
                    string input = Console.ReadLine()?.Trim()!;

                    if (!string.IsNullOrEmpty(input))
                    {
                        lastNames[i] = input;
                        break; // Ввод корректен, переходим к следующему
                    }

                    Console.WriteLine("Ошибка: фамилия не может быть пустой. Попробуйте еще раз.");
                }
            }

            // 2. Поиск самой длинной фамилии
            string longestName = lastNames[0];

            for (int i = 1; i < lastNames.Length; i++)
            {
                if (lastNames[i].Length > longestName.Length)
                {
                    longestName = lastNames[i];
                }
            }

            // 3. Вывод результата
            Console.WriteLine("\nРезультаты анализа:");
            Console.WriteLine($"Самая длинная фамилия: {longestName} (длина: {longestName.Length} симв.)");
        }

        public static Array ReshapeArray(Array source, int[] shape)
        {
            // 1. Проверка на null
            if (source == null)
                throw new ArgumentNullException(nameof(source), "Исходный массив не может быть null.");

            if (shape == null)
                throw new ArgumentNullException(nameof(shape), "Параметр shape не может быть null.");

            // 2. Проверка размерности исходного массива
            if (source.Rank != 1)
                throw new ArgumentException("Исходный массив должен быть строго одномерным.", nameof(source));

            // 3. Проверка корректности целевой формы (N-мерности)
            if (shape.Length == 0)
                throw new ArgumentException("Форма массива должна содержать хотя бы одно измерение.", nameof(shape));

            long totalElements = 1;
            foreach (int dimension in shape)
            {
                if (dimension <= 0)
                {
                    throw new ArgumentException("Размерность каждого измерения должна быть больше 0.", nameof(shape));
                }
                totalElements *= dimension;
            }

            // 4. Проверка совпадения количества элементов
            if (source.Length != totalElements)
            {
                throw new ArgumentException($"Несовпадение количества элементов. " +
                    $"В исходном массиве: {source.Length}, требуется для новой формы: {totalElements}.");
            }

            // 5. Создание нового N-мерного массива нужного типа и формы
            Type elementType = source.GetType().GetElementType()!;
            Array targetArray = Array.CreateInstance(elementType, shape);

            // 6. Заполнение N-мерного массива данными
            int[] indices = new int[shape.Length];

            for (int i = 0; i < source.Length; i++)
            {
                // Устанавливаем значение по вычисленным многомерным индексам
                targetArray.SetValue(source.GetValue(i), indices);

                // Сдвигаем индексы для следующего элемента (аналог смещения в N-мерном пространстве)
                IncrementIndices(indices, shape);
            }

            return targetArray;
        }

        private static void IncrementIndices(int[] indices, int[] shape)
        {
            for (int i = indices.Length - 1; i >= 0; i--)
            {
                indices[i]++;
                if (indices[i] < shape[i])
                {
                    break; // Сдвиг успешно выполнен
                }
                indices[i] = 0; // Перенос разряда в старшее измерение
            }
        }
    }
}
