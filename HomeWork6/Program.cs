// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41()
{
    Console.WriteLine("Сколько чисел будете вводить?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int count = 0;

    FillArrayHandle(array);

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
            count++;
    }

    Console.WriteLine($"Введено {count} чисел больше 0");
}

//Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
void Zadacha43()
{
    Console.WriteLine("Введите коэффициент k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2");
    int b2 = Convert.ToInt32(Console.ReadLine());

    if (k1 == 0)
        Console.WriteLine($"Уравнение первой прямой:  y={b1}");
    else if (b1 > 0)
            Console.WriteLine($"Уравнение первой прямой:  y={k1}*x+{b1}");
        else if (b1 < 0)
                Console.WriteLine($"Уравнение первой прямой:  y={k1}*x{b1}");
            else
                Console.WriteLine($"Уравнение первой прямой:  y={k1}*x");
    if (k2 == 0)
        Console.WriteLine($"Уравнение второй прямой:  y={b2}");
    else if (b2 > 0)
            Console.WriteLine($"Уравнение второй прямой:  y={k2}*x+{b2}");
        else if (b2 < 0)
                Console.WriteLine($"Уравнение второй прямой:  y={k2}*x{b2}");
            else
                Console.WriteLine($"Уравнение второй прямой:  y={k2}*x");
    
    if (k1 == k2)
    {
        if (b1 == b2)
            Console.WriteLine("Прямые совпадают");
        else   
            Console.WriteLine("Прямые параллельны, точек пересечения нет");
    }
    else
    {
        double x = Math.Round((double)(b2 - b1) / (double)(k1 - k2),2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых имеет координаты ({x};{y})");
    }
}


// Заполнение массива с клавиатуры поэлементно
void FillArrayHandle(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число номер {i+1}:  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


Zadacha41();
Zadacha43();