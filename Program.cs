// ══════════════════════════════════ Главное меню и основные функции ══════════════════════════════════

int choice = 1; // ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
// Список меню
string[] ListMenu = {
    "  Задача 54: Отсортировать строки массива по убыванию.                    ",
    "  Задача 56: Строка массива с минимальной суммой.                         ",
    "  3 Пункт меню                                                            ",
    "  Задача 60: Сгенерировать трехмерный массив.                             ",
    "  5 Пункт меню                                                            ",
    "  ВЫХОД ИЗ ПРОГРАММЫ                                                      "};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
void menu() // Функция выводит главное меню на экран консоли
{
    int CurrentLine = 1;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("═══════════════════════  Г Л А В Н О Е   М Е Н Ю  ════════════════════════\n");
    Console.ForegroundColor = ConsoleColor.White;
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            Console.Write($"{ListMenu[i].ToUpper()}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write($"{ListMenu[i]}\n");
        }
        i++;
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n" +
    "╔════════════════════════════════════════════════════════╤═══════════════╗\n" +
    "║  Используйте [стрелки] для навигации.                  │   ▲ : Вверх   ║\n" +
    "║  [ENTER] - Выбор выделенного пункта                    │   ▼ : Вниз    ║\n" +
    "╚════════════════════════════════════════════════════════╧═══════════════╝\n");
    Console.BackgroundColor = ConsoleColor.Black;
}
int GetNum() // Запрос на ввод целого числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}
double GetDouble() // Запрос на ввод Вещественного числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое или дробное число... ");
    double result1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    return result1;
}
void ErrorCatch() // Функция обрабатывает ошибку, выдает сообщение и запускает программу с начала
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("" +
    "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
    "  ║  Возможно вы ввели не верные данные.                ║\n" +
    "  ║  Программа будет перезапущена...                    ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}
void pause() // Функция паузы, для чтения результатов
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    try
    {
        main();
    }
    catch
    {
        ErrorCatch();
    }
}
void ext() // Функция задает пользователю вопрос хочет ли он выйти из программы и закрывает ее если ответ да
{
AskAgayn:
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("  ╔═ В Ы Х О Д   И З   П Р О Г Р А М М Ы ═══════════════╗  \n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║  \n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║  \n" +
    "  ╚═════════════════════════════════════════════════════╝  \n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("" +
        "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
        "  ║  Вам нужно нажать [ENTER] или [ESC].                ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("" +
        "  ╔═════════════════════════════════════════════════════╗\n" +
        "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        ConsoleKeyInfo key1;
        key1 = Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.Escape) main();
    else if (key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    else main();
}
void PrintDoubleArray(double[] array1) // Вывести на экран массив
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"Average  ");
            Console.Write(array1[i]);
            FieldSize(Convert.ToString(array1[i]).Length, 9);
        }
        else
        {
            Console.Write(array1[i]);
            FieldSize(Convert.ToString(array1[i]).Length, 9);
        }
    }
}
int[] arraySort(int[] array1, int parameter) // Сортировка массива parameter=1 по возрастанию parameter=0 по убыванию
{
    int temp = 0;
    for (int i = 0; i < array1.Length - 1; i++)
    {
        for (int i1 = i; i1 < array1.Length; i1++)
        {
            if (parameter == 1)
            {
                if (array1[i] > array1[i1])
                {
                    temp = array1[i];
                    array1[i] = array1[i1];
                    array1[i1] = temp;
                }
            }
            else
            {
                if (array1[i] < array1[i1])
                {
                    temp = array1[i];
                    array1[i] = array1[i1];
                    array1[i1] = temp;
                }
            }
        }
    }
    return (array1);
}
int[] Enter2DArraySize() // задать длину двухмерного массива
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Укажите размерность двумерного массива [m, n]");
    Console.WriteLine("Укажите размер [m]...");
    int xm1 = GetNum();
    Console.WriteLine("Укажите размер [n]...");
    int xn1 = GetNum();
    int[] result = new int[2];
    result[0] = xm1;
    result[1] = xn1;
    return (result);
}
int[] NumGenDiapason() // Задать диапазон генерации случ. чисел для двухмерного массива
{
EnterAgayn:
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("В каком диапазоне будут генерироваться числа?");
    Console.WriteLine("Укажите начало диапазона...");
    int xx1 = GetNum();
    Console.WriteLine("Укажите конец диапазона...");
    int yy1 = GetNum();
    int[] result = new int[2];
    result[0] = xx1;
    result[1] = yy1;
    return (result);
}
int[,] Fill2dArray(int m, int n, int x, int y)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
        retry:
            int tempnum1 = new Random().Next(x, y);
            for (int i1 = 0; i1 < result.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < result.GetLength(1); j1++)
                {
                    if (tempnum1 == result[i1, j1]) goto retry;
                }
            }
            result[i, j] = tempnum1;
        }
    }
    return (result);
}
void FieldSize(int leng, int size) // Чтобы таблица была ровной
{
    for (int i = 0; i < size - leng; i++)
    {
        Console.Write(" ");
    }
}
void Print2DArray(int[,] array1)
{
    int lng = 9;
    FieldSize(0, lng);
    for (int jj = 0; jj < array1.GetLength(1); jj++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"<{jj}>");
        FieldSize(Convert.ToString(jj).Length, lng - 2);
        Console.ForegroundColor = ConsoleColor.Green;
    }
    Console.WriteLine();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"<{i}>");
                FieldSize(Convert.ToString(i).Length, lng - 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array1[i, j]}");
                FieldSize(Convert.ToString(array1[i, j]).Length, lng);
            }
            else
            {
                Console.Write($"{array1[i, j]}");
                FieldSize(Convert.ToString(array1[i, j]).Length, lng);
            }
        }
        Console.WriteLine();
    }
}
int[] ArrayMin(int[] array1) // int min
{
    int min = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < array1[min]) min = i;
    }
    int[] result = new int[2];
    result[0] = min;
    result[1] = array1[min];
    return (result);
}
int[] ArrayMax(int[] array1) // int max
{
    int max = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > array1[max]) max = i;
    }
    int[] result = new int[2];
    result[0] = max;
    result[1] = array1[max];
    return (result);
}
void PrintIntArray(int[] array1) // Вывести на экран массив
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i != array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.WriteLine($"{array1[i]}.");
    }
}

