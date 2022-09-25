// ══════════════════════════════════ Главное меню и основные функции ══════════════════════════════════

int choice = 1; // ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
// Список меню
string[] ListMenu = {
    "  Задача 54: Отсортировать строки массива по убыванию.                    ",
    "  2 Пункт меню                                                            ",
    "  3 Пункт меню                                                            ",
    "  4 Пункт меню                                                            ",
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
void PrintArray(double[] array1) // Вывести на экран массив
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
int[] Enter2DArraySize()
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
int[] NumGenDiapason()
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
// 3 Задача //
// 4 Задача //
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
            case 1:
                { // Действие при выборе 1-го пункта меню
                    Console.Clear();
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
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    Console.WriteLine("Сгенерирован массив:");
                    Print2DArray(array1);
                    Console.WriteLine("Элементы строк массива отсортированны:");
                    Print2DArray(SortArrayPosInLines(array1));
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 2:
                { // Действие при выборе 2-го пункта меню
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");

                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 3:
                { // Действие при выборе 3-го пункта меню
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");

                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 4:
                { // Действие при выборе 4-го пункта меню
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");

                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 5:
                { // Действие при выборе 5-го пункта меню
                    Console.Clear();

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