﻿using System;

namespace project {
    class Program {
        static void Main() {
        //ПРОСТЫЕ МАТЕМАТИЧЕСКИЕ ДЕЙСТВИЯ:
        Console.Write("Введите число с точкой: "); //просим пользователя ввести число
            //user_input = Convert.ToDouble(Console.ReadLine()); //в переменную помещаем число, полученное от пользователя посредством Метода ReadLine и конвертируем с формата string в float посредством команды ToDouble
            //float user_input;
            //user_input = float.Parse(Console.ReadLine()); //в переменную помещаем число, полученное от пользователя посредством Метода ReadLine и конвертируем с формата string в float посредством команды Float.Parse  
        float user_input = float.Parse(Console.ReadLine()); //строки 8 и 9 можно объединить в одну
        float result = user_input + 10f; //делаем операцию сложения с числом, вееденным пользователем
            //result = user_input - 15f;
            //result = user_input * 2f;
            //result = user_input / 4f;
            //result = user_input % 3f;
        result *= 2f; //сокращенный вариант действия result = result * 2f
        result--; //от переменной отнимаем 1, если написать '++' - прибавляем единицу 
            //int a = 5, b = 6;
            //int res = a + b;
        Console.WriteLine("Результат операций: " + result); //выводим в терминал число ? полученное от пользователя

        //ВСТРОЕННЫЕ МАТЕМАТИЧЕСКИЕ ФУНКЦИИ:
                //Константа от переменной отличается тем, что ее НЕЛЬЗЯ переопределить
                //класс Math является статическим и обращается к константе .
        Console.WriteLine("Выводим на экран число ПИ: " + Math.PI); //PI - число ПИ. 
        //В скобках функции вместо числа можно вводить переменную, которая задается ранее
        Console.WriteLine("Выводим на экран число по модулю: " + Math.Abs(-20)); //Abs(число) - модуль числа
        Console.WriteLine("Выводим на экран округленное до большего число: " + Math.Ceiling(4.11f)); //Ceiling(число) - округляет число до большего
        Console.WriteLine("Выводим на экран округленное до меньшего число: " + Math.Floor(4.99f)); //Floor(число) - округляет число до меньшего
        Console.WriteLine("Выводим на экран округленное до меньшего число: " + Math.Round(4.56f)); //Round(число) - округляет число до целого по математическим правилам в зависимости от указанного числа
        Console.WriteLine("Выводим на экран косинус числа: " + Math.Cos(30)); //Cos(число) - вычисляет косинус числа. По  аналогии синус и т.д.
        Console.WriteLine("Выводим на экран синус числа: " + Math.Sin(30)); //Sin(число) - вычисляет синус числа. По  аналогии синус и т.д.
        Console.WriteLine("Выводим на экран максимальное число: " + Math.Max(9, 5)); //Max(число, число) - вычисляет максимальное число
        Console.WriteLine("Выводим на экран минимальное число: " + Math.Min(9, 5)); //Min(число, число) - вычисляет минимальное число
        Console.WriteLine("Выводим на экран число возведенное в степень: " + Math.Pow(9, 5)); //Pow(число, степень) - возводит число в степень

            //Пример программки
        Console.WriteLine("Введите радиус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine()); //в переменную radius помещаем число, полученное от пользователя в терминале посредством Метода ReadLine и конвертируем с формата double в int посредством команды ToDouble 
        double area = Math.PI * Math.Pow(radius, 2); // Площадь круга равна ПИ * радиус в квадрате
        Console.WriteLine("Площадь круга с радиусом {0} равна {1} ", radius, area); //выводим на консоль результат, при этом значения подставляются автоматически в {0} - radius , в {1} - area, которые после текста указываются через запятую

        }
    }
}

