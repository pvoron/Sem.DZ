﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];                                           // представление массива с длиной - 8
                        
for(int i = 0; i < array.Length; i++)                               // array.Length - длина массива
{
    array[i] = Random.Shared.Next(0, 33);                            // Вывод в массиве рандомных чисел от 0 до 2, не включая 2
    Console.Write(array[i] + " ");
}

