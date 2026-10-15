using System;

namespace Practice7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1

            Console.Write("Введите первую границу диапазона: ");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вторую границу диапазона: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            double min = Math.Min(input1, input2);
            double max = Math.Max(input1, input2);

            double number;
            do
            {
                Console.Write($"Введите число в диапазоне от {min} до {max}: ");
                number = Convert.ToDouble(Console.ReadLine());

                if (number < min || number > max)
                {
                    Console.WriteLine("Число не входит в диапазон. Попробуйте еще раз.");
                }
            }
            while (number < min || number > max);

            Console.WriteLine($"Успешно! Вы ввели число: {number}");


            // task 2

            List<Product> catalog = new List<Product>
            {
                new Product("Искусственная елка", 4500.0, 5),
                new Product("Набор стеклянных шаров", 850.0, 15),
                new Product("Новогодняя гирлянда (10м)", 600.0, 20),
                new Product("Мишура блестящая", 120.0, 50),
                new Product("Звезда на верхушку елки", 450.0, 8)
            };

            double totalStoreRevenue = 0; 
            bool keepWorking = true;

            Console.WriteLine("=== ДОБРО ПОЖАЛОВАТЬ В НОВОГОДНИЙ МАГАЗИН ===");

            while (keepWorking)
            {
                Console.WriteLine("\n--- НОВЫЙ ПОКУПАТЕЛЬ ---");
                double cartSum = 0; 
                bool shopping = true;

                while (shopping)
                {
                    Console.WriteLine("\nСписок доступных товаров:");
                    for (int i = 0; i < catalog.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {catalog[i].Name} — {catalog[i].Price} руб. (В наличии: {catalog[i].Stock} шт.)");
                    }
                    Console.WriteLine("0. Завершить выбор товаров и перейти к оплате");

                    int choice;
                    while (true)
                    {
                        Console.Write("Выберите номер товара (или 0): ");
                        if (int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= catalog.Count)
                        {
                            break;
                        }
                        Console.WriteLine("Ошибка! Введите корректный номер из списка.");
                    }

                    if (choice == 0)
                    {
                        shopping = false;
                        continue;
                    }

                    Product selectedProduct = catalog[choice - 1];

                    if (selectedProduct.Stock == 0)
                    {
                        Console.WriteLine($"Извините, {selectedProduct.Name} закончился!");
                        continue;
                    }

                    int quantity;
                    while (true)
                    {
                        Console.Write($"Введите количество для '{selectedProduct.Name}' (доступно {selectedProduct.Stock} шт.): ");
                        if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        {
                            if (quantity <= selectedProduct.Stock)
                            {
                                break;
                            }
                            Console.WriteLine($"Ошибка! На складе нет такого количества. Максимум: {selectedProduct.Stock}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Введите целое число больше 0.");
                        }
                    }

                    double itemTotal = selectedProduct.Price * quantity;
                    cartSum += itemTotal;
                    selectedProduct.Stock -= quantity;

                    Console.WriteLine($"Добавлено: {selectedProduct.Name} x{quantity} на сумму {itemTotal} руб.");
                }

                if (cartSum == 0)
                {
                    Console.WriteLine("Чек пуст. Покупатель ушел без покупок.");
                }
                else
                {
                    double discountPercentage = 0;
                    if (cartSum >= 5000) discountPercentage = 10; 
                    else if (cartSum >= 2000) discountPercentage = 5; 

                    double discountAmount = cartSum * (discountPercentage / 100);
                    double finalSum = cartSum - discountAmount;

                    Console.WriteLine("\n======= ЧЕК =======");
                    Console.WriteLine($"Сумма покупок: {cartSum} руб.");
                    if (discountPercentage > 0)
                    {
                        Console.WriteLine($"Ваша скидка ({discountPercentage}%): -{discountAmount} руб.");
                    }
                    Console.WriteLine($"ИТОГО К ОПЛАТЕ: {finalSum} руб.");
                    Console.WriteLine("===================");

                    totalStoreRevenue += finalSum;
                }

                Console.Write("\nОбслужить следующего клиента? (да/нет): ");
                string answer = Console.ReadLine()!.Trim().ToLower();
                if (answer != "да" && answer != "y" && answer != "д")
                {
                    keepWorking = false;
                }
            }

            Console.WriteLine("\n=== СМЕНА ЗАВЕРШЕНА ===");
            Console.WriteLine($"Общая выручка магазина за день: {totalStoreRevenue} руб.");
            Console.WriteLine("Спасибо за работу! С Наступающим!");
        }
    }
}