// ══════════════════════════════════════ ДОМАШНЕЕ ЗАДАНИЕ ══════════════════════════════════════

// 1 Задача //
int[,] SortArrayPosInLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int s = j; s < array.GetLength(1); s++)
            {
                if (array[i, s] > array[i, max]) max = s;
            }
            if (max != j)
            {
                int temp = array[i, max];
                array[i, max] = array[i, j];
                array[i, j] = temp;
            }
        }
    }
    return (array);
}
// 2 Задача //
int[] MinArrayLineSumm(int[,] array)
{
    int[] Lines = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Lines[i] = sum;
    }
    int[] min = ArrayMin(Lines);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"<{min[0]}>   ");
    Console.ForegroundColor = ConsoleColor.Green;
    int[] result = new int[array.GetLength(1)];
    for (int i2 = 0; i2 < result.Length; i2++)
    {
        result[i2] = array[min[0], i2];
    }
    return (result);
}
// 3 Задача //

// 4 Задача //
int[] Enter3DArraySize() // задать длину трехмерного массива
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Укажите размерность двумерного массива [x, y, z]");
    Console.WriteLine("Укажите размер [m]...");
    int x = GetNum();
    Console.WriteLine("Укажите размер [n]...");
    int y = GetNum();
    Console.WriteLine("Укажите размер [o]...");
    int z = GetNum();
    int[] result = new int[3];
    result[0] = x;
    result[1] = y;
    result[2] = z;
    return (result);
}
int[,,] Fill3DArray(int m, int n, int o, int x, int y)
{
    int[,,] array = new int[m, n, o];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
            retry:
                int tempnum1 = new Random().Next(x, y);
                for (int i1 = 0; i1 < array.GetLength(0); i1++)
                {
                    for (int j1 = 0; j1 < array.GetLength(1); j1++)
                    {
                        for (int k1 = 0; k1 < array.GetLength(1); k1++)
                            if (tempnum1 == array[i1, j1, k1]) goto retry;
                    }
                }
                array[i, j, k] = tempnum1;
            }
        }
    }
    return (array);
}
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(0); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})   ");
            }
        }
    }
}
// 5 Задача //

