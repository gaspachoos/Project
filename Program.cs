﻿// Создаем массив строк `str` случайной длины от 1 до 10.
string[] str = new string[new Random().Next(1, 11)];

// Запрашиваем ввод от пользователя  строк для каждого элемента массива `str`.
for (int i = 0; i < str.Length; i++)
{
    Console.Write($"Введите {i} элемент для массива: ");
    str[i] = Console.ReadLine()!;
}

// Создаем счетчик `j` для подсчета количества строк, длина которых меньше или равна 3.
int j = 0;

// Подсчитываем количество строк, что бы задать новому массиву размер,и наш новый массив был без пустых ячеек.
for (int i = 0; i < str.Length; i++)
{
    int Length = str[i].Length;
    if (Length <= 3)
    {
        j++;
    }
}

// Создаем новый массив `NewStr` для хранения строк, удовлетворяющих условию.
string[] NewStr = new string[j];
int x = 0;

// Копируем строки, удовлетворяющие условию, в новый массив `NewStr`.
for (int i = 0; i < str.Length; i++)
{
    int Length = str[i].Length;
    if (Length <= 3)
    {
        NewStr[x] = str[i];
        x++;
    }
}

// Выводим все строки из массива `NewStr`.
foreach (var item in NewStr)
{
    Console.Write($"[{item}] ");
}