// Создаем массив строк `str` случайной длины от 1 до 10.
string[] str = new string[new Random().Next(1, 11)];

// Запрашиваем ввод от пользователя  строк для каждого элемента массива `str`.
for (int i = 0; i < str.Length; i++)
{
    Console.Write($"Введите {i} элемент для массива: ");
    str[i] = Console.ReadLine()!;
}
