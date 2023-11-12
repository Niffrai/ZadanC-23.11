using System.Diagnostics;
using ToysComparer;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВведите номер работы: ");
                int worknum = Convert.ToInt32(Console.ReadLine());

                switch (worknum)
                {
                    case 1:
                        lab1();
                        break;
                    case 2:
                        lab2();
                        break;
                    case 3:
                        lab3();
                        break;
                    case 4:
                        lab4();
                        break;
                    case 5:
                        lab5();
                        break;
                    case 6:
                        lab6();
                        break;
                    case 7:
                        lab7();
                        break;
                    case 8:
                        lab8();
                        break;
                    case 9:
                        lab9();
                        break;
                    case 10:
                        lab10();
                        break;
                    case 11:
                        lab11();
                        break;
                    case 12:
                        lab12();
                        break;
                    case 13:
                        lab13();
                        break;
                    case 14:
                        lab14();
                        break;
                    case 15:
                        lab15();
                        break;
                    case 16:
                        lab16();
                        break;
                }
            }

        }

        static void lab1()
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
                Console.WriteLine($"Удвоенная сумма: ({a}+{b})*2 = {(a + b) * 2}");
            else
                Console.WriteLine($"Сумма: {a}+{b} = {(a + b)}");
        }

        static void lab2()
        {
            Console.WriteLine("Введите число: "); 
            int first = Convert.ToInt32(Console.ReadLine()); 
            if (first > 48)
                Console.WriteLine((first - 48) * 3);
            else
                Console.WriteLine(Math.Abs(first - 48));
        }

        static void lab3()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine() ?? "";
            int x;
            do 
            {
                Console.WriteLine("Введите номер удаляемого символа:");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while ((x < 0) || (x > str.Length));
            str = str.Remove(x, 1); 
            Console.WriteLine(str); 
        }

        static void lab4()
        {
            double b1 = 4.7;
            Console.WriteLine("Введите количество элементов для расчёта. n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Количество элементов не может быть меньше нуля");
                return; 
            }
            for (int i = 1; i <= n; i++)
            {
                double element;
                if (i == 1)
                {
                    element = b1;
                }
                else
                {
                    element = Math.Sin(b1 - 1) + Math.PI; 
                    b1 = element;
                }
                Console.WriteLine($"b{i} = {element}");
            }
            Console.WriteLine("Расчёт окончен");
            Console.ReadKey();
        }

        static void lab5()
        {
            res();

            static long Fib(int n)
            {
                if ((n == 0) || (n == 1))
                    return n;
                return Fib(n - 1) + Fib(n - 2);
            }

            static long Fib2(int n)
            {
                if (n == 0) return 0;
                int prev = 0;
                int next = 1;
                for (int i = 1; i < n; i++)
                {
                    int sum = prev + next;
                    prev = next;
                    next = sum;
                }
                return next;
            }

            void res()
            {
                Console.WriteLine("Первый вариант");
                Console.WriteLine(Fib(0));
                Console.WriteLine(Fib(1));
                Console.WriteLine(Fib(2));
                Console.WriteLine(Fib(3));
                Console.WriteLine(Fib(4));
                Console.WriteLine(Fib(5));

                Console.WriteLine("Второй вариант");
                Console.WriteLine($"Результат рекурсивного метода: {Fib(10)}");
                Console.WriteLine($"Результат метода с циклом: {Fib2(10)}");

                Console.WriteLine("Вывод");
                Stopwatch sw = Stopwatch.StartNew(); 
                long result = Fib(40); 
                sw.Stop(); 
                Console.WriteLine($"Результат рекурсивного метода: {result}. Время выполнения операции {sw.ElapsedTicks} тактов");
                sw.Restart(); 
                result = Fib2(40); 
                sw.Stop();
                Console.WriteLine($"Результат метода с циклом: {result}. Время выполнения операции {sw.ElapsedTicks} тактов");
            }
        }

        static void lab6()
        {
            res();

            static string DecToBin(int n)
            {
                return (n / 2 > 0 ? DecToBin(n / 2) : "") + (char)(n % 2 + '0');
            }
            static void res()
            {
                Console.Write("Введите число. N = ");
                string str = Console.ReadLine() ?? "";
                int n;
                if (int.TryParse(str, out n))
                    Console.WriteLine(DecToBin(n));
                else
                    Console.WriteLine("Ошибка ввода");
            }
        }

        static void lab7()
        {
            string inFile = @"input.txt"; 
            string outFile = @"output.txt"; 
            TextReader save_in = Console.In;
            TextWriter save_out = Console.Out;

            Console.SetIn(new StreamReader(new FileStream(inFile, FileMode.OpenOrCreate)));
            Console.SetOut(new StreamWriter(outFile));
            const double pi = 3.14;
            string strRadius = Console.ReadLine() ?? "";
            if (double.TryParse(strRadius, out double radius)) 
            {
                if ((radius <= 0) || (radius > 100000))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    Console.WriteLine($"L = {Math.Round(2 * pi * radius, 3)}");
                    Console.WriteLine($"S = {Math.Round(pi * Math.Pow(radius, 2), 3)}");
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.In.Close();
            Console.Out.Close();
            Console.SetIn(save_in);
            Console.SetOut(save_out);
        }

        static void lab8()
        {
            int count = 0;
            Console.WriteLine("Какое количество чисел Вы хотите задать?");
            Console.WriteLine("count =");
            count = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[count];
            int i = 0;
            while (i < count)
            {
                Console.WriteLine($"Введите число #{i + 1}: ");
                try
                {
                    array[i] = Convert.ToDouble(Console.ReadLine());
                    i++;
                }
                catch
                {
                    Console.WriteLine($"Что-то пошло не так. Введите число #{i + 1} ещё раз");
                }
            }
            Console.WriteLine("Исходный массив заполнен");
            /// Метод создания через Список
            
            //List<double> list = new List<double>();
            //foreach (double value in array)
            //{
            //    if (value > 0)
            //        list.Add(value);
            //}
            //Console.WriteLine($"Количество положительных чисел: {list.Count}");

            IEnumerable<double> result = array.Where(x => x > 0);
            Console.WriteLine($"Количество положительных чисел:{result.Count()}");
            Console.WriteLine(string.Join(" ", result));
        }

        static void lab9()
        {
            Main();

            static void SortAscending(int[] intArray)
            {
                int indx;
                for (int i = 0; i < intArray.Length; i++)
                {
                    indx = i; 
                    for (int j = i; j < intArray.Length; j++) 
                    {
                        if (intArray[j] < intArray[indx])
                        {
                            indx = j;
                        }
                    }
                    if (intArray[indx] == intArray[i]) 
                        continue;

                    int temp = intArray[i]; 
                    intArray[i] = intArray[indx];
                    intArray[indx] = temp;
                }
            }

            static void SortDescending(int[] intArray)
            {
                int indx;
                for (int i = 0; i < intArray.Length; i++)
                {
                    indx = i;
                    for (int j = i; j < intArray.Length; j++)
                    {
                        if (intArray[j] > intArray[indx])
                        {
                            indx = j;
                        }
                    }
                    if (intArray[indx] == intArray[i])
                        continue;

                    int temp = intArray[i];
                    intArray[i] = intArray[indx];
                    intArray[indx] = temp;
                }
            }

            static int[] ConcatArrays(int[] a, int[] b)
            {
                int[] c = new int[a.Length + b.Length]; 
                for (int i = 0; i < a.Length; i++) 
                    c[i] = a[i];
                for (int i = a.Length; i < a.Length + b.Length; i++) 
                    c[i] = b[i - a.Length]; 
                return c;
            }

            static void Main()
            {
                int[] a = new int[5] { 6, 1, 4, 11, 42 };
                int[] b = new int[5] { 3, 5, 10, -1, 6 };
                SortAscending(a);
                SortDescending(b); 
                int[] c = ConcatArrays(a, b); 
                foreach (int i in c)
                    Console.Write($"{i} ");
            }
        }

        static void lab10()
        {
            int colCount = 6;
            int rowCount = 5;
            int[,] arr = GenerateArray(rowCount, colCount);

            Console.WriteLine("Исходный массив");
            PrintArray(arr);
            Console.WriteLine("Сортировка по строкам: ");

            int[] row = new int[colCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = arr[i, j];
                BubbleSort(row);
                Insert(true, i, row, arr);
            }

            PrintArray(arr);

            Console.WriteLine("Сортировка по столбцам: ");
            int[] col = new int[rowCount];

            for (int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                    col[j] = arr[j, i];
                BubbleSort(col);
                Insert(false, i, col, arr);
            }

            PrintArray(arr);

            static void Insert(bool isRow, int dim, int[] source, int[,] dest)
            {
                for (int k = 0; k < source.Length; k++)
                {
                    if (isRow)
                        dest[dim, k] = source[k];
                    else
                        dest[k, dim] = source[k];
                }
            }


            static int[,] GenerateArray(int t, int i)
            {
                int[,] table = new int[t, i];
                Random random = new Random();

                for (int a = 0; a < t; a++)
                {
                    for (int b = 0; b < i; b++)
                    {
                        table[a, b] = random.Next(0, 9);
                    }
                }
                return table;
            }


            static void PrintArray(int[,] array)
            {
                for (int a = 0; a < array.GetLength(0); a++)
                {
                    for (int b = 0; b < array.GetLength(1); b++)
                    {
                        Console.Write(array[a, b] + " ");
                    }
                    Console.WriteLine();
                }
            }


            static void BubbleSort(int[] inArray)
            {
                for (int i = 0; i < inArray.Length; i++)
                    for (int j = 0; j < inArray.Length - i - 1; j++)
                    {
                        if (inArray[j] > inArray[j + 1])
                        {
                            int temp = inArray[j];
                            inArray[j] = inArray[j + 1];
                            inArray[j + 1] = temp;
                        }
                    }
            }
        }

        static void lab11()
        {
            Main();


            static int Generator(string fileName)
            {
                string str;
                int val = 0;

                while (val <= 0)
                {
                    Console.Write("N = ");
                    str = Console.ReadLine() ?? "";
                    if (int.TryParse(str, out val))
                    {
                        if (val > 0)
                        {
                            using StreamWriter writer = new StreamWriter(fileName);
                            {
                                writer.WriteLine(val);
                                Random random = new Random();
                                for (int i = 0; i < val; i++)
                                    writer.Write($"{random.Next(100001)} ");
                            }
                        }
                    }
                }
                return val;
            }


            static void Main()
            {
                const string fileName = "input.txt";
                Console.WriteLine($"Введите количество элементов массива");
                int count = Generator(fileName);
                Console.WriteLine($"Массив из {count} элементов сгенерирован и сохранен");
                TextReader save_in = Console.In;
                string strElements; 
                string N;
                using StreamReader reader = new StreamReader(fileName);
                {
                    Console.SetIn(reader);
                    N = reader.ReadLine() ?? "";
                    strElements = reader.ReadLine() ?? "";
                }
                Console.SetIn(save_in);
                int summa = 0;
                string[] strArray = strElements.Split(' ');
                int[] data = new int[Convert.ToInt32(N)];
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (int.TryParse(strArray[i], out int value))
                    {
                        data[i] = value;
                        summa += value;
                    }
                }
                double avg = (float)summa / data.Length;

                int max = 0; 
                int sumMinValue = 0; 
                int countMax = 0; 
                foreach (int value in data)
                {
                    if (value > max)
                        max = value;
                    if (value > avg)
                        countMax++;
                    else
                        if (value < avg)
                        sumMinValue += value;
                }

                Console.WriteLine($"Среднее арифметическое значение: {avg:F3}");
                Console.WriteLine($"Максимальное значение: {max}");
                Console.WriteLine($"Количество элементов больших, чем среднее арифметическое: {countMax}");
                Console.WriteLine($"Сумма элементов меньших, чем среднее арифметическое: {sumMinValue}");

                const string outputFile = "output.txt";
                TextWriter save_out = Console.Out;
                using StreamWriter writer = new StreamWriter(outputFile);
                {
                    Console.SetOut(writer);
                    Console.WriteLine(countMax);
                    Console.WriteLine(sumMinValue);
                    Console.WriteLine(max);
                }
                Console.SetOut(save_out);
            }
        }

        static void lab12()
        {
            Main();


            static void WriteFile(string fileName, Toy[] toys)
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (Toy toy in toys)
                        sw.WriteLine(toy.ToString());
                }
            }

            static Toy[] ReadFile(string fileName)
            {
                string[] lines = File.ReadAllLines(fileName);
                Toy[] toys = new Toy[lines.Length];
                int i = 0;
                foreach (string s in lines)
                {
                    string[] toyFields = s.Split(new[] { ';' });
                    if (toyFields.Length >= 4)
                    {
                        toys[i].Name = toyFields[0];
                        toys[i].Price = Convert.ToInt32(toyFields[1]);
                        toys[i].AgeMin = Convert.ToInt32(toyFields[2]);
                        toys[i].AgeMax = Convert.ToInt32(toyFields[3]);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid format in line: {s}");
                    }
                    i++;
                }
                return toys;
            }

            static void Display(Toy[] toys)
            {
                foreach (Toy toy in toys)
                {
                    Console.WriteLine($"Наименование: {toy.Name}\tСтоимость: {toy.Price} руб.\tВозрастные ограницения: от {toy.AgeMin} до {toy.AgeMax} лет");
                }
            }

            static void Main()
            {
                string inputFile = "input.txt";
                string outputFile = "output.txt";
                Toy[] toys = ReadFile(inputFile);

                Console.WriteLine("--------Исходный массив--------");
                Display(toys);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Введите минимальный возраст");
                int MinAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите максимальный возраст");

                int MaxAge = Convert.ToInt32(Console.ReadLine());
                var selected = toys.Where(w => (Enumerable.Range(w.AgeMin, w.AgeMax).Contains(MinAge) && (Enumerable.Range(w.AgeMin, w.AgeMax).Contains(MaxAge))));
                Toy[] outToys = selected.ToArray();

                Console.WriteLine("--------Итоговый массив--------");
                Array.Sort(outToys); 
                WriteFile(outputFile, outToys);
                Display(outToys);
                Console.WriteLine("-------------------------------");
            }
        }

        static void lab13()
        {
            Programmer programmer = new Programmer();
            programmer.Name = "Вася";
            programmer.Surname = "Пупкин";
            programmer.Age = 25;
            programmer.Experience = 7;
            programmer.Language = "C#";
            Console.WriteLine(programmer.ToString());
        }

        class EmptyStringException : Exception
        {
            public EmptyStringException() : base()
            { }
        }
        class VeryLongNumberException : Exception
        {
            public VeryLongNumberException() : base()
            { }
        }

        static void lab14()
        {
            Main();


            static double ParseString(string str)
            {
                byte maxLength = 20; 
                if ((str == null) || (str == string.Empty))
                    throw new EmptyStringException();
                if (str.Length > maxLength)
                    throw new VeryLongNumberException();
                return double.Parse(str);
            }

            static void Main()
            {
                try
                {
                    Console.WriteLine("Введите первое число и нажмите Enter:");
                    double first = ParseString(Console.ReadLine());
                    Console.WriteLine("Введите второе число и нажмите Enter:");
                    double second = ParseString(Console.ReadLine());
                    Console.WriteLine(first / second);
                }
                catch (FormatException)
                {
                    Console.WriteLine("ошибка преобразования");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("деление на ноль");
                }
                catch (EmptyStringException)
                {
                    Console.WriteLine("Не введено число");
                }
                catch (VeryLongNumberException)
                {
                    Console.WriteLine("Введено слишком длинное число");
                }
            }
        }

        static void lab15()
        {
            Edition[] editions = new Edition[]
                {
                new Book()
                {
                    Year = 1992,
                    Publisher = "Cуперкнига",
                    Author = "Пупкин",
                    Name = "К вопросу о лабораторных работах по C#"
                },
                new Article()
                {
                    Year = 2022,
                    Author = "Иванов",
                    Name = "Статья по C#",
                    Journal = "Программирование в C#",
                    Number = 11
                },
                new Ebook()
                {
                    Annotation = "В этой статье разрабатывается абстрактный класс",
                    Author = "Vlad",
                    Name = "Лабораторная работа по C#. Абстрактные классы",
                    Href = "https://csharp.webdelphi.ru"
                },
                new Book()
                {
                    Year = 2001,
                    Publisher = "Cуперкнига",
                    Author = "Пупкин",
                    Name = "Лучшая книга по C#"
                }
                };
            Console.WriteLine("");
            Console.WriteLine("Создеражиние каталога изданий");
            foreach (Edition edition in editions)
            {
                Console.WriteLine(edition.Display());
            }
            Console.WriteLine("");
            Console.WriteLine("Введите фамилию автора издания которого необходимо найти");

            string author = Console.ReadLine() ?? "";
            Console.WriteLine($"Результаты поиска по автору {author}");
            foreach (Edition edition in editions)
            {
                if (edition.IsThisEdition(author))
                {
                    Console.WriteLine(edition.Display());
                }
            }
        }

        static void lab16()
        {
            Main();

            static void Display(IEnumerable<IGrouping<int, int>> group)
            {
                foreach (IGrouping<int, int> element in group)
                    Console.WriteLine($"Число {element.Key} встречается {element.Count()} раз");
            }

            static void Main()
            {
                //задаем исходный масссив
                int[] array = { 1, 2, 3, 4, 5, 6, 1, 1, 1, 1, 1, 1, 4, 5, 6, 7, 8, 6, 6, 6, 6, 6, 1, 2, 3 };
                //группируем массив по уникальным числам
                var mass = array.GroupBy(x => x);
                Display(mass);

                Console.WriteLine("Введите N");
                int N = Convert.ToInt32(Console.ReadLine());
                //сортируем по убыванию частоты и выбираем N элементов
                mass = mass.OrderByDescending(x => x.Count()).Take(N);
                Display(mass);
            }
        }
    }
}