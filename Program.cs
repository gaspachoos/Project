// Создаем массив строк `str` случайной длины от 1 до 10.
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

/*
Код написанный ниже выполняет поиск нужных нам элементов строк,только в отличии от первого кода,во втором используются 
функции и рекурсии.
Демонстрация альтернативного способа решения задачи.
*/

// // Функция для заполнения массива строк пользовательским вводом.
// string[] FillArr(string[] str, int i)
// {
//     if (i >= str.Length)
//     {
//         return str;
//     }
    
//     // Запрашиваем у пользователя ввод для элемента массива и сохраняем его в текущий элемент.
//     Console.Write($"Введите {i} элемент массива: ");
//     str[i] = Console.ReadLine()!;
    
//     // Рекурсивно вызываем FillArr для следующего элемента.
//     FillArr(str, i + 1);
    
//     // Возвращаем массив после заполнения.
//     return str;
// }

// // Функция для подсчета элементов в массиве, чей размер <= 3.
// int CountReqElements(string[] str, int index)
// {
//     if (index >= str.Length)
//     {
//         return 0;
//     }

//     // Если размер текущего элемента <= 3, увеличиваем счетчик на 1 и рекурсивно вызываем CountReqElements для следующего элемента.
//     if (str[index].Length <= 3)
//     {
//         return 1 + CountReqElements(str, index + 1);
//     }

//     // Иначе просто рекурсивно вызываем CountReqElements для следующего элемента.
//     return CountReqElements(str, index + 1);
// }

// // Функция для создания нового массива строк на основе условия и вывода на экран.
// void CreateNewString(string[] str, string[] newStr, int i, ref int j)
// {
//     if (i >= str.Length)
//     {
//         return;
//     }

//     // Если размер текущего элемента <= 3, добавляем его в новый массив и увеличиваем счетчик `j`.
//     if (str[i].Length <= 3)
//     {
//         newStr[j] = str[i];
//         Console.Write($"[{newStr[j]}] ");
//         j++; 
//     }
    
//     // Рекурсивно вызываем CreateNewString для следующего элемента.
//     CreateNewString(str, newStr, i + 1, ref j);
// }

// string[] str = FillArr(new string[new Random().Next(1, 11)], 0);

// int counter = CountReqElements(str, 0);

// string[] newStr = new string[counter];
// int j = 0;
// CreateNewString(str, newStr, 0, ref j);