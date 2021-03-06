﻿using System;

namespace Array10000RND
{
    /// <summary>
    /// Задание 4.1 Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
    /// значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
    /// программу, позволяющую найти и вывести количество пар элементов массива, в которых только
    /// одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
    /// элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
    /// </summary>

    class Array10000RND
    {
        static void Main(string[] args)
        {
            // Объявляем одномерный массив с 20 элементами
            int[] array = new int[20];

            // Генератор псевдо случайных чисел
            Random newRandom = new Random();

            // Заполняем массив и выводим все его элементы в консоль
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newRandom.Next(-10000, 10001);
                Console.WriteLine($"{array[i]}");
            }

            // Прощелкиваем массив по принципу: берем первый элемент + следующий и так далее.
            // Если одно из чисел в текущей паре делится на 3 без остатка, выводим пару в консоль
            for (int i = 0; i < array.Length; i++)
            {
                for (int q = i + 1; q < array.Length; q++)
                {
                    if (array[i] % 3 == 0 ^ array[q] % 3 == 0)
                    {
                        Console.WriteLine($"{array[i]} и {array[q]} - наша пара");
                    }
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}