// Создание функций (методов класса)
using System; 

namespace project { 
    class Program { 
        static void Main() 
        { 
            //Пример 1 
                //первый вариант вывода
            Print("Hello!"); 
                //второй вариант вывода
            string words = "Hello world!";
            Print(words);
            
            //Пример 2
                //первый вариант вывода
            Summa(5, 9);
                //второй вариант вывода
            int a = 3, b = 8;
            Summa(a, b);

            //Пример 3
            int res1 = Summ(6, 2);
            int a1 = 3, b1 = 4;
            int res2 = Summ(a1, b1);

            Print(res1.ToString()); //т.к функция Print написана в формате string - добавляем конвертацию ToString
            Print(res2.ToString());

            //Пример 4
            byte[] numms = {5, 7, 8, 3, 5};
            byte res3 = SumArray(numms);
            Console.WriteLine("Сумма :  " + res3);    
        }
        //'public' - публичный модификатор доступа, к которому могут обращаться все классы, 'static' - статичная функция, "void' - не возвращающий тип, 'Print' - название функции 
        
        // 1.Функция - Вывод на консоль строки
        public static void Print(string word)
        {
            Console.WriteLine(word); 
        }
        
        // 2. Функция (без возвращения)- Вывод на консоль суммы двух чисел

        public static void Summa(int x, int y) 
        {
            int res = x + y;
            Console.WriteLine("Сумма :  " + res);  //первый вариант вывода на консоль
            // Print("Сумма :  " + res);      //второй ваариант вывода на консоль - если ранее прописана функция Print
        }

        // 3. Функция (с возвращением)- Вывод на консоль суммы двух чисел

        public static int Summ(int x, int y) 
        {
            return x + y;
        }

        // 4. Функция - Подсчет сумы элементов массива
        public static byte SumArray(byte[] array)
        {
            byte sum = 0;
            foreach(byte el in array)
                sum += el;
            return sum;
        }



    }
}