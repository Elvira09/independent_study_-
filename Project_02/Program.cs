﻿using System;

namespace project {
    class Program {
        static void Main() {
            //ВВОДНЫЕ ДАННЫЕ по переменным и типам данных:
            int number = -10; // int - тип данных целого числа (ОТРИЦАТЕЛЬНОГО и ПОЛОЖИТЕЛЬНОГО), number - название переменной
            Console.WriteLine(number); // вывели в консоль значение переменной number           
            number = 10; //поменяли значение переменной
            Console.WriteLine(number); // вывели в консоль новое значение переменной number    
            number = 567098; 
            Console.WriteLine("Переменная типа данных int (целые положительные и отрицательные числа): " + number); // вывели в консоль новое значение переменной number С ТЕКСТОМ, текст и значение объединяется знаком '+'    
            
            uint number1 = 100; // uint - тип данных целого ПОЛОЖИТЕЛЬНОГО числа, 
            Console.WriteLine("Переменная типа данных uint (целые положительные числа): " + number1);           
            
            byte number2 = 255; //byte - тип данных целого числа в диапозоне от '-255 до 255' включительно, потребляет в 4 раза меньше памяти чем тип данных int 
            Console.WriteLine("Переменная типа данных byte (целые числа в диапозоне '-255 до 255'): " + number2); 
            
            short number3 = 32000; //short - - тип данных целого числа в диапозоне от '-32000 до 32000' включительно, потребляет в 2 раза меньше памяти чем тип данных int 
            Console.WriteLine("Переменная типа данных short (целые числа в диапозоне -32000 до 32000'): " + number3); // вывели в консоль новое значение переменной number С ТЕКСТОМ, текст и значение объединяется знаком '+'    
        
            long number4 = 45734234234242; //long - тип данных целого числа в диапозоне гигантских чисел
            Console.WriteLine("Переменная типа данных long (целые гигантские положительные и отрицательные числа): " + number4); 
            
            //в терминале число с точкой вводиться ЧЕРЕЗ ЗАПЯТУЮ
            float number5 = 43534.5346f; //float - тип данных числа с точкой, в конце числа обязательно ставить букву 'f'
            Console.WriteLine("Переменная типа данных float (числа с точкой): " + number5); 
   
            double number6 = 89014356.434475399d; //double - тип данных больших чисел с точкой, в конце числа обязательно ставить букву 'f'
            Console.WriteLine("Переменная типа данных double (большие числа с точкой): " + number6); 

            string word = "Hello world"; //string - тип данных строка (набор символов), значение переменной вводится в ДВОЙНЫХ кавычках
            Console.WriteLine("Переменная типа данных string: " + word); 

            char symbol = 'G'; //char - тип данных для хранения ОДНОГО символа, значение переменной вводится в ОДИНАРНЫХ кавычках
            Console.WriteLine("Переменная типа данных char: " + symbol); 

            bool isHappy = false; //bool - тип данных для хранения всего двух значения false(ЛОЖЬ) или true(ИСТИНА), используется в условных оператоорах или циклах
            Console.WriteLine("Переменная типа данных bool: " + isHappy); 

            //ПРАКТИЧЕСКОЕ ЗАДАНИE:
            int num1 = 0, num2 = 0;
            num1 = Convert.ToInt32(Console.ReadLine()); //в переменную num1 помещаем число, полученное от пользователя посредством Метода ReadLine и конвертируем с формата string в int посредством команды ToInt32
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First: " + num1 + "  Second: " + num2);
        }
    }
}

/*
            Console.WriteLine("Hello 1"); // выводит текст в консоль С НОВОЙ строки
            Console.Write("Hello 2"); // выводит текст в консоль В ОДНУ строку
            Console.Write("Hello 3");
            Console.Write("Hello 4\n\n"); // '\n' - вариант вывода текста с новой строки при использовании Write
            Console.Write("Hello 5");
            Console.WriteLine("Hello 6");
            Console.ReadKey(); // Метод получение данных от пользователя из терминала ЛИШЬ ОДНОГО СИМВОЛА
            Console.ReadLine(); // Метод получение данных от пользователя из терминала МНОГО СИМВОЛОВ
        }
        */

            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First: " + num1 + "  Second: " + num2);
        }
    }
}