// ═════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Обработка выбранного элемента в меню ═══════════════════════════════
// ВЫПОЛНЕНИЕ ПРОГРАММЫ И ОТСЛЕЖИВАНИЕ НАЖАТИЯ КЛАВИШ
void main()
{
restart:
    menu();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (choice <= ListMenu.Length)
        {
            if (choice == 1)
            {
                choice = ListMenu.Length;
                goto restart;
            }
            else
            {
                choice = choice - 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (choice >= 1)
        {
            if (choice == ListMenu.Length)
            {
                choice = 1;
                goto restart;
            }
            else
            {
                choice = choice + 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        // Здесь объявляются функции которые программа выполнит при выборе того или иного пункта меню
        switch (choice)
        {
            case 1: // Ready
                { // Действие при выборе 1-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию\n" +
                    "элементы каждой строки двумерного массива.");
                    int[] size1 = Enter2DArraySize();
                tryagayn1:
                    int[] NumGen1 = NumGenDiapason();
                    if (NumGen1[1] - NumGen1[0] < size1[0] * size1[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Указанный вами диапазон генерируемых чисел, меньше чем количество элементов генерируемого массива.\n" +
                        "Повторите ввод диапазона...");
                        goto tryagayn1;
                    }
                    int[,] array1 = Fill2dArray(size1[0], size1[1], NumGen1[0], NumGen1[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                    Console.WriteLine("Сгенерирован массив:");
                    Print2DArray(array1);
                    Console.WriteLine("Элементы строк массива отсортированны:");
                    Print2DArray(SortArrayPosInLines(array1));
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 2: // Ready
                { // Действие при выборе 2-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить" +
                    "строку с наименьшей суммой элементов.");
                    int[] size2 = Enter2DArraySize();
                tryagayn1:
                    int[] NumGen2 = NumGenDiapason();
                    if (NumGen2[1] - NumGen2[0] < size2[0] * size2[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Указанный вами диапазон генерируемых чисел, меньше чем количество элементов генерируемого массива.\n" +
                        "Повторите ввод диапазона...");
                        goto tryagayn1;
                    }
                    int[,] array2 = Fill2dArray(size2[0], size2[1], NumGen2[0], NumGen2[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                    Console.WriteLine("Сгенерирован массив:");
                    Print2DArray(array2);
                    Console.WriteLine("Строка с минимальной суммой массива:");
                    PrintIntArray(MinArrayLineSumm(array2));
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 3:
                { // Действие при выборе 3-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");

                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 4: // Ready
                { // Действие при выборе 4-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу," +
                    "которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2");
                    int[] size3 = Enter3DArraySize();
                tryagayn1:
                    int[] NumGen3 = NumGenDiapason();
                    if (NumGen3[1] - NumGen3[0] < size3[0] * size3[1] * size3[2])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Указанный вами диапазон генерируемых чисел, меньше чем количество элементов генерируемого массива.\n" +
                        "Повторите ввод диапазона...");
                        goto tryagayn1;
                    }
                    int[,,] array3 = Fill3DArray(size3[0], size3[1], size3[2], NumGen3[0], NumGen3[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                    Console.WriteLine("Сгенерирован трехмерный массив:");
                    Print3DArray(array3);
                    Console.WriteLine();
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 5:
                { // Действие при выборе 5-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");

                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 6:
                { // Действие при выборе 6-го пункта меню
                    ext();
                    goto restart;
                }
        }
    }
    else goto restart;
}

// ═══════════════════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Запуск обработки меню и выбранного элемента ═══════════════════════════════

try
{
    main();
}

catch
{
    ErrorCatch();
}